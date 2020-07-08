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
            rRentas rR = new rRentas();
            rR.ShowDialog();
        }

        private void registroDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos rV = new rVehiculos();
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
    }
}
