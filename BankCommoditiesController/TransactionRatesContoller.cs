using System;
using System.Collections.Generic;
using System.Text;
using BankCommoditiesModels;
using BankCommoditiesTools;

namespace BankCommoditiesControllers
{
    public class TransactionRatesContoller
    {
        /// <summary>
        /// Devuelve el valor de una transacción en una moneda en concreto.
        /// </summary>
        /// <param name="transaction">Transacción de la que obtener su valor.</param>
        /// <param name="Currencie">Tipo de moneda con la que se quiere mostrar el valor de la transacción.</param>
        /// <param name="rateBackUpPath">Ruta del fichero de copia de Seguridad de las conversiones.</param>
        /// <returns></returns>
        public static decimal GetTransactionAmountInCurrencie(Transaction transaction, String Currencie, string rateBackUpPath)
        {
            if (transaction.Currency.CompareTo(Currencie) == 0)
                return transaction.Amount;
            else
                return (transaction.Amount * RatesController.GetCurrencieConversion(transaction.Currency, Currencie, rateBackUpPath)).Bank();
        }

        /// <summary>
        /// Devuelve la suma de valores de una transacción en una moneda en concreto a partir de su código SKU.
        /// </summary>
        /// <param name="sku">Código SKU de la transacción sobre la que se quiere obtener el valor.</param>
        /// <param name="Currencie">Tipo de moneda con la que se quiere mostrar el valor de la transacción.</param>
        /// <param name="rateBackUpPath">Ruta del fichero de copia de Seguridad de las conversiones.</param>
        /// <returns></returns>
        public static decimal GetTransactionAmountInCurrencieWithSKU(string sku, String Currencie, string transactionBackUpPath, string rateBackUpPath)
        {
            decimal totalAmount = 0;
            List<Transaction> tList = TransactionsController.GetTransactions(transactionBackUpPath);
            if (tList.Count > 0)
            {
                List<Transaction> transactions = tList.FindAll(t => t.Sku == sku);
                transactions.ForEach(t => totalAmount += GetTransactionAmountInCurrencie(t, Currencie, rateBackUpPath));
            }

            return totalAmount;
        }

        /// <summary>
        /// Devuelve la lista de transacciones en una moneda en concreto a partir de su código SKU.
        /// </summary>
        /// <param name="sku">Código SKU de las transacciones a buscar.</param>
        /// <param name="Currencie">Tipo de moneda con la que se quiere mostrar el valor de las transacciones.</param>
        /// <param name="rateBackUpPath">Ruta del fichero de copia de Seguridad de las conversiones.</param>
        /// <returns></returns>
        public static List<Transaction> GetTransactionsInCurrencieWithSKU(string sku, String currencie, string transactionBackUpPath, string rateBackUpPath)
        {
            List<Transaction> exitTransactions = null;
            List<Transaction> tList = TransactionsController.GetTransactions(transactionBackUpPath);
            if (tList.Count > 0)
            {
                List<Transaction> transactions = tList.FindAll(t => t.Sku == sku);
                transactions.ForEach(t => exitTransactions.Add(GetTransactionInCurrencie(t, currencie, rateBackUpPath)));
            }

            return exitTransactions;
        }

        /// <summary>
        /// Devuelve un objeto de tipo Transaction pasando como valor de la transacción en una moneda en concreto.
        /// </summary>
        /// <param name="inTransaction">Transacción de entrada.</param>
        /// <param name="currencie">Tipo de moneda a convertir el valor de la transacción.</param>
        /// <param name="rateBackUpPath">Ruta del fichero de copia de Seguridad de las conversiones.</param>
        /// <returns></returns>
        private static Transaction GetTransactionInCurrencie(Transaction inTransaction, string currencie, string rateBackUpPath)
        {
            decimal amountInCurrencie = GetTransactionAmountInCurrencie(inTransaction, currencie, rateBackUpPath);

            return new Transaction { Amount = amountInCurrencie, Currency = currencie, Sku = inTransaction.Sku };
        }

    }
}
