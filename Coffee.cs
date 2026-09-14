using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment3._4
{
    public enum CoffeeType
    {
        Expresso,
        Latte,
        Cappuccino,
        Americano,
        Mocha
    }
    public class CoffeeOrder : BeverageOrder
    {
        public bool milk { get; set; } = false;
        public bool sugar { get; set; } = false;
        public CoffeeType coffeeType{ get; set; }
        

    }
}
