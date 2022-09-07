﻿using System;
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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void btnSalirCVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarCVentas_Click(object sender, EventArgs e)
        {
            dgvConsultaVentas.Rows.Clear();
        }

        private void btnListarCVentas_Click(object sender, EventArgs e)
        {
            StreamReader Ventas = new StreamReader("./Ventas.csv");
            while (!Ventas.EndOfStream)
            {
                string DatoVentas = Ventas.ReadLine();
                string[] vecDatosVentas = DatoVentas.Split(';');
                dgvConsultaVentas.Rows.Add(vecDatosVentas[0], vecDatosVentas[1], vecDatosVentas[2], vecDatosVentas[1]);
            }
            Ventas.Close();
        }
    }
}
