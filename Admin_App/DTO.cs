﻿// Created by Hayden Huggins 20/06/2018
// This class is our data transfer objects, we use these objects to store and submit information to and from the Self Hosted service
// this class also helps us override string formats by however we like to and perform calculations on data

using System;
using System.Collections.Generic;
using System.Linq;

namespace Admin_App
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

        public override string ToString()
        {
            return Name + "\t" + BookFormat + "\t" + Price;
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

        public static int CalculatePendingOrders(List<clsOrder> prOrderList)
        {
            int lcOrderCount = 0;
            return lcOrderCount = prOrderList.Count();
        }

        public static decimal CalculateTotalOrderValue(List<clsOrder> prOrderList)
        {
            decimal lcTotalOrderValue = 0;
            foreach (clsOrder lcOrder in prOrderList)
            {
                lcTotalOrderValue += lcOrder.OrderTotal;
            }
            return lcTotalOrderValue;
        }

        public override string ToString()
        {
            return  CustomerName + "\t" + CustomerAddress + "\t" + BookISBN + "\t" + Quantity + "\t" + TimeOfOrder + "\t" + OrderTotal;
        } 
    }
}
