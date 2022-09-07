namespace pryMigottiSP1
{
    partial class frmVentas
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.mtbFechasVentas = new System.Windows.Forms.MaskedTextBox();
            this.mtbMontoVentas = new System.Windows.Forms.MaskedTextBox();
            this.mtbClienteVentas = new System.Windows.Forms.MaskedTextBox();
            this.mtbVendedorVentas = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistroVentas = new System.Windows.Forms.Button();
            this.btnSalirVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 40);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto:";
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(12, 67);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(42, 13);
            this.lblClienteID.TabIndex = 3;
            this.lblClienteID.Text = "Cliente:";
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(12, 94);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(56, 13);
            this.lblVendedorID.TabIndex = 4;
            this.lblVendedorID.Text = "Vendedor:";
            // 
            // mtbFechasVentas
            // 
            this.mtbFechasVentas.Location = new System.Drawing.Point(72, 10);
            this.mtbFechasVentas.Mask = "00/00/0000";
            this.mtbFechasVentas.Name = "mtbFechasVentas";
            this.mtbFechasVentas.Size = new System.Drawing.Size(100, 20);
            this.mtbFechasVentas.TabIndex = 5;
            this.mtbFechasVentas.ValidatingType = typeof(System.DateTime);
            // 
            // mtbMontoVentas
            // 
            this.mtbMontoVentas.Location = new System.Drawing.Point(72, 37);
            this.mtbMontoVentas.Mask = "999999999";
            this.mtbMontoVentas.Name = "mtbMontoVentas";
            this.mtbMontoVentas.Size = new System.Drawing.Size(100, 20);
            this.mtbMontoVentas.TabIndex = 6;
            this.mtbMontoVentas.ValidatingType = typeof(int);
            // 
            // mtbClienteVentas
            // 
            this.mtbClienteVentas.Location = new System.Drawing.Point(72, 64);
            this.mtbClienteVentas.Mask = "99999";
            this.mtbClienteVentas.Name = "mtbClienteVentas";
            this.mtbClienteVentas.Size = new System.Drawing.Size(100, 20);
            this.mtbClienteVentas.TabIndex = 7;
            this.mtbClienteVentas.ValidatingType = typeof(int);
            // 
            // mtbVendedorVentas
            // 
            this.mtbVendedorVentas.Location = new System.Drawing.Point(72, 91);
            this.mtbVendedorVentas.Mask = "99999";
            this.mtbVendedorVentas.Name = "mtbVendedorVentas";
            this.mtbVendedorVentas.Size = new System.Drawing.Size(100, 20);
            this.mtbVendedorVentas.TabIndex = 8;
            this.mtbVendedorVentas.ValidatingType = typeof(int);
            // 
            // btnRegistroVentas
            // 
            this.btnRegistroVentas.Location = new System.Drawing.Point(93, 128);
            this.btnRegistroVentas.Name = "btnRegistroVentas";
            this.btnRegistroVentas.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroVentas.TabIndex = 9;
            this.btnRegistroVentas.Text = "Registrar";
            this.btnRegistroVentas.UseVisualStyleBackColor = true;
            this.btnRegistroVentas.Click += new System.EventHandler(this.btnRegistroVentas_Click);
            // 
            // btnSalirVentas
            // 
            this.btnSalirVentas.Location = new System.Drawing.Point(12, 128);
            this.btnSalirVentas.Name = "btnSalirVentas";
            this.btnSalirVentas.Size = new System.Drawing.Size(75, 23);
            this.btnSalirVentas.TabIndex = 10;
            this.btnSalirVentas.Text = "Salir";
            this.btnSalirVentas.UseVisualStyleBackColor = true;
            this.btnSalirVentas.Click += new System.EventHandler(this.btnSalirVentas_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 169);
            this.Controls.Add(this.btnSalirVentas);
            this.Controls.Add(this.btnRegistroVentas);
            this.Controls.Add(this.mtbVendedorVentas);
            this.Controls.Add(this.mtbClienteVentas);
            this.Controls.Add(this.mtbMontoVentas);
            this.Controls.Add(this.mtbFechasVentas);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblFecha);
            this.MaximizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.MaskedTextBox mtbFechasVentas;
        private System.Windows.Forms.MaskedTextBox mtbMontoVentas;
        private System.Windows.Forms.MaskedTextBox mtbClienteVentas;
        private System.Windows.Forms.MaskedTextBox mtbVendedorVentas;
        private System.Windows.Forms.Button btnRegistroVentas;
        private System.Windows.Forms.Button btnSalirVentas;
    }
}