namespace pryMigottiSP1
{
    partial class frmConsultaVendedores
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
            this.dgvConsultaVendedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalirCVendedores = new System.Windows.Forms.Button();
            this.btnListarCVendedor = new System.Windows.Forms.Button();
            this.btnLimpiarCVendedores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaVendedor
            // 
            this.dgvConsultaVendedor.AllowUserToAddRows = false;
            this.dgvConsultaVendedor.AllowUserToDeleteRows = false;
            this.dgvConsultaVendedor.AllowUserToResizeColumns = false;
            this.dgvConsultaVendedor.AllowUserToResizeRows = false;
            this.dgvConsultaVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaVendedor.Location = new System.Drawing.Point(8, 15);
            this.dgvConsultaVendedor.Name = "dgvConsultaVendedor";
            this.dgvConsultaVendedor.ReadOnly = true;
            this.dgvConsultaVendedor.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaVendedor.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Identificación";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // btnSalirCVendedores
            // 
            this.btnSalirCVendedores.Location = new System.Drawing.Point(12, 174);
            this.btnSalirCVendedores.Name = "btnSalirCVendedores";
            this.btnSalirCVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCVendedores.TabIndex = 4;
            this.btnSalirCVendedores.Text = "Salir";
            this.btnSalirCVendedores.UseVisualStyleBackColor = true;
            this.btnSalirCVendedores.Click += new System.EventHandler(this.btnSalirVendedor_Click);
            // 
            // btnListarCVendedor
            // 
            this.btnListarCVendedor.Location = new System.Drawing.Point(168, 174);
            this.btnListarCVendedor.Name = "btnListarCVendedor";
            this.btnListarCVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnListarCVendedor.TabIndex = 3;
            this.btnListarCVendedor.Text = "Listar";
            this.btnListarCVendedor.UseVisualStyleBackColor = true;
            this.btnListarCVendedor.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLimpiarCVendedores
            // 
            this.btnLimpiarCVendedores.Location = new System.Drawing.Point(90, 174);
            this.btnLimpiarCVendedores.Name = "btnLimpiarCVendedores";
            this.btnLimpiarCVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCVendedores.TabIndex = 6;
            this.btnLimpiarCVendedores.Text = "Limpiar";
            this.btnLimpiarCVendedores.UseVisualStyleBackColor = true;
            this.btnLimpiarCVendedores.Click += new System.EventHandler(this.btnLimpiarCVendedores_Click);
            // 
            // frmConsultaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 206);
            this.Controls.Add(this.btnLimpiarCVendedores);
            this.Controls.Add(this.dgvConsultaVendedor);
            this.Controls.Add(this.btnSalirCVendedores);
            this.Controls.Add(this.btnListarCVendedor);
            this.MaximizeBox = false;
            this.Name = "frmConsultaVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Vendedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnSalirCVendedores;
        private System.Windows.Forms.Button btnListarCVendedor;
        private System.Windows.Forms.Button btnLimpiarCVendedores;
    }
}