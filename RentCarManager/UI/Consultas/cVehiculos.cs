using RentCarManager.Entidades;
using RentCarManager.UI.Registros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace RentCarManager.UI.Consultas
{
    public partial class cVehiculos : Form
    {
        private List<VehiculosConsulta> ListadoVehiculos = new List<VehiculosConsulta>();

        public cVehiculos()
        {
            InitializeComponent();
        }

        public static List<VehiculosConsulta> CargaLista()
        {
            List<VehiculosConsulta> Lista = new List<VehiculosConsulta>();
            VehiculosConsulta vC = new VehiculosConsulta();

            SqlConnection Conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = RentCarManagerDb; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select VehiculoId, Marca, Modelo, Version, AnoFabricacion, Placa, Estado, Precio from Vehiculos", Conexion);
            Conexion.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                vC = new VehiculosConsulta();
                vC.VehiculoId = Convert.ToInt32(dataReader["VehiculoId"].ToString());
                vC.Marca = dataReader["Marca"].ToString();
                vC.Modelo = dataReader["Modelo"].ToString();
                vC.Version = dataReader["Version"].ToString();
                vC.AnoFabricacion = Convert.ToInt32(dataReader["AnoFabricacion"].ToString());
                vC.Placa = dataReader["Placa"].ToString();
                switch (Convert.ToInt32(dataReader["Estado"].ToString()))
                {
                    case 0: 
                        vC.Estado = "Disponible";
                        break;

                    case 1:
                        vC.Estado = "Rentado";
                        break;

                    case 2:
                        vC.Estado = "En reparacion";
                        break;

                    case 3:
                        vC.Estado = "No disponible";
                        break;
                }
                vC.Precio = Convert.ToSingle(dataReader["Precio"].ToString());

                Lista.Add(vC);
            }

            dataReader.Close();
            Conexion.Close();

            return Lista;
        }

        private void Buscar()
        {
            ListadoVehiculos = CargaLista();

            switch (FiltroComboBox.SelectedIndex)
            {

                case 0: //Filtrar por marca
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.Marca.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 1://Filtrar por Modelo
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.Modelo.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 2://Filtrar por version
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.Version.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 3: //Filtrar por año de fabricacion
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.AnoFabricacion >= Convert.ToSingle(DesdeNumericUpDown.Value) && l.AnoFabricacion <= Convert.ToSingle(HastaNumericUpDown.Value)).ToList();
                    break;

                case 4: //Filtrar por Placa
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.Placa.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 5: //Filtrar por estado
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.Estado == CriterioComboBox.Text).ToList();
                    break;

                case 6: //Filtrar por Precio
                    ListadoVehiculos = ListadoVehiculos.Where(l => l.Precio >= Convert.ToSingle(DesdeNumericUpDown.Value) && l.Precio <= Convert.ToSingle(HastaNumericUpDown.Value)).ToList();
                    break;
            }

            VehiculosDataGridView.DataSource = null;
            VehiculosDataGridView.DataSource = ListadoVehiculos;
            VehiculosDataGridView.ClearSelection();
            VehiculosDataGridView.Columns[0].Visible = false;
        }

        private void cVehiculos_Activated(object sender, EventArgs e)
        {
            Texto();
            FiltroComboBox.SelectedIndex = 0;
            Buscar();
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
            if (FiltroComboBox.SelectedIndex == 0 || FiltroComboBox.SelectedIndex == 1 || FiltroComboBox.SelectedIndex == 2 || FiltroComboBox.SelectedIndex == 4)
                Texto();
            else if (FiltroComboBox.SelectedIndex == 3)
                Ano();
            else if (FiltroComboBox.SelectedIndex == 5)
                Combo();
            else if (FiltroComboBox.SelectedIndex == 6)
                Precio();
        }

        private void Texto()
        {
            DesdeLabel.Text = "Criterio";
            CriterioTextBox.Text = string.Empty;
            CriterioTextBox.Visible = true;
            HastaLabel.Visible = false;
            CriterioComboBox.Visible = false;
            CriterioComboBox.SelectedIndex = 0;
            DesdeNumericUpDown.Visible = false;
            HastaNumericUpDown.Visible = false;
        }

        private void Ano()
        {
            DesdeLabel.Text = "Desde";
            CriterioTextBox.Visible = false;
            HastaLabel.Visible = true;
            CriterioComboBox.Visible = false;
            CriterioComboBox.SelectedIndex = 0;
            DesdeNumericUpDown.DecimalPlaces = 0;
            HastaNumericUpDown.DecimalPlaces = 0;
            DesdeNumericUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
            HastaNumericUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
            DesdeNumericUpDown.Visible = true;
            HastaNumericUpDown.Visible = true;
        }

        private void Combo()
        {
            DesdeLabel.Text = "Estado";
            CriterioComboBox.SelectedIndex = 0;
            CriterioTextBox.Visible = false;
            DesdeNumericUpDown.Visible = false;
            CriterioComboBox.Visible = true;
            HastaLabel.Visible = false;
            HastaNumericUpDown.Visible = false;
        }

        private void Precio()
        {
            DesdeLabel.Text = "Desde";
            CriterioTextBox.Visible = false;
            HastaLabel.Visible = true;
            CriterioComboBox.Visible = false;
            CriterioComboBox.SelectedIndex = 0;
            DesdeNumericUpDown.DecimalPlaces = 2;
            HastaNumericUpDown.DecimalPlaces = 2;
            DesdeNumericUpDown.Value = 0;
            HastaNumericUpDown.Value = 0;
            DesdeNumericUpDown.Visible = true;
            HastaNumericUpDown.Visible = true;
        }

        private void CriterioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 5)
                Buscar();
        }

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void DesdeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void HastaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void VehiculosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListadoVehiculos.Count > 0)
            {
                if (VehiculosDataGridView.CurrentRow.Index >= 0)
                {
                    int IdVehiculoSleccionado = Convert.ToInt32(VehiculosDataGridView.CurrentRow.Cells["VehiculoId"].Value);
                    rVehiculos rV = new rVehiculos(IdVehiculoSleccionado);
                    rV.ShowDialog();
                }
            }
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            if (ListadoVehiculos.Count > 0)
            {
                if (VehiculosDataGridView.CurrentRow.Index >= 0)
                {
                    int IdVehiculoSleccionado = Convert.ToInt32(VehiculosDataGridView.CurrentRow.Cells["VehiculoId"].Value);
                    rVehiculos rV = new rVehiculos(IdVehiculoSleccionado);
                    rV.ShowDialog();
                }
            }
        }
    }
}
