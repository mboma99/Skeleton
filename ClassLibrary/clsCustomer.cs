using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerDetails { get; set; }
        public double AccountBalance { get; set; }
        public bool PendingOrder { get; set; }
        
    }
}