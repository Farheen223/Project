using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public int ItemPrice { get; set; }
        public string ItemName { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
    }
}