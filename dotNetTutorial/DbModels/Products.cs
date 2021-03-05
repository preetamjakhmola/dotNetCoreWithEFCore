using System;
using System.Collections.Generic;

namespace dotNetTutorial.DbModels
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string CustomerId { get; set; }
        public string ProductName { get; set; }
    }
}
