using System;
using System.Collections;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }

        public DateTime Date {  get; set; }

        public string OrderId { get; set; }

        public int TotalAmount { get; set; }

        public string StaffId { get; set; }

        public int CustomerId { get; set; }

        public int Quantity { get; set; }

        public int StockId { get; set; }
        public bool PaymentSuccessful { get; set; }
    }
}