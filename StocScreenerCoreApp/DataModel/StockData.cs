using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StocScreenerCoreApp.DataModel
{
    // {"data":{"marketValue":2184990000,"maxPriceEarningsRatio":{"year":2016,"month":10,"period":3,"interimName":"Q4/16","value":38.913},"minPriceEarningsRatio":{"year":2017,"month":4,"period":3,"interimName":"Q2/17","value":6.453},"midPriceEarningsRatio":16.5,"latestPriceEarningsRatio":{"year":2018,"month":4,"period":3,"interimName":"Q2/18","value":13.339},"currentPriceEarningsRatio":{"dateTime":"2018-09-26T09:44:17Z","value":12.663452868571428},"currentEarningsPricePercentage":{"dateTime":"2018-09-26T09:44:17Z","value":7.896740410207021},"earningsPricePercentages":[{"year":2018,"month":4,"period":3,"interimName":"Q2/18","value":7.49},{"year":2018,"month":1,"period":3,"interimName":"Q1/18","value":10.51},{"year":2017,"month":10,"period":3,"interimName":"Q4/17","value":11.53},{"year":2017,"month":7,"period":3,"interimName":"Q3/17","value":11.23},{"year":2017,"month":4,"period":3,"interimName":"Q2/17","value":15.49},{"year":2017,"month":1,"period":3,"interimName":"Q1/17","value":8.38},{"year":2016,"month":10,"period":3,"interimName":"Q4/16","value":2.56},{"year":2016,"month":7,"period":3,"interimName":"Q3/16","value":-1.95},{"year":2016,"month":4,"period":3,"interimName":"Q2/16","value":-10.22},{"year":2016,"month":1,"period":3,"interimName":"Q1/16","value":-13.34},{"year":2015,"month":10,"period":3,"interimName":"Q4/15","value":-14.47},{"year":2015,"month":7,"period":3,"interimName":"Q3/15","value":-25.65},{"year":2015,"month":4,"period":3,"interimName":"Q2/15","value":-9.61},{"year":2015,"month":1,"period":3,"interimName":"Q1/15","value":-5.28},{"year":2014,"month":10,"period":3,"interimName":"Q4/14","value":-13.17},{"year":2014,"month":7,"period":3,"interimName":"Q3/14","value":-18.01},{"year":2014,"month":4,"period":3,"interimName":"Q2/14","value":-17.84},{"year":2014,"month":1,"period":3,"interimName":"Q1/14","value":-34.76},{"year":2013,"month":10,"period":3,"interimName":"Q4/13","value":-82.31},{"year":2013,"month":7,"period":3,"interimName":"Q3/13","value":-76.11},{"year":2013,"month":4,"period":3,"interimName":"Q2/13","value":-68.6}],"latestPriceToBookRatio":0.813,"latestEvEbit":16.89,"dividendYields":[{"year":2018,"date":"2018-03-23T00:00:00Z","dividend":0.25,"tradeCurrency":"EUR","dividendYieldPercentage":3.951944356623459},{"year":2017,"date":"2017-03-22T00:00:00Z","dividend":0.1,"tradeCurrency":"EUR","dividendYieldPercentage":1.0672358591248667},{"year":2016,"date":"2016-04-07T00:00:00Z","dividend":0,"tradeCurrency":"EUR","dividendYieldPercentage":0},{"year":2015,"date":"2015-04-09T00:00:00Z","dividend":0,"tradeCurrency":"EUR","dividendYieldPercentage":0},{"year":2014,"date":"2014-04-15T00:00:00Z","dividend":0,"tradeCurrency":"EUR","dividendYieldPercentage":0}],"latestEarningsPerShare":0.06,"latestBookValuePerShare":6.55,"latestDividendPerShare":0.0625,"valuationReports":[{"year":2018,"month":4,"period":3,"interimName":"Q2/18","marketValue":2184990000,"priceEarningsRatio":13.339,"earningsPricePercentage":7.49,"priceToBookRatio":0.813,"evEbit":16.89,"dividendYieldPercentage":4.69,"earningsPerShare":0.06,"bookValuePerShare":6.55,"dividendPerShare":0.0625},{"year":2018,"month":1,"period":3,"interimName":"Q1/18","marketValue":2288560000,"priceEarningsRatio":9.511,"earningsPricePercentage":10.51,"priceToBookRatio":0.861,"evEbit":12.97,"dividendYieldPercentage":4.51,"earningsPerShare":0.12,"bookValuePerShare":6.43,"dividendPerShare":0.0625},{"year":2017,"month":10,"period":3,"interimName":"Q4/17","marketValue":3190410000,"priceEarningsRatio":8.669,"earningsPricePercentage":11.53,"priceToBookRatio":1.172,"evEbit":10.31,"dividendYieldPercentage":3.22,"earningsPerShare":0.31,"bookValuePerShare":6.59,"dividendPerShare":0.0625},{"year":2017,"month":7,"period":3,"interimName":"Q3/17","marketValue":3623210000,"priceEarningsRatio":8.897,"earningsPricePercentage":11.23,"priceToBookRatio":1.424,"evEbit":11.23,"dividendYieldPercentage":2.41,"earningsPerShare":-0.07,"bookValuePerShare":6.17,"dividendPerShare":0.0625},{"year":2017,"month":4,"period":3,"interimName":"Q2/17","marketValue":2881030000,"priceEarningsRatio":6.453,"earningsPricePercentage":15.49,"priceToBookRatio":1.124,"evEbit":9.09,"dividendYieldPercentage":2.5,"earningsPerShare":0.26,"bookValuePerShare":6.21,"dividendPerShare":0.0625}]},"meta":{}}
    public class MaxPriceEarningsRatio
    {
        public int year { get; set; }
        public int month { get; set; }
        public int period { get; set; }
        public string interimName { get; set; }
        public decimal value { get; set; }
    }

    public class MinPriceEarningsRatio
    {
        public int year { get; set; }
        public int month { get; set; }
        public int period { get; set; }
        public string interimName { get; set; }
        public decimal value { get; set; }
    }

    public class LatestPriceEarningsRatio
    {
        public int year { get; set; }
        public int month { get; set; }
        public int period { get; set; }
        public string interimName { get; set; }
        public decimal value { get; set; }
    }

    public class CurrentPriceEarningsRatio
    {
        public DateTime dateTime { get; set; }
        public decimal value { get; set; }
    }

    public class CurrentEarningsPricePercentage
    {
        public DateTime dateTime { get; set; }
        public decimal value { get; set; }
    }

    public class EarningsPricePercentage
    {
        public int year { get; set; }
        public int month { get; set; }
        public int period { get; set; }
        public string interimName { get; set; }
        public decimal value { get; set; }
    }

    public class DividendYield
    {
        public int year { get; set; }
        public DateTime date { get; set; }
        public decimal dividend { get; set; }
        public string tradeCurrency { get; set; }
        public decimal dividendYieldPercentage { get; set; }
    }

    public class ValuationReport
    {
        public int year { get; set; }
        public int month { get; set; }
        public int period { get; set; }
        public string interimName { get; set; }
        public object marketValue { get; set; }
        public decimal priceEarningsRatio { get; set; }
        public decimal earningsPricePercentage { get; set; }
        public decimal priceToBookRatio { get; set; }
        public decimal evEbit { get; set; }
        public decimal dividendYieldPercentage { get; set; }
        public decimal earningsPerShare { get; set; }
        public decimal bookValuePerShare { get; set; }
        public decimal dividendPerShare { get; set; }
    }

    public class RootObject
    {
    //    public class Data
    //{
        public long marketValue { get; set; }
        public MaxPriceEarningsRatio maxPriceEarningsRatio { get; set; }
        public MinPriceEarningsRatio minPriceEarningsRatio { get; set; }
        public decimal midPriceEarningsRatio { get; set; }
        public LatestPriceEarningsRatio latestPriceEarningsRatio { get; set; }
        public CurrentPriceEarningsRatio currentPriceEarningsRatio { get; set; }
        public CurrentEarningsPricePercentage currentEarningsPricePercentage { get; set; }
        public List<EarningsPricePercentage> earningsPricePercentages { get; set; }
        public decimal latestPriceToBookRatio { get; set; }
        public decimal latestEvEbit { get; set; }
        public List<DividendYield> dividendYields { get; set; }
        public decimal latestEarningsPerShare { get; set; }
        public decimal latestBookValuePerShare { get; set; }
        public decimal latestDividendPerShare { get; set; }
        public List<ValuationReport> valuationReports { get; set; }
    }

    //public class Meta
    //{
    //}

  
        //public Data data { get; set; }
    //}
}
