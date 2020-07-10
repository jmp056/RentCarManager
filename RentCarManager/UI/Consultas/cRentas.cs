using RentCarManager.Entidades;
using RentCarManager.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarManager.UI.Consultas
{
    public partial class cRentas : Form
    {
        private List<RentasConsulta> ListadoRentas = new List<RentasConsulta>();

        public cRentas()
        {
            InitializeComponent();
        }

        public static List<RentasConsulta> CargaLista()
        {
            List<RentasConsulta> Lista = new List<RentasConsulta>();
            RentasConsulta rC = new RentasConsulta();

            SqlConnection Conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = RentCarManagerDb; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("select r.RentaId, r.NombreCliente, r.Celular, r.FechaRegistro, v.Marca, v.Modelo, v.Version, v.AnoFabricacion, V.Placa from Rentas as R, Vehiculos as V where R.VehiculoId = V.VehiculoId;", Conexion);
            Conexion.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                rC = new RentasConsulta();
                rC.RentaId = Convert.ToInt32(dataReader["RentaId"].ToString());
                rC.NombreCliente = dataReader["NombreCliente"].ToString();
                rC.Celular = dataReader["Celular"].ToString();
                rC.FechaRegistro = Convert.ToDateTime(dataReader["FechaRegistro"].ToString());
                rC.Marca = dataReader["Marca"].ToString();
                rC.Modelo = dataReader["Modelo"].ToString();
                rC.Version = dataReader["Version"].ToString();
                rC.AnoFabricacion = Convert.ToInt32(dataReader["AnoFabricacion"].ToString());
                rC.Placa = dataReader["Placa"].ToString();

                Lista.Add(rC);
            }

            dataReader.Close();
            Conexion.Close();

            return Lista;
        }

        private void Buscar()
        {
            ListadoRentas = CargaLista();

            switch (FiltroComboBox.SelectedIndex)
            {

                case 0: //Filtrar por Nombre
                    ListadoRentas = ListadoRentas.Where(l => l.NombreCliente.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 1: //Filtrar por Celular
                    ListadoRentas = ListadoRentas.Where(l => l.Celular.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 2: //Filtrar por Fecha de registro
                    ListadoRentas = ListadoRentas.Where(l => l.FechaRegistro.Date >= DesdeDateTimePicker.Value.Date && l.FechaRegistro.Date <= HastaDateTimePicker.Value.Date).ToList();
                    break;

                case 3: //Filtrar por Marca
                    ListadoRentas = ListadoRentas.Where(l => l.Marca.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 4: //Filtrar por modelo
                    ListadoRentas = ListadoRentas.Where(l => l.Modelo.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 5: //Filtrar por version
                    ListadoRentas = ListadoRentas.Where(l => l.Version.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 6: //Filtrar por año de fabricacion
                    ListadoRentas = ListadoRentas.Where(l => l.AnoFabricacion >= DesdeNumericUpDown.Value && l.AnoFabricacion <= HastaNumericUpDown.Value).ToList();
                    break;

                case 7: //Filtrar por Placa
                    ListadoRentas = ListadoRentas.Where(l => l.Placa.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;
            }

            RentasDataGridView.DataSource = null;
            RentasDataGridView.DataSource = ListadoRentas;
            RentasDataGridView.ClearSelection();
            RentasDataGridView.Columns[0].Visible = false;
        }
        private void cRentas_Activated(object sender, EventArgs e)
        {
            Texto();
            FiltroComboBox.SelectedIndex = 0;
            Buscar();
        }

        private void Texto()
        {
            DesdeLabel.Text = "Criterio";
            CriterioTextBox.Text = string.Empty;
            CriterioTextBox.Visible = true;
            HastaLabel.Visible = false;
            DesdeDateTimePicker.Visible = false;
            HastaDateTimePicker.Visible = false;
            DesdeNumericUpDown.Visible = false;
            HastaNumericUpDown.Visible = false;
        }

        private void Ano()
        {
            DesdeLabel.Text = "Desde";
            CriterioTextBox.Visible = false;
            HastaLabel.Visible = true;
            DesdeDateTimePicker.Visible = false;
            HastaDateTimePicker.Visible = false;
            DesdeNumericUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
            HastaNumericUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
            DesdeNumericUpDown.Visible = true;
            HastaNumericUpDown.Visible = true;
        }

        private void Fecha()
        {
            DesdeLabel.Text = "Desde";
            CriterioTextBox.Visible = false;
            HastaLabel.Visible = true;
            DesdeDateTimePicker.Value = DateTime.Now;
            DesdeDateTimePicker.Value = DateTime.Now;
            DesdeDateTimePicker.Visible = true;
            HastaDateTimePicker.Visible = true;
            DesdeNumericUpDown.Visible = false;
            HastaNumericUpDown.Visible = false;
        }

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DesdeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void HastaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FiltroComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 2)
                Fecha();
            else if (FiltroComboBox.SelectedIndex == 6)
                Ano();
            else
                Texto();
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (ListadoRentas.Count > 0)
            {
                if (RentasDataGridView.CurrentRow.Index >= 0)
                {
                    int IdRentaSeleccionada = Convert.ToInt32(RentasDataGridView.CurrentRow.Cells["RentaId"].Value);
                    rRentas rR = new rRentas(IdRentaSeleccionada);
                    rR.ShowDialog();
                }
            }
        }

        private void RentasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListadoRentas.Count > 0)
            {
                if (RentasDataGridView.CurrentRow.Index >= 0)
                {
                    int IdRentaSeleccionada = Convert.ToInt32(RentasDataGridView.CurrentRow.Cells["RentaId"].Value);
                    rRentas rR = new rRentas(IdRentaSeleccionada);
                    rR.ShowDialog();
                }
            }
        }
    }
}
