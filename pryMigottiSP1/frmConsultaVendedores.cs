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
    public partial class frmConsultaVendedores : Form
    {
        public frmConsultaVendedores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StreamReader Vendedores = new StreamReader("./Vendedores.csv");
            while (!Vendedores.EndOfStream)
            {
                string DatoVendedor = Vendedores.ReadLine();
                string[] vecDatosVendedor = DatoVendedor.Split(';');
                dgvConsultaVendedor.Rows.Add(vecDatosVendedor[0], vecDatosVendedor[1]);
            }
            Vendedores.Close();
        }

        private void btnSalirVendedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCVendedores_Click(object sender, EventArgs e)
        {
            dgvConsultaVendedor.Rows.Clear();
        }
    }
}
