using System;

namespace Testing2
{
    public class clsCustomer
    {
        public bool Active { get; internal set; }
        public string Town { get; internal set; }
        public string Street { get; internal set; }
        public string PostCode { get; internal set; }
        public string HouseNo { get; internal set; }
        public int CountyCode { get; internal set; }
        public int CustomerId { get; internal set; }
        public DateTime DateAdded { get; internal set; }
    }
}