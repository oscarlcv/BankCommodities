using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BankCommoditiesModels;
using BankCommoditiesTools;

namespace BankCommoditiesControllers
{
    public class RatesController
    {
        private const string rateURL = "http://quiet-stone-2094.herokuapp.com/rates.json";

        /// <summary>
        /// Método que devuelve el listado de todas las conversiones de moneda.
        /// </summary>
        /// <param name="rateBackUpPath">Ruta donde guardar una copia de seguridad del fichero.</param>
        /// <returns></returns>
        public static List<Rate> GetRates(string rateBackUpPath)
        {
            return CommonController.GetListFromURL<Rate>(rateURL, rateBackUpPath);
        }

        /// <summary>
        /// Devuelve el valor de una moneda al cambio de otra.
        /// Para ello, descarga la lista de conversiones y busca la conversión concreta.
        /// Si no existe, busca la conversión intermedia y la genera a partir de esa.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static decimal GetCurrencieConversion(string from, string to, string rateBackUpPath)
        {
            List<Rate> rates = GetRates(rateBackUpPath);
            if (rates.Count > 0)
            {
                decimal currencieConversion = 0;
                Rate rate = rates.Find(r => r.From == from && r.To == to);
                if (rate != null)
                {
                    currencieConversion = rate.Value;
                }
                else
                {
                    //Find inverse Rate
                    rate = rates.Find(r => r.To == from && r.From == to);
                    if (rate != null)
                    {
                        currencieConversion = rate.Inverse;
                    }
                    else
                    {
                        //Find Halfway Rate
                        currencieConversion = GetConversionWithHalfwayRate(from, to, rates);
                    }
                }
                return currencieConversion;
            }
            else
                return 0;
        }

        private static decimal GetConversionWithHalfwayRate(string from, string to, List<Rate> rates)
        {
            decimal currencieConversion = 0;
            List<Rate> fromRates = rates.FindAll(r => r.From == from);
            if (fromRates.Count > 0)
            {
                List<Rate> toRates = rates.FindAll(r => r.To == to);
                bool exit = false;
                int index = 0;
                while (!exit)
                {
                    Rate toRate = toRates.Find(r => r.From == fromRates[index].To);
                    if (toRate != null)
                    {
                        exit = true;
                        currencieConversion = (fromRates[index].Value * toRate.Value).Bank();
                    }
                    else
                    {
                        index++;
                        exit = index >= fromRates.Count;
                    }
                }
            }

            return currencieConversion;
        }
    }
}
