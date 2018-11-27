﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using StocScreenerCoreApp.DataModel;
using StocScreenerCoreApp.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StocScreenerCoreApp.Pages
{
    public class IndexModel : PageModel
    {

        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Stock> Stocks { get; private set; }

        public string NameSort { get; set; }
        public string TickerSort { get; set; }
        public string PriceSort { get; set; }
        public string PriceToBookSort { get; set; }
        public string PriceToEarningsSort { get; set; }
        public string ROESort { get; set; }
        public string ROEDividedPriceToBookSort { get; set; }
        public string DividendSort { get; set; }
        public string EarningsPerYearSort { get; set; }
        public string EarningsProjectedNextPeriodSort { get; set; }
        public string StockPriceProjectedSort { get; set; }
        public string PriceVsProjectedSort { get; set; }
        public string GrahamValueSort { get; set; }
        public string RankPriceToBookSort { get; set; }
        public string RankPriceToEarningsSort { get; set; }
        public string RankDividendSort { get; set; }
        public string RankTotalSort { get; set; }

        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
    {
         if (_db.Stocks == null || _db.Stocks.Count() == 0)
            {
                InitializeStocksToDb();
    }
            IQueryable<Stock> stockOrderedList = from s in _db.Stocks
                                                select s;
            /*
               <td>@stock.Ticker</td>
                    <td>@stock.Price</td>
                    <td>@stock.PriceToBook</td>
                    <td>@stock.PriceToEarnings</td>
                    <td>@stock.ROE</td>
                    <td>@stock.ROEDividedPriceToBook</td>
                    <td>@stock.Dividend</td>
                    <td>@stock.EarningsPerYear</td>
                    <td>@stock.EarningsProjectedNextPeriod</td>
                    <td>@stock.StockPriceProjected</td>
                    <td>@stock.PriceVsProjected</td>
                    <td>@stock.GrahamValue</td>
                    <td>@stock.RankPriceToBook</td>
                    <td>@stock.RankPriceToEarnings</td>

                    <td>@stock.RankDividend</td>
                    <td>@stock.RankTotal</td>
             
             */
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            TickerSort = sortOrder == "Ticker" ? "Ticker_desc" : "Ticker";
            PriceSort = sortOrder == "Price" ? "Price_desc" : "Price";
            PriceToBookSort = sortOrder == "PriceToBook" ? "PriceToBook_desc" : "PriceToBook";
            PriceToEarningsSort = sortOrder == "PriceToEarnings" ? "PriceToEarnings_desc" : "PriceToEarnings";
            ROESort = sortOrder == "ROE" ? "ROE_desc" : "ROE";
            ROEDividedPriceToBookSort = sortOrder == "ROEDividedPriceToBook" ? "ROEDividedPriceToBook_desc" : "ROEDividedPriceToBook";
            DividendSort = sortOrder == "Dividend" ? "Dividend_desc" : "Dividend";
            EarningsPerYearSort = sortOrder == "EarningsPerYear" ? "EarningsPerYear_desc" : "EarningsPerYear";
            EarningsProjectedNextPeriodSort = sortOrder == "EarningsProjectedNextPeriod" ? "EarningsProjectedNextPeriod_desc" : "EarningsProjectedNextPeriod";
            StockPriceProjectedSort = sortOrder == "StockPriceProjected" ? "StockPriceProjected_desc" : "StockPriceProjected";
            PriceVsProjectedSort = sortOrder == "PriceVsProjected" ? "PriceVsProjected_desc" : "PriceVsProjected";
            GrahamValueSort = sortOrder == "GrahamValue" ? "GrahamValue_desc" : "GrahamValue";
            RankPriceToBookSort = sortOrder == "RankPriceToBook" ? "RankPriceToBook_desc" : "RankPriceToBook";
            RankPriceToEarningsSort = sortOrder == "RankPriceToEarnings" ? "RankPriceToEarnings_desc" : "RankPriceToEarnings";
            RankDividendSort = sortOrder == "RankDividend" ? "RankDividend_desc" : "RankDividend";
            RankTotalSort = sortOrder == "RankTotal" ? "RankTotal_desc" : "RankTotal";


            switch (sortOrder)
            {
                case "name_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.Name);
                    break;
                case "Ticker":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.Ticker);
                    break;
                case "Ticker_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.Ticker);
                    break;

                case "Price":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.Price);
                    break;
                case "Price_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.Price);
                    break;

                case "PriceToBook":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.PriceToBook);
                    break;
                case "PriceToBook_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.PriceToBook);
                    break;

                case "PriceToEarnings":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.PriceToEarnings);
                    break;
                case "PriceToEarnings_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.PriceToEarnings);
                    break;

                case "ROE":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.ROE);
                    break;
                case "ROE_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.ROE);
                    break;

                case "ROEDividedPriceToBook":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.ROEDividedPriceToBook);
                    break;
                case "ROEDividedPriceToBook_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.ROEDividedPriceToBook);
                    break;

                case "Dividend":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.Dividend);
                    break;
                case "Dividend_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.Dividend);
                    break;

                case "EarningsPerYear":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.EarningsPerYear);
                    break;
                case "EarningsPerYear_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.EarningsPerYear);
                    break;

                case "EarningsProjectedNextPeriod":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.EarningsProjectedNextPeriod);
                    break;
                case "EarningsProjectedNextPeriod_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.EarningsProjectedNextPeriod);
                    break;

                case "StockPriceProjected":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.StockPriceProjected);
                    break;
                case "StockPriceProjectedd_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.StockPriceProjected);
                    break;

                case "PriceVsProjected":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.PriceVsProjected);
                    break;
                case "PriceVsProjected_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.PriceVsProjected);
                    break;

                case "GrahamValue":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.GrahamValue);
                    break;
                case "GrahamValue_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.GrahamValue);
                    break;

                case "RankPriceToBook":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.RankPriceToBook);
                    break;
                case "RankPriceToBook_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.RankPriceToBook);
                    break;

                case "RankPriceToEarnings":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.RankPriceToEarnings);
                    break;
                case "RankPriceToEarnings_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.RankPriceToEarnings);
                    break;

                case "RankDividend":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.RankDividend);
                    break;
                case "RankDividend_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.RankDividend);
                    break;

                case "RankTotal":
                    stockOrderedList = stockOrderedList.OrderBy(s => s.RankTotal);
                    break;
                case "Ranktotal_desc":
                    stockOrderedList = stockOrderedList.OrderByDescending(s => s.RankTotal);
                    break;

                default:
                    stockOrderedList = stockOrderedList.OrderBy(s => s.Name);
                    break;
            }

            Stocks = await stockOrderedList.AsNoTracking().ToListAsync();
    }

    //public void OnGet()
    //    {
    //        if (_db.Stocks == null || _db.Stocks.Count() == 0)
    //        {
    //            InitializeStocksToDb();
    //        }

    //        Stocks = _db.Stocks.AsNoTracking().ToList();

    //    }

        private void InitializeStocksToDb()
        {
            var stockTicekrs = new string[] { "NDA FI",
                //"OUT1V", "NDA FI", "VINCIT", "CTH1V", "FORTUM", "ORNBV", "SAMPO",
"AM1",
"KEMIRA",
"METSA",
"METSB",
"OUT1V",
"SSABAH",
"SSABBH",
"STEAV",
"STERV",
"UPM",
"AMEAS",
"FSKRS",
"NRE1V",
"FIA1S",
"KESKOA",
"KESKOB",
"SAA1V",
"CTY1S",
"KOJAMO",
"NDA1V",
"SAMPO",
"ORNAV",
"ORNBV",
"TTALO",
"CGCBV",
"HUH1V",
"KNEBV",
"KCR",
"METSO",
"UPONOR",
"VALMT",
"WRT1V",
"YIT",
"NESTE",
"NOKIA",
"TIETO",
"DNA",
"ELISA",
"TELIA1",
"FORTUM",
"ALTIA",
"ATRAV",
"HKSAV",
"OLVAS",
"RAIVV",
"RAP1V",
"ROVIO",
"SUY1V",
"ALMA",
"KAMUX",
"STCAS",
"STCBV",
"TOKMAN",
"VIK1V",
"AKTIA",
"ATG1V",
"CAPMAN",
"EQV1V",
"EVLI",
"HOIVA",
"TAALA",
"TPS1V",
"ALBAV",
"ALBBV",
"OKDAV",
"OKDBV",
"PIHLIS",
"REG1V",
"ASPO",
"CAV1V",
"CRA1V",
"LAT1V",
"LEHTO",
"RAMI",
"OTE1V",
"PON1V",
"POY1V",
"RMR1V",
"ROBIT",
"SCANFL",
"SRV1V",
"TIK1V",
"VAIAS",
"BAS1V",
"BITTI",
"FSC1V",
"TLT1V",
"AFAGR",
"ENDOM",
"SOSI1",
"APETIT",
"HARVIA",
"HONBS",
"MMO1V",
"MARAS",
"SAGCV",
"ILK2S",
"KSLAV",
"PIZZA",
"PKK1V",
"RESTA",
"INVEST",
"OREIT",
"PNA1V",
"SIEVI",
"BIOBV",
"SILMA",
"ACG1V",
"CTH1V",
"CONSTI",
"DOV1V",
"EFO1V",
"ELEAV",
"ETTE",
"EXL1V",
"GLA1V",
"ICP1V",
"KELAS",
"NEO1V",
"NLG1V",
"UUTEC",
"RAUTE",
"TNOM",
"TULAV",
"VALOE",
"WUF1V",
"YLEPS",
"DIGIA",
"DIGIGR",
"IFA1V",
"NIXU",
"QPR1V",
"QTCOM",
"SIILI",
"SOLTEQ",
"SOPRA",
"SSH1V",
"TEM1V",
"TRH1V",
"NXTGMS",
"REMEDY",
"AVIDLY",
"VERK",
"EABGB",
"PRIVA",
"TITAN",
"UNIAV",
"BONEH",
"FITBIO",
"HRTIS",
"NXTMH",
"AHOLA",
"DETEC",
"ESENSE",
"FONDIA",
"LOUD",
"PIIPPO",
"VMP",
"SAVOH",
"ADMCM",
"EFECTE",
"GOFORE",
"HEEROS",
"VINCIT"

            };

            foreach (var item in stockTicekrs)
            {
                var stock = new Stock();
                var stockInfo = StockValue(item).Result;
                var stockData = Stock(item).Result;
                if (stockData == null)
                {
                    continue;
                }
                bool isQuarterReport = stockData.valuationReports.Count > 0 ? stockData.valuationReports[0].interimName.Contains('Q') : false;
                stock.Name = stockInfo.Name;
                stock.Ticker = item;
                stock.Price = stockInfo.Value;
                stock.PriceToBook = stockData.latestPriceToBookRatio;
                stock.PriceToEarnings = stockData.currentPriceEarningsRatio != null ? Math.Round(stockData.currentPriceEarningsRatio.value, 2) : 0;
                stock.EarningsPerYear = isQuarterReport ? CalculateQuarters(stockData.valuationReports) : CalculateHalfYear(stockData.valuationReports);
                stock.EarningsProjectedNextPeriod = stock.PriceToEarnings != 0 ? Math.Round((stockInfo.Value / stock.PriceToEarnings) - (isQuarterReport ? CalculateQuarters(stockData.valuationReports, true) : CalculateHalfYear(stockData.valuationReports, true)), 2) : 0;
                stock.StockPriceProjected = Math.Round(stock.PriceToEarnings * stock.EarningsPerYear, 2);
                //stock.PriceVsProjected = 0; stock.StockPriceProjected != 0 ? Math.Round((stock.Price / stock.StockPriceProjected) * 100,2) : 0;
                stock.Dividend = stockData.valuationReports.Count > 0 && stockData.valuationReports[0].dividendYieldPercentage > 0 ? Math.Round(stockData.valuationReports[0].dividendYieldPercentage, 2) : 0;

                if (stock.StockPriceProjected != 0 && stock.Price > 0)
                {
                    stock.PriceVsProjected = Math.Round(((stock.StockPriceProjected - stock.Price) / stock.Price) * 100, 2);
                }
                stock.GrahamValue = Math.Round(stock.PriceToBook * stock.PriceToEarnings, 2);

                var stockInterim = InterimReport(item).Result;
                if (stock != null)
                {
                    stock.ROE = Math.Round(stockInterim.adjustedReturnOnEquity12M, 2);
                    stock.ROEDividedPriceToBook = stock.PriceToBook > 0 ? Math.Round(stock.ROE / stock.PriceToBook, 2) : 0;
                }



                _db.Stocks.Add(stock);



            }
                                
            _db.SaveChangesAsync();

            CalculateDividendRank(_db.Stocks);
            CalculatePERank(_db.Stocks);
            CalculatePBRank(_db.Stocks);

            _db.SaveChangesAsync();

            RedirectToPage("/Index");
        }

        private void CalculateDividendRank(DbSet<Stock> stocks)
        {
            var stocksOrderByDividend = from s in stocks
                                        orderby s.Dividend descending
                                        select s;

            int rank = 1;
            foreach (var item in stocksOrderByDividend.ToList())
            {
                item.RankDividend = rank;
                rank++;
            }
        }

        private void CalculatePERank(DbSet<Stock> stocks)
        {
            var stocksOrderByPe = from s in stocks
                                  orderby s.PriceToEarnings ascending
                                  select s;

            int rank = 1;
            List<Stock> failureStocks = new List<Stock>();
            foreach (var item in stocksOrderByPe.ToList())
            {
                if (item.PriceToEarnings > 0)
                {
                    item.RankPriceToEarnings = rank;
                    rank++;
                }
                else
                {
                    failureStocks.Add(item);
                }
            }

            foreach (var item in failureStocks)
            {
                item.RankPriceToEarnings = rank;
                rank++;
            }

        }

        private void CalculatePBRank(DbSet<Stock> stocks)
        {
            var stocksOrderByPb = from s in stocks
                                  orderby s.PriceToBook ascending
                                  select s;
            List<Stock> failureStocks = new List<Stock>();
            int rank = 1;
            foreach (var item in stocksOrderByPb.ToList())
            {
                if (item.PriceToBook > 0)
                {
                    item.RankPriceToBook = rank;
                    rank++;
                }

                else
                {
                    failureStocks.Add(item);
                }                
            }

            foreach (var item in failureStocks)
            {
                item.RankPriceToBook = rank;
                rank++;
            }

            foreach (var item in stocks)
            {
                item.RankTotal = item.RankDividend + item.RankPriceToBook + item.RankPriceToEarnings;
            }
        }

        private decimal CalculateHalfYear(List<ValuationReport> valuationReports, bool excludeOnePeriod = false)
        {
            if (valuationReports == null)
            {
                return 0;
            }
            int exclude = excludeOnePeriod ? -1 : 0;
            int periods = 2 + exclude;
            return valuationReports.Take(periods).Sum(x => x.earningsPerShare);
        }

        private decimal CalculateQuarters(List<ValuationReport> valuationReports, bool excludeOndePeriod = false)
        {
            if (valuationReports == null)
            {
                return 0;
            }
            int exclude = excludeOndePeriod ? -1 : 0;
            int periods = 4 + exclude;
            return valuationReports.Take(4).Sum(x => x.earningsPerShare);
        }

        //public async Task<IActionResult> Stock(string stockTicker)
        public async Task<DataModel.Data> Stock(string stockTicker)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://beta.kauppalehti.fi");
                    var response = await client.GetAsync($"/backend/stock;cache=false;endpoint=balance/valuation/{stockTicker}/5?returnMeta=true");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawStockData = JsonConvert.DeserializeObject<RootObject>(stringResult);
                    return rawStockData.data; // { new { Price = rawStockData.data. } };
                    //return rawStockData.data;
                }
                catch (HttpRequestException httpRequestException)
                {
                    return null; // BadRequest($"Error getting stockdata from kauppalehti: {httpRequestException.Message}");
                }
            }
        }

        //public async Task<IActionResult> Stock(string stockTicker)
        public async Task<DataModel.InterimReports.Data> InterimReport(string stockTicker)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://beta.kauppalehti.fi");
                    https://beta.kauppalehti.fi%2FOUT1V%2F5?returnMeta=true
                    var response = await client.GetAsync($"/backend/stock;cache=false;endpoint=balance/interimreports/{stockTicker}/5?returnMeta=true");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    var rawStockData = JsonConvert.DeserializeObject<StocScreenerCoreApp.DataModel.InterimReports.Rootobject>(stringResult);
                    return rawStockData.data; // { new { Price = rawStockData.data. } };
                    //return rawStockData.data;
                }
                catch (HttpRequestException httpRequestException)
                {
                    return null; // BadRequest($"Error getting stockdata from kauppalehti: {httpRequestException.Message}");
                }
            }
        }

        public async Task<StockInfo> StockValue(string stockTicker)
        {
            using (var client = new HttpClient())
            {
                var stockInfo = new StockInfo() { Value = 0, Name = stockTicker };
                try
                {
                    client.BaseAddress = new Uri("https://beta.kauppalehti.fi");
                    var response = await client.GetAsync($"/porssi/porssikurssit/osake/{stockTicker}");
                    response.EnsureSuccessStatusCode();

                    var encoding = ASCIIEncoding.ASCII;
                    var stringResult = await response.Content.ReadAsStringAsync();

                    var lastPriceIndex = stringResult.IndexOf("lastPrice");
                    var lastPrice = stringResult.Substring(lastPriceIndex + 11, 5);
                    if (string.IsNullOrEmpty(lastPrice) || lastPriceIndex == -1)
                    {
                        return stockInfo;
                    }
                    lastPrice = lastPrice.Split(',')[0];
                    decimal value;
                    if (decimal.TryParse(lastPrice.Replace("\"", ""), out value))
                    {
                        stockInfo.Value = value;
                    }
                    else
                    {
                        stockInfo.Value = decimal.Parse(lastPrice.Replace("\"", "").Replace(".", ","));
                    }

                    // <title>Outokumpu |
                    var name = stringResult.Substring(stringResult.IndexOf("<title>") + 7, 25);
                    name = name.Split('|')[0];
                    stockInfo.Name = name;
                    return stockInfo;

                }
                catch (HttpRequestException httpRequestException)
                {
                    return stockInfo;
                }
            }


        }

        // GET: Stocks/Refresh/
        public async Task<IActionResult> Refresh()
        {
            _db.Stocks.RemoveRange(_db.Stocks.ToArray());
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }

        public class StockInfo
        {
            public string Name { get; set; }
            public Decimal Value { get; set; }
        }
    }
}