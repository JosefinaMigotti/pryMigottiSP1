namespace pryMigottiSP1
{
    partial class frmConsultaClientes
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
            this.btnListarCClientes = new System.Windows.Forms.Button();
            this.btnSalirCClientes = new System.Windows.Forms.Button();
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarCClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarCClientes
            // 
            this.btnListarCClientes.Location = new System.Drawing.Point(176, 171);
            this.btnListarCClientes.Name = "btnListarCClientes";
            this.btnListarCClientes.Size = new System.Drawing.Size(75, 23);
            this.btnListarCClientes.TabIndex = 0;
            this.btnListarCClientes.Text = "Listar";
            this.btnListarCClientes.UseVisualStyleBackColor = true;
            this.btnListarCClientes.Click += new System.EventHandler(this.btnListarCClientes_Click);
            // 
            // btnSalirCClientes
            // 
            this.btnSalirCClientes.Location = new System.Drawing.Point(12, 171);
            this.btnSalirCClientes.Name = "btnSalirCClientes";
            this.btnSalirCClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCClientes.TabIndex = 1;
            this.btnSalirCClientes.Text = "Salir";
            this.btnSalirCClientes.UseVisualStyleBackColor = true;
            this.btnSalirCClientes.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.AllowUserToAddRows = false;
            this.dgvConsultaCliente.AllowUserToDeleteRows = false;
            this.dgvConsultaCliente.AllowUserToResizeColumns = false;
            this.dgvConsultaCliente.AllowUserToResizeRows = false;
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvConsultaCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.ReadOnly = true;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(240, 150);
            this.dgvConsultaCliente.TabIndex = 2;
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
            // btnLimpiarCClientes
            // 
            this.btnLimpiarCClientes.Location = new System.Drawing.Point(94, 171);
            this.btnLimpiarCClientes.Name = "btnLimpiarCClientes";
            this.btnLimpiarCClientes.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCClientes.TabIndex = 3;
            this.btnLimpiarCClientes.Text = "Limpiar";
            this.btnLimpiarCClientes.UseVisualStyleBackColor = true;
            this.btnLimpiarCClientes.Click += new System.EventHandler(this.btnLimpiarCClientes_Click);
            // 
            // frmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 203);
            this.Controls.Add(this.btnLimpiarCClientes);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Controls.Add(this.btnSalirCClientes);
            this.Controls.Add(this.btnListarCClientes);
            this.MaximizeBox = false;
            this.Name = "frmConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarCClientes;
        private System.Windows.Forms.Button btnSalirCClientes;
        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnLimpiarCClientes;
    }
}