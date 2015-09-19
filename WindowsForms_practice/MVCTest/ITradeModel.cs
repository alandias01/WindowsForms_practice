using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsForms_practice.MVCTest
{

    public interface ITradeModel
    {
        event EventHandler TradeAdded;
        void AddTrade(TradeObject TO);
        List<TradeObject> GetTrades();
    }
}
