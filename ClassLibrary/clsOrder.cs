using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public string PaymentSuccessful { get; set; }

        public string TotalAmount { get; set; }

        public Int32 OrderId { get; set; }

        public string StaffId { get; set; }

        public int CustomerId { get; set; }

        public DateTime Date { get; set; }

        public Int32 OrderLineId { get; set; }

        public int Quantity { get; set; }

        public int StockId { get; set; }
    }

    public bool Find(int OrderId) 
    {
        return true;
    }
}