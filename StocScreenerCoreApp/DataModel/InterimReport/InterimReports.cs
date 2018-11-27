using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StocScreenerCoreApp.DataModel.InterimReports
{
        public class Rootobject
        {
            public Data data { get; set; }
            public Meta meta { get; set; }
        }

        public class Data
        {
            public string symbol { get; set; }
            public long sales12M { get; set; }
            public decimal changeInSales12M { get; set; }
            public decimal adjustedReturnOnEquity12M { get; set; }
            public decimal earningsPerShare12M { get; set; }
            public decimal adjustedNetIncomeRate12M { get; set; }
            public Interimreport[] interimReports { get; set; }
        }

        public class Interimreport
        {
            public decimal adjustedNetIncome { get; set; }
            public decimal adjustedNetIncomeAfterMinorityInterest { get; set; }
            public decimal adjustedOperatingMargin { get; set; }
            public decimal adjustedReturnOnEquity { get; set; }
            public long balanceSheetTotal { get; set; }
            public Int64 cashFlowOfBusiness { get; set; }
            public decimal changeInNetSales { get; set; }
            public decimal ebit { get; set; }
            public decimal equityRatio { get; set; }
            public long financialExpenses { get; set; }
            public decimal gearingRatio { get; set; }
            public long immediateTaxes { get; set; }
            public long interestBearingLiabilities { get; set; }
            public string interimName { get; set; }
            public decimal liquidAssets { get; set; }
            public int month { get; set; }
            public decimal netIncome { get; set; }
            public decimal netInterestBearingLiabilities { get; set; }
            public Int64 numberOfShares { get; set; }
            public decimal operatingMargin { get; set; }
            public long ownCapital { get; set; }
            public int period { get; set; }
            public long profitAfterFinancialItems { get; set; }
            public decimal returnOnEquity { get; set; }
            public decimal returnOnInvestment { get; set; }
            public long sales { get; set; }
            public int year { get; set; }
        }

        public class Meta
        {
        }

}
