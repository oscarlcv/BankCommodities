using System;

namespace BankCommoditiesTools
{
    public static class BankExtension
    {
        public static decimal Bank(this decimal value)
        {
            return Math.Round(value, 2);
        }
    }
}
