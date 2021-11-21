using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BankCommoditiesModels;
using RestSharp;
using Newtonsoft.Json;

namespace BankCommoditiesControllers
{
    public class TransactionController
    {
        private const string transactionURL = "http://quiet-stone-2094.herokuapp.com/transactions.json";

        private const string rateURL = "http://quiet-stone-2094.herokuapp.com/rates.json";

        /// <summary>
        /// Método que devuelve el listado de todas las transacciones.
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetTransactions()
        {
            return GetListFromURL<Transaction>(transactionURL);
        }

        /// <summary>
        /// Método que devuelve el listado de todas las conversiones de moneda.
        /// </summary>
        /// <returns></returns>
        public List<Rate> GetRates()
        {
            return GetListFromURL<Rate>(rateURL);
        }

        /// <summary>
        /// Método que devuelve un listado de objetos de un tipo específico.
        /// Para ello, accede a la URL pasada por parámetro y extrae la información allí contenida.
        /// Posteriormente mapea dicha información a un listado de objetos del tipo definido por entrada.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <returns></returns>
        private List<T> GetListFromURL<T>(string url)
        {
            List<T> tlist = null;

            RestClient client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string json = response.Content;
                try
                {
                    var model = JsonConvert.DeserializeObject<List<T>>(json);
                    if (model != null)
                    {
                        tlist = (List<T>)model;
                    }
                }
                catch
                {
                    throw;
                }
            }

            return tlist;
        }
    }
}
