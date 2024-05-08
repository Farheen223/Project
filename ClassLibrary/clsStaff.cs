using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public string Hours { get; set; }
    }
}