using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3._4
{
    public enum TeaType
    {
        Black,
        Green,
        Matcha
    }
    internal class TeaOrder : BeverageOrder
    {
        public bool lemon { get; set; } = false;
        public bool honey { get; set; } = false;

        public TeaType teaType { get; set; }
    }
}
