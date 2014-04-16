﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinExchange.Trades.Domain.Model.OrderMatchingEngine
{
    /// <summary>
    /// Listens to the changes in the depth of the Order Book
    /// </summary>
    public class DepthListener
    {
        // Get the Current Logger
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void OnDepthChanged(LimitOrderBook orderBook)
        {
            // ToDo: Need to process the Depths inside the OrderBook and create a snapshot either here of in the OrderBook
            Log.Debug("Depth changed for currency pair: " + orderBook.CurrencyPair);
        }
    }
}
