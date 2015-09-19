using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest
{
    public class TradeModelA : ITradeModel
    {
        public event EventHandler TradeAdded;
        List<TradeObject> Trades = new List<TradeObject>();

        public void AddTrade(TradeObject TO) 
        { 
            Trades.Add(TO);
            onTradeAdded(TO);
        }

        public List<TradeObject> GetTrades() { return Trades; }

        public void onTradeAdded(TradeObject TO)
        {
            if (TradeAdded != null)
            {
                TradeAdded(this, TO);
            }
        }


        
    }
}
