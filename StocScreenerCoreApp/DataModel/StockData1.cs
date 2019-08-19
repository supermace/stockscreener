using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StocScreenerCoreApp.DataModel
{
    public class StockData1
    {

        public class Rootobject
        {
            public Maxpriceearningsratio maxPriceEarningsRatio { get; set; }
            public Minpriceearningsratio minPriceEarningsRatio { get; set; }
            public float midPriceEarningsRatio { get; set; }
            public Latestpriceearningsratio latestPriceEarningsRatio { get; set; }
            public Currentpriceearningsratio currentPriceEarningsRatio { get; set; }
            public Earningspricepercentage[] earningsPricePercentages { get; set; }
            public int latestPriceToBookRatio { get; set; }
            public int latestEvEbit { get; set; }
            public int dividendYield { get; set; }
            public Dividendyield[] dividendYields { get; set; }
            public float latestEarningsPerShare { get; set; }
            public float latestBookValuePerShare { get; set; }
            public float latestDividendPerShare { get; set; }
            public Valuationreport[] valuationReports { get; set; }
        }

        public class Maxpriceearningsratio
        {
            public int year { get; set; }
            public int month { get; set; }
            public int period { get; set; }
            public string interimName { get; set; }
            public float value { get; set; }
        }

        public class Minpriceearningsratio
        {
            public int year { get; set; }
            public int month { get; set; }
            public int period { get; set; }
            public string interimName { get; set; }
            public float value { get; set; }
        }

        public class Latestpriceearningsratio
        {
            public int year { get; set; }
            public int month { get; set; }
            public int period { get; set; }
            public string interimName { get; set; }
            public float value { get; set; }
        }

        public class Currentpriceearningsratio
        {
            public DateTime dateTime { get; set; }
            public int value { get; set; }
        }

        public class Earningspricepercentage
        {
            public int year { get; set; }
            public int month { get; set; }
            public int period { get; set; }
            public string interimName { get; set; }
            public float value { get; set; }
        }

        public class Dividendyield
        {
            public int year { get; set; }
            public DateTime date { get; set; }
            public float dividend { get; set; }
            public string tradeCurrency { get; set; }
            public float dividendYieldPercentage { get; set; }
        }

        public class Valuationreport
        {
            public int year { get; set; }
            public int month { get; set; }
            public int period { get; set; }
            public string interimName { get; set; }
            public float priceEarningsRatio { get; set; }
            public float earningsPricePercentage { get; set; }
            public float priceToBookRatio { get; set; }
            public float dividendYieldPercentage { get; set; }
            public float earningsPerShare { get; set; }
            public float bookValuePerShare { get; set; }
            public float dividendPerShare { get; set; }
        }

    }
}
