﻿using Imperatur_v2.securites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperatur_v2.trade.analysis
{
    public interface ISecurityAnalysis
    {
        decimal StandardDeviationForRange(DateTime Start, DateTime End);
        decimal StandardDeviation { get; }
        decimal ChangeSince(DateTime From);
        bool RangeConvergeWithElliotForBuy(int IntervalInDays, out TradingRecommendation TradingRecommendation);
        bool RangeConvergeWithElliotForSell(int IntervalInDays);
        bool HasValue { get; }
        List<double> MovingAverageForRange(DateTime Start, DateTime End);
        List<List<double>> BollingerForRange(DateTime Start, DateTime End);
        List<HistoricalQuoteDetails> GetDataForRange(DateTime Start, DateTime End);
        List<Tuple<DateTime, VolumeIndicator>> GetRangeOfVolumeIndicator(DateTime Start, DateTime End);

    }
}