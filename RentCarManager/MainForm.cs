using RentCarManager.UI.Consultas;
using RentCarManager.UI.Registros;
using System;
using System.Windows.Forms;

namespace RentCarManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroDeRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRentas rR = new rRentas(0);
            rR.ShowDialog();
        }

        private void registroDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos rV = new rVehiculos(0);
            rV.ShowDialog();
        }

        private void consultaDeRentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cRentas cR = new cRentas();
            cR.ShowDialog();
        }

        private void consultaDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVehiculos cV = new cVehiculos();
            cV.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sVehiculos sV = new sVehiculos();
            if (sV.ShowDialog() == DialogResult.OK)
            {
                int numero = sV.IdVehiculoSeleccionado;
            }

        }
    }
}
