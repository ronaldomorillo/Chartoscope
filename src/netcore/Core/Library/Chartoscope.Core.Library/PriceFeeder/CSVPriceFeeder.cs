﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chartoscope.Core
{
    public class CSVPriceFeeder : PriceFeeder
    {
        public CSVPriceFeeder(MarketFeedProvider feedProvider) : base(feedProvider)
        {
        }
    }
}
