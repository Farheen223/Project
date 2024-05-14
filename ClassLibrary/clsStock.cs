using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool inStock { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public int ItemPrice { get; set; }
        public string ItemName { get; set; }
        public int SupplierID { get; set; }
        public int ItemID { get; set; }
    }
}