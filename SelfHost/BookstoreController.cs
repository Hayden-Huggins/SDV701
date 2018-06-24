// Created by Hayden Huggins 20/06/2018
// This class is very important, this is what all of the URI links all map too directly
// The names must be the exact same between this and the service client classes for mapping to work correctly
// However, Names of the service clients need the suffix Async 
// This class helps us insert, update, delete and insert data, all in regards to the bookstore
// being orders and books to specific genres

using System;
using System.Collections.Generic;
using System.Data;

namespace SelfHost
{
    public class BookstoreController : System.Web.Http.ApiController
    {

        public string DeleteBook(string prName)
        {   // delete
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "DELETE FROM tblBook WHERE Name='" + prName + "'", null);
                if (lcRecCount == 1)
                    return "One Book deleted";
                else
                    return "Unexpected Book delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string DeleteOrder(string prCustName)
        {   // delete
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "DELETE FROM tblOrder WHERE custName='" + prCustName + "'", null);
                if (lcRecCount == 1)
                    return "One Order deleted";
                else
                    return "Unexpected Book delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public clsAllBook GetBook(string prName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("prName", prName);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM tblBook WHERE Name=@prName", par);
            if (lcResult.Rows.Count > 0)
                return new clsAllBook()
                {
                    ISBN = (string)lcResult.Rows[0]["ISBN"],
                    GenreName = (string)lcResult.Rows[0]["GenreName"],
                    Name = (string)lcResult.Rows[0]["Name"],
                    Price = (decimal)lcResult.Rows[0]["Price"],
                    LastModified = (DateTime)lcResult.Rows[0]["LastModified"],
                    Quantity = (int)lcResult.Rows[0]["Quantity"],
                    BookFormat = (string)lcResult.Rows[0]["BookFormat"],
                    CoverType = (string)lcResult.Rows[0]["CoverType"],
                    SerialKey = (string)lcResult.Rows[0]["SerialKey"],
                    DownloadURL = (string)lcResult.Rows[0]["DownloadURL"]
                };
            else
                return null;
        }

        public List<clsAllBook> GetBookQuery(string prName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("prName", prName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM tblBook WHERE Name = @prName", par);
            List<clsAllBook> lcBooks = new List<clsAllBook>();
            foreach (DataRow dr in lcResult.Rows)
                lcBooks.Add(dataRow2AllBook(dr));
            return lcBooks;

        }

        public clsGenre GetGenre(string prName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("prName", prName);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM tblGenre WHERE Name=@prName", par);
            if (lcResult.Rows.Count > 0)
                return new clsGenre()
                {
                    Name = (string)lcResult.Rows[0]["Name"],
                    Description = (string)lcResult.Rows[0]["Description"],
                    MaturityLevel = (string)lcResult.Rows[0]["MaturityLevel"]
                };
            else
                return null;
        }

        public List<clsAllBook> GetGenreBooks(string prGenreName)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("prGenreName", prGenreName);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM tblBook WHERE GenreName = @prGenreName ORDER BY name ASC", par);
            List<clsAllBook> lcBooks = new List<clsAllBook>();
            foreach (DataRow dr in lcResult.Rows)
                lcBooks.Add(dataRow2AllBook(dr));
            return lcBooks;

        }

        public List<string> GetGenreNames()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT Name FROM tblGenre ORDER BY name ASC", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows) lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public List<clsOrder> GetOrders()
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM tblOrder ORDER BY custName ASC", null);
            List<clsOrder> lcOrders = new List<clsOrder>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrders.Add(dataRow2Order(dr));
            return lcOrders;

        }

        public string PostBook(clsAllBook prBook)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO tblBook " +
                "(ISBN, GenreName, Name, Price, LastModified, Quantity, BookFormat, CoverType, SerialKey, DownloadURL) " +
                "VALUES (@ISBN, @GenreName, @Name, @Price, @LastModified, @Quantity, @BookFormat, @CoverType, @SerialKey, @DownloadURL)",
                prepareBookParameters(prBook));
                if (lcRecCount == 1)
                    return "One book inserted";
                else
                    return "Unexpected book insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PostOrder(clsOrder prOrder)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO tblOrder " +
                "(CustName, CustEmailAddress, BookISBN, Quantity, OrderTotal, TimeOfOrder, Status) " +
                "VALUES (@CustName, @CustEmailAddress, @BookISBN, @Quantity, @OrderTotal, @TimeOfOrder, @Status)",
                prepareOrderParameters(prOrder));
                if (lcRecCount == 1)
                    return "One order inserted";
                else
                    return "Unexpected order insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutBook(clsAllBook prBook)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute("UPDATE tblBook SET " +
                "GenreName = @GenreName, Name = @Name, Price = @Price," +
                "BookFormat = @BookFormat, LastModified = @LastModified, Quantity = @Quantity, CoverType = @CoverType, SerialKey = @SerialKey, DownloadURL = @DownloadURL WHERE ISBN=@ISBN",
                prepareBookParameters(prBook));
                if (lcRecCount == 1)
                    return "One book updated";
                else
                    return "Unexpected book update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutBookQuantity(clsAllBook prBook)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute("UPDATE tblBook SET " +
                "Quantity = Quantity -@Quantity WHERE ISBN=@ISBN",
                prepareBookParameters(prBook));
                if (lcRecCount == 1)
                    return "One book updated";
                else
                    return "Unexpected book update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareBookParameters(clsAllBook prBook)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("ISBN", prBook.ISBN);
            par.Add("GenreName", prBook.GenreName);
            par.Add("Name", prBook.Name);
            par.Add("Price", prBook.Price);
            par.Add("LastModified", prBook.LastModified);
            par.Add("Quantity", prBook.Quantity);
            par.Add("BookFormat", prBook.BookFormat);
            par.Add("CoverType", prBook.CoverType);
            par.Add("SerialKey", prBook.SerialKey);
            par.Add("DownloadURL", prBook.DownloadURL);
            return par;
        }

        private Dictionary<string, object> prepareOrderParameters(clsOrder prOrder)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("CustName", prOrder.CustomerName);
            par.Add("CustEmailAddress", prOrder.CustomerAddress);
            par.Add("BookISBN", prOrder.BookISBN);
            par.Add("Quantity", prOrder.Quantity);
            par.Add("OrderTotal", prOrder.OrderTotal);
            par.Add("TimeOfOrder", prOrder.TimeOfOrder);
            par.Add("Status", prOrder.Status);
            return par;
        }

        private clsAllBook dataRow2AllBook(DataRow prDataRow)
        {
            return new clsAllBook()
            {
                ISBN = (string)prDataRow["ISBN"],
                Name = (string)prDataRow["Name"],
                Price = (decimal)prDataRow["Price"],
                GenreName = (string)prDataRow["GenreName"],
                LastModified = Convert.ToDateTime(prDataRow["LastModified"]),
                Quantity = (int)prDataRow["Quantity"],
                BookFormat = (string)prDataRow["BookFormat"],
                CoverType = (string)prDataRow["CoverType"],
                SerialKey = (string)prDataRow["SerialKey"],
                DownloadURL = (string)prDataRow["DownloadURL"]
            };

        }

        private clsOrder dataRow2Order(DataRow prDataRow)
        {
            return new clsOrder()
            {
                CustomerName = (string)prDataRow["custName"],
                CustomerAddress = (string)prDataRow["custEmailAddress"],
                BookISBN = (string)prDataRow["bookISBN"],
                Quantity = (int)prDataRow["quantity"],
                OrderTotal = (decimal)prDataRow["orderTotal"],
                TimeOfOrder = (DateTime)prDataRow["timeOfOrder"],
                Status = (string)prDataRow["status"]
            };

        }
    }
}
