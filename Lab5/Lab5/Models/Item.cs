using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab5.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public float ItemPrice { get; set; }
        public float ItemWeight { get; set; }
        public byte[] ItemPhoto { get; set; }
        //Khoa ngoai 
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}