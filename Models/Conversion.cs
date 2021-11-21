using System;

namespace BankCommoditiesWebService.Models
{
    public class Conversion
    {
        public string  From { get; set; }
        public string To { get; set; }
        public decimal Rate { get; set; }
        public decimal Inverse => Math.Round(1 / Rate, 2);
    }
}
