using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest
{
    public class TradeControllerA : ITradeController
    {
        ITradeModel Model;
        public TradeControllerA(ITradeModel M) { this.Model = M; }
        

        public void AddTrade(TradeObject TO)
        {
            Model.AddTrade(TO);
        }

        public List<TradeObject> GetTrades() { return Model.GetTrades(); }
    }
}
