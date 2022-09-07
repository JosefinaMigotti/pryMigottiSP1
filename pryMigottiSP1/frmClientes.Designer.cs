namespace pryMigottiSP1
{
    partial class frmClientes
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
            this.lblIdentificacion1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.mtbIdentificacionCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentificacion1
            // 
            this.lblIdentificacion1.AutoSize = true;
            this.lblIdentificacion1.Location = new System.Drawing.Point(13, 13);
            this.lblIdentificacion1.Name = "lblIdentificacion1";
            this.lblIdentificacion1.Size = new System.Drawing.Size(73, 13);
            this.lblIdentificacion1.TabIndex = 0;
            this.lblIdentificacion1.Text = "Identificación:";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(13, 42);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(47, 13);
            this.lblNombre1.TabIndex = 1;
            this.lblNombre1.Text = "Nombre:";
            // 
            // mtbIdentificacionCliente
            // 
            this.mtbIdentificacionCliente.Location = new System.Drawing.Point(93, 9);
            this.mtbIdentificacionCliente.Mask = "99999";
            this.mtbIdentificacionCliente.Name = "mtbIdentificacionCliente";
            this.mtbIdentificacionCliente.Size = new System.Drawing.Size(100, 20);
            this.mtbIdentificacionCliente.TabIndex = 2;
            this.mtbIdentificacionCliente.ValidatingType = typeof(int);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(93, 38);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.Location = new System.Drawing.Point(106, 67);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroCliente.TabIndex = 4;
            this.btnRegistroCliente.Text = "Registrar";
            this.btnRegistroCliente.UseVisualStyleBackColor = true;
            this.btnRegistroCliente.Click += new System.EventHandler(this.btnRegistroCliente_Click);
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.Location = new System.Drawing.Point(25, 67);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirClientes.TabIndex = 5;
            this.btnSalirClientes.Text = "Salir";
            this.btnSalirClientes.UseVisualStyleBackColor = true;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 100);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnRegistroCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.mtbIdentificacionCliente);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblIdentificacion1);
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentificacion1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.MaskedTextBox mtbIdentificacionCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnRegistroCliente;
        private System.Windows.Forms.Button btnSalirClientes;
    }
}