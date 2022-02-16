using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int OrderID { get; set; }
        public int PetID { get; set; }
        public int Quantity { get; set; }
        public double PricePaid { get; set; }
        public double PetPrice { get; set; }
    }
}