using System;
using System.Collections.Generic;
using System.Text;

namespace BankCommoditiesModels
{
    public class Transaction
    {
        public string Sku { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
