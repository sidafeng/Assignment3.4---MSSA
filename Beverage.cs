using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Assignment3._4
{
    public enum Beverage{

        Coffee,
        Tea

    }

    public enum Size
    {
        Small,
        Large
    }
    
    public abstract class BeverageOrder
    {
        public int orderID { get; set; }
        public string name {  get; set; }
        public string phoneNumber {  get; set; }
        public Beverage beverage { get; set; }
        public string beverageType { get; set; }
        public Size size { get; set; }
        public string addOn1 { get; set; } = "";
        public string addOn2 { get; set; } = "";
    }
}
