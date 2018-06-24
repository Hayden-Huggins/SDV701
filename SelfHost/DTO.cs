// Created by Hayden Huggins 20/06/2018
// This class is our data transfer objects, we use these objects to store and submit information to and from this service
// It is not trivial that we have DTO's here otherwise how will we pass all of the information through? 


using System;

namespace SelfHost
{

    public class clsGenre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MaturityLevel { get; set; }
    }

    public class clsAllBook
    {
        public string ISBN { get; set; }
        public string GenreName { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? LastModified { get; set; }
        public int? Quantity { get; set; }
        public string BookFormat { get; set; }
        public string CoverType { get; set; }
        public string SerialKey { get; set; }
        public string DownloadURL { get; set; }

        public static clsAllBook NewBook(string prChoice)
        {
            return new clsAllBook() { BookFormat = prChoice.ToUpper() };
        }
    }

    public class clsOrder
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string BookISBN { get; set; }
        public int Quantity { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public string Status { get; set; }
    }
}
