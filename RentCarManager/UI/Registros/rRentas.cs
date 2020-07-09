using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarManager.UI.Registros
{
    public partial class rRentas : Form
    {
        public rRentas()
        {
            InitializeComponent();
        }

        //private void VerProductosButton_Click(object sender, EventArgs e) // Clic al boton ver productos
        //{
        //    try
        //    {
        //        SeleccionProducto TraeProducto = new SeleccionProducto();
        //        if (TraeProducto.ShowDialog() == DialogResult.OK)
        //        {

        //            Producto = BuscaProducto(TraeProducto.IdProductoSeleccionado);
        //            ProductoTextBox.Text = Producto.Descripcion;
        //            CantidadNumericUpDown.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
