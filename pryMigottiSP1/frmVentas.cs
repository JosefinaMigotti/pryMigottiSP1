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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            //.csv archivo excel
            StreamWriter Ventas = new StreamWriter("./Ventas.csv", true);
            Ventas.WriteLine(mtbFechasVentas.Text + ";" + mtbMontoVentas.Text + ";" + mtbClienteVentas.Text + ";" + mtbVendedorVentas.Text);
            MessageBox.Show("Datos guardados");
            Ventas.Close();
            mtbFechasVentas.Text = "";
            mtbMontoVentas.Text = "";
            mtbClienteVentas.Text = "";
            mtbVendedorVentas.Text = "";
        }
    }
}
