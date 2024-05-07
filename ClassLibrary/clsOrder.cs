using System;

namespace Testing6
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public string HouseNo { get; set; }
        public int CountyCode { get; set; }
        public int OrderId { get; set; }
    }
}