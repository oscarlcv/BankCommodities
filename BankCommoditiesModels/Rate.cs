using System;
using System.Collections.Generic;
using System.Text;
using BankCommoditiesTools;

namespace BankCommoditiesModels
{
    public class Rate
    {
        public Rate(string from, string to, decimal value)
        {
            From = from;
            To = to;
            Value = value.Bank();
        }

        public string From { get; set; }
        public string To { get; set; }
        public decimal Value { get; set; }
        public decimal Inverse => (1 / Value).Bank();
    }
}
