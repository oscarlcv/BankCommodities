using System.Collections.Generic;
using BankCommoditiesModels;

namespace BankCommoditiesControllers
{
    public class TransactionsController
    {
        private const string transactionURL = "http://quiet-stone-2094.herokuapp.com/transactions.json";

        /// <summary>
        /// Método que devuelve el listado de todas las transacciones.
        /// </summary>
        /// <returns></returns>
        public static List<Transaction> GetTransactions(string transactionBackUpPath)
        {
            return CommonController.GetListFromURL<Transaction>(transactionURL, transactionBackUpPath);
        }
    }
}
