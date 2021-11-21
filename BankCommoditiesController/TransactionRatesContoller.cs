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
        public decimal GetTransactionAmountInCurrencie(Transaction transaction, String Currencie, string rateBackUpPath)
        {
            if (transaction.Currency.CompareTo(Currencie) == 0)
                return transaction.Amount;
            else
                return (transaction.Amount * RatesController.GetCurrencieConversion(transaction.Currency, Currencie, rateBackUpPath)).Bank();
        }

        /// <summary>
        /// Devuelve el valor de una transacción en una moneda en concreto a partir de su código SKU.
        /// </summary>
        /// <param name="sku">Código SKU de la transacción sobre la que se quiere obtener el valor.</param>
        /// <param name="Currencie">Tipo de moneda con la que se quiere mostrar el valor de la transacción.</param>
        /// <param name="rateBackUpPath">Ruta del fichero de copia de Seguridad de las conversiones.</param>
        /// <returns></returns>
        public decimal GetTransactionAmountInCurrencieWithSKU(string Sku, String Currencie, string transactionBackUpPath, string rateBackUpPath)
        {
            List<Transaction> tList = TransactionsController.GetTransactions(transactionBackUpPath);
            if (tList.Count > 0)
            {
                Transaction transaction = tList.Find(t => t.Sku == Sku);
                if (transaction != null)
                    return GetTransactionAmountInCurrencie(transaction, Currencie, rateBackUpPath);
                else
                    return 0;
            }
            else
                return 0;
        }
    }
}
