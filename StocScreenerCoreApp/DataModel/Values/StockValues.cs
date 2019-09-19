using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StocScreenerCoreApp.DataModel.Values
{

        public class Rootobject
        {
            public string dateTime { get; set; }
            public int insRef { get; set; }
            public string symbol { get; set; }
            public Share[] shares { get; set; }
            public Sector[] sectors { get; set; }
        }

        public class Share
        {
            public int insRef { get; set; }
            public int company { get; set; }
            public string name { get; set; }
            public string symbol { get; set; }
            public string isin { get; set; }
            public string tradeCurrency { get; set; }
            public float lastPrice { get; set; }
            public float turnover { get; set; }
            public int quantity { get; set; }
            public float internalTurnover { get; set; }
            public int internalQuantity { get; set; }
            public float offbookTurnover { get; set; }
            public int offbookQuantity { get; set; }
            public DateTime dateTime { get; set; }
            public float openPrice { get; set; }
            public float bidPrice { get; set; }
            public float askPrice { get; set; }
            public float dayLowPrice { get; set; }
            public float dayHighPrice { get; set; }
            public float closePrice { get; set; }
            public DateTime closeDateTime { get; set; }
            public float changePercent { get; set; }
            public float changePercent1m { get; set; }
            public int tickSize { get; set; }
            public int sectorindex { get; set; }
            public int marketCapCategory { get; set; }
            public Quoteshare[] quoteShares { get; set; }
            public float marketValue { get; set; }
            public float darkTurnover { get; set; }
            public int darkQuantity { get; set; }
        }

        public class Quoteshare
        {
            public int insRef { get; set; }
            public int company { get; set; }
            public float closePrice { get; set; }
            public long numberOfShares { get; set; }
            public long totalCompanyShares { get; set; }
        }

        public class Sector
        {
            public int insref { get; set; }
            public string name { get; set; }
            public float diffprc { get; set; }
            public float price { get; set; }
            public DateTime dateTime { get; set; }
            public int count { get; set; }
        }

}
