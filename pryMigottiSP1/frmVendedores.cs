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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void btnRegistroVendedores_Click(object sender, EventArgs e)
        {
            //.csv archivo excel
            StreamWriter Vendedores = new StreamWriter("./Vendedores.csv", true);
            Vendedores.WriteLine(mtbIdentificacionVendedores.Text + ";" + txtNombreVendedores.Text);
            MessageBox.Show("Datos guardados");
            Vendedores.Close();
            mtbIdentificacionVendedores.Text = "";
            txtNombreVendedores.Text = "";
        }

        private void btnSalirVendedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
