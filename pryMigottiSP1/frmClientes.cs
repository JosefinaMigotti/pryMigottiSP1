using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMigottiSP1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistroCliente_Click(object sender, EventArgs e)
        {
            //.csv archivo excel
            StreamWriter Clientes = new StreamWriter("./Clientes.csv", true);
            Clientes.WriteLine(mtbIdentificacionCliente.Text + ";" + txtNombreCliente.Text);
            MessageBox.Show("Datos guardados");
            Clientes.Close();
            mtbIdentificacionCliente.Text = "";
            txtNombreCliente.Text = "";
        }
    }
}
