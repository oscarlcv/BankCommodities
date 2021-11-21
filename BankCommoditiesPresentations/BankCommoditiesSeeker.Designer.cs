
namespace BankCommoditiesPresentations
{
    partial class BankCommoditiesSeeker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankCommoditiesSeeker));
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblCodigoSKU = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCodigoSKU = new System.Windows.Forms.TextBox();
            this.gbSelecDatos = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.tsSeeker = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.gbSelecDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gbResultados.SuspendLayout();
            this.tsSeeker.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMoneda
            // 
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(104, 69);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(65, 28);
            this.cboMoneda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(21, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(34, 73);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(64, 20);
            this.lblMoneda.TabIndex = 2;
            this.lblMoneda.Text = "Moneda";
            // 
            // lblCodigoSKU
            // 
            this.lblCodigoSKU.AutoSize = true;
            this.lblCodigoSKU.Location = new System.Drawing.Point(9, 33);
            this.lblCodigoSKU.Name = "lblCodigoSKU";
            this.lblCodigoSKU.Size = new System.Drawing.Size(89, 20);
            this.lblCodigoSKU.TabIndex = 3;
            this.lblCodigoSKU.Text = "Código SKU";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 32691);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(818, 27);
            this.textBox1.TabIndex = 4;
            // 
            // txtCodigoSKU
            // 
            this.txtCodigoSKU.Location = new System.Drawing.Point(103, 29);
            this.txtCodigoSKU.Name = "txtCodigoSKU";
            this.txtCodigoSKU.Size = new System.Drawing.Size(125, 27);
            this.txtCodigoSKU.TabIndex = 5;
            // 
            // gbSelecDatos
            // 
            this.gbSelecDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelecDatos.Controls.Add(this.lblCodigoSKU);
            this.gbSelecDatos.Controls.Add(this.txtCodigoSKU);
            this.gbSelecDatos.Controls.Add(this.cboMoneda);
            this.gbSelecDatos.Controls.Add(this.btnBuscar);
            this.gbSelecDatos.Controls.Add(this.lblMoneda);
            this.gbSelecDatos.Location = new System.Drawing.Point(12, 39);
            this.gbSelecDatos.Name = "gbSelecDatos";
            this.gbSelecDatos.Size = new System.Drawing.Size(453, 156);
            this.gbSelecDatos.TabIndex = 6;
            this.gbSelecDatos.TabStop = false;
            this.gbSelecDatos.Text = "Selección Datos";
            // 
            // dgvResultados
            // 
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(21, 26);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 29;
            this.dgvResultados.Size = new System.Drawing.Size(427, 188);
            this.dgvResultados.TabIndex = 7;
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultados.Controls.Add(this.lblTotal);
            this.gbResultados.Controls.Add(this.txtTotal);
            this.gbResultados.Controls.Add(this.dgvResultados);
            this.gbResultados.Location = new System.Drawing.Point(12, 201);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(454, 272);
            this.gbResultados.TabIndex = 8;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(269, 231);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(317, 227);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 27);
            this.txtTotal.TabIndex = 7;
            // 
            // tsSeeker
            // 
            this.tsSeeker.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsSeeker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInicio,
            this.tsbBuscar,
            this.tsbSalir});
            this.tsSeeker.Location = new System.Drawing.Point(0, 0);
            this.tsSeeker.Name = "tsSeeker";
            this.tsSeeker.Size = new System.Drawing.Size(477, 25);
            this.tsSeeker.TabIndex = 9;
            this.tsSeeker.Text = "toolStrip1";
            this.tsSeeker.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsSeeker_ItemClicked);
            // 
            // tsbInicio
            // 
            this.tsbInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbInicio.Image = ((System.Drawing.Image)(resources.GetObject("tsbInicio.Image")));
            this.tsbInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInicio.Name = "tsbInicio";
            this.tsbInicio.Size = new System.Drawing.Size(39, 22);
            this.tsbInicio.Text = "INICIO";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(45, 22);
            this.tsbBuscar.Text = "BUSCAR";
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(34, 22);
            this.tsbSalir.Text = "SALIR";
            // 
            // BankCommoditiesSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 483);
            this.Controls.Add(this.tsSeeker);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbSelecDatos);
            this.Controls.Add(this.textBox1);
            this.Name = "BankCommoditiesSeeker";
            this.Text = "Buscador de Transacciones";
            this.Load += new System.EventHandler(this.BankCommoditiesSeeker_Load);
            this.gbSelecDatos.ResumeLayout(false);
            this.gbSelecDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.tsSeeker.ResumeLayout(false);
            this.tsSeeker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblCodigoSKU;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCodigoSKU;
        private System.Windows.Forms.GroupBox gbSelecDatos;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ToolStrip tsSeeker;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}