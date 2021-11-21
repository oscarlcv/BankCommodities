using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankCommoditiesControllers;

namespace BankCommoditiesPresentations
{
    public partial class BankCommoditiesSeeker : Form
    {
        #region Variables
        string ratesbackuppath;
        string transactionbackuppath;
        #endregion

        #region Constructor
        public BankCommoditiesSeeker()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos Formulario
        private void BankCommoditiesSeeker_Load(object sender, EventArgs e)
        {
            this.ratesbackuppath = $"{AppDomain.CurrentDomain.BaseDirectory}\\RatesBackUp.text";
            this.transactionbackuppath = $"{AppDomain.CurrentDomain.BaseDirectory}\\TransactionBackUp.text";
            this.Inicializar();
        }
        #endregion

        #region Eventos Controles
        private void tsSeeker_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "INICIO":
                    Inicializar();
                    break;
                case "BUSCAR":
                    Buscar();
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        #endregion

        #region Métodos Privados
        private void Inicializar()
        {
            txtCodigoSKU.Clear();
            cboMoneda.Items.Clear();
            dgvResultados.DataSource = null;
            cboMoneda.Items.Add("EUR");
            cboMoneda.Items.Add("CAD");
            cboMoneda.Items.Add("USD");
            cboMoneda.Items.Add("AUD");
            cboMoneda.SelectedIndex = 0;
            txtCodigoSKU.Select();
        }

        private void Buscar()
        {
            if (txtCodigoSKU.Text.Length > 0)
            {
                dgvResultados.DataSource = TransactionRatesContoller.GetTransactionsInCurrencieWithSKU(txtCodigoSKU.Text, cboMoneda.Text, transactionbackuppath, ratesbackuppath).ToArray();
                txtTotal.Text = TransactionRatesContoller.GetTransactionAmountInCurrencieWithSKU(txtCodigoSKU.Text, cboMoneda.Text, transactionbackuppath, ratesbackuppath).ToString();          
            }
            else
            {
                MessageBox.Show(this, "Indique un código SKU a buscar.");
            }
        }
        #endregion

    }
}
