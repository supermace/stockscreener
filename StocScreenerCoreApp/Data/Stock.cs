using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StocScreenerCoreApp.Data
{
    public class Stock
    {
        public int Id { get; set; }
        [Required, StringLength(10)]
        public string Ticker { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal PriceToBook { get; set; }
        [Required]
        public decimal PriceToEarnings { get; set; }

        [Required]
        public decimal ROE { get; set; }

        [Required]
        public decimal ROEDividedPriceToBook { get; set; }

        [Required]
        public decimal Dividend { get; set; }

        [Required]
        public decimal DividendPayoutRatio { get; set; }
        [Required]
        public decimal EarningsPerYear { get; set; }
        [Required]
        public decimal EarningsProjectedNextPeriod { get; set; }
        /// <summary>
        /// Years EPS * P/E
        /// </summary>
        [Required]
        public decimal StockPriceProjected { get; set; }
        
        [Required]
        public decimal PriceVsProjected { get; set; }
        /// <summary>
        /// P/E * P/B = If under 22,5 then its worth to buy
        /// </summary>
        [Required]
        public decimal GrahamValue { get; set; }

        public int RankPriceToBook { get; set; }
        public int RankPriceToEarnings { get; set; }
        public int RankDividend { get; set; }
        public int RankTotal { get; set; }

    }
}
