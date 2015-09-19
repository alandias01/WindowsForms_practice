using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest
{
    public class TradeObject : EventArgs
    {
        public string Cusip { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }


        public TradeObject() { }

        public TradeObject(string Cusip,string Quantity,double Price)
        {
            this.Cusip = Cusip;
            this.Quantity = Quantity;
            this.Price = Price;
        }

    }
}
