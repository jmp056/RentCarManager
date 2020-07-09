using RentCarManager.BLL;
using RentCarManager.Entidades;
using System;
using System.Windows.Forms;

namespace RentCarManager.UI.Registros
{
    public partial class rVehiculos : Form
    {
        int VehiculoId;
        public rVehiculos(int vehiculoId)
        {
            this.VehiculoId = vehiculoId;
            InitializeComponent();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            VehiculoId = 0;
            ChasisTextBox.Text = string.Empty;
            MatriculaTextBox.Text = string.Empty;
            PlacaTextBox.Text = string.Empty;
            MarcaTextBox.Text = string.Empty;
            ModeloTextBox.Text = string.Empty;
            VersionTextBox.Text = string.Empty;
            AnoFabricacionNumericUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
            PrecioNumericUpDown.Value = 0;
            EstadoComboBox.SelectedIndex = -1;
        }

        private Vehiculos LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Vehiculos Vehiculo = new Vehiculos();

            Vehiculo.VehiculoId = VehiculoId;
            Vehiculo.Chasis = ChasisTextBox.Text;
            Vehiculo.Matricula = MatriculaTextBox.Text;
            Vehiculo.Placa = PlacaTextBox.Text;
            Vehiculo.Marca = MarcaTextBox.Text;
            Vehiculo.Modelo = ModeloTextBox.Text;
            Vehiculo.Version = VersionTextBox.Text;
            Vehiculo.AnoFabricacion = Convert.ToInt32(AnoFabricacionNumericUpDown.Value);
            Vehiculo.Precio = Convert.ToSingle(PrecioNumericUpDown.Value);
            Vehiculo.Estado = EstadoComboBox.SelectedIndex;

            return Vehiculo;
        }

        private void LlenaCampo(Vehiculos Vehiculo)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {

            VehiculoId = Vehiculo.VehiculoId;
            ChasisTextBox.Text = Vehiculo.Chasis;
            MatriculaTextBox.Text = Vehiculo.Matricula;
            PlacaTextBox.Text = Vehiculo.Placa;
            MarcaTextBox.Text = Vehiculo.Marca;
            ModeloTextBox.Text = Vehiculo.Modelo;
            VersionTextBox.Text = Vehiculo.Version;
            AnoFabricacionNumericUpDown.Value = Convert.ToInt32(Vehiculo.AnoFabricacion);
            PrecioNumericUpDown.Value = Convert.ToDecimal(Vehiculo.Precio);
            EstadoComboBox.SelectedIndex = Vehiculo.Estado;

        }

        private bool Validar() //Funcion que valida todo el registro
        {

            bool paso = true;
            MyErrorProvider.Clear();

            if (ChasisTextBox.Text == string.Empty) //Validando que el chasis no este vacio
            {
                MyErrorProvider.SetError(ChasisTextBox, "El campo \"Chasis\" no puede estar vacio");
                ChasisTextBox.Focus();
                paso = false;
            }

            if (MatriculaTextBox.Text == string.Empty) //Validando que la matricula no este vacio
            {
                MyErrorProvider.SetError(MatriculaTextBox, "El campo \"Matricula\" no puede estar vacio");
                MatriculaTextBox.Focus();
                paso = false;
            }

            if (PlacaTextBox.Text == string.Empty) //Validando que la matricula no este vacio
            {
                MyErrorProvider.SetError(PlacaTextBox, "El campo \"Placa\" no puede estar vacio");
                PlacaTextBox.Focus();
                paso = false;
            }

            if (MarcaTextBox.Text == string.Empty) //Validando que la matricula no este vacio
            {
                MyErrorProvider.SetError(MarcaTextBox, "El campo \"Marca\" no puede estar vacio");
                MarcaTextBox.Focus();
                paso = false;
            }

            if (ModeloTextBox.Text == string.Empty) //Validando que la matricula no este vacio
            {
                MyErrorProvider.SetError(ModeloTextBox, "El campo \"Modelo\" no puede estar vacio");
                ModeloTextBox.Focus();
                paso = false;
            }

            if (VersionTextBox.Text == string.Empty) //Validando que la matricula no este vacio
            {
                MyErrorProvider.SetError(VersionTextBox, "El campo \"Version\" no puede estar vacio");
                VersionTextBox.Focus();
                paso = false;
            }

            if (AnoFabricacionNumericUpDown.Value < 1900 || AnoFabricacionNumericUpDown.Value > Convert.ToInt32(DateTime.Now.Year)) //Validando que el año no sea menor a 0 o mayor al año actual + 1
            {
                MyErrorProvider.SetError(AnoFabricacionNumericUpDown, "El campo \"Año\" no puede ser menor a 0 o mayor al año actual mas 1");
                AnoFabricacionNumericUpDown.Focus();
                paso = false;
            }

            if (PrecioNumericUpDown.Value < 0 ) //Validando que el precio sea mayor a 0
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "El campo \"Precio\" no puede ser menor a 0 ");
                PrecioNumericUpDown.Focus();
                paso = false;
            }

            if (EstadoComboBox.SelectedIndex < 0) //Validando que el estado este seleccionado
            {
                MyErrorProvider.SetError(EstadoComboBox, "Debe seleccionr un estado");
                EstadoComboBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos() //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<Vehiculos> Repositorio = new RepositorioBase<Vehiculos>();
            Vehiculos Vehiculo = Repositorio.Buscar(VehiculoId);
            return (Vehiculo != null);
        }

        private void Buscar()
        {
            RepositorioBase<Vehiculos> Repositorio = new RepositorioBase<Vehiculos>();
            Vehiculos Vehiculo = new Vehiculos();

            Vehiculo = Repositorio.Buscar(VehiculoId);

            if (Vehiculo != null)
            {
                LlenaCampo(Vehiculo);
            }
            else
            {
                Limpiar();
                MessageBox.Show("No fue posible culminar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guardar()
        {
            RepositorioBase<Vehiculos> Repositorio = new RepositorioBase<Vehiculos>();

            Vehiculos Vehiculo = new Vehiculos();

            bool Paso = false;

            Vehiculo = LlenaClase();

            if (VehiculoId == 0)
            {
                Paso = Repositorio.Guardar(Vehiculo);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No fue posible modificar este vehiculo, inténtelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar este vehiculo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Paso = Repositorio.Modificar(Vehiculo);
                    if (Paso)
                    {
                        MessageBox.Show("El vehiculo se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar este vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    return;
                }
            }

            if (Paso)
            {
                MessageBox.Show("El vehiculo se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible guardar este vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ChasisTextBox.Focus();
        }

        private void Eliminar()
        {
            RepositorioBase<Vehiculos> Repositorio = new RepositorioBase<Vehiculos>();

            bool Paso = false;

            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se pudo eliminar este vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChasisTextBox.Focus();
                return;
            }
            else
            {
                Vehiculos Vehiculo = Repositorio.Buscar(VehiculoId);
                if (Vehiculo != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar este vehiculo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Paso = Repositorio.Eliminar(VehiculoId);
                        if (Paso)
                        {
                            MessageBox.Show("El vehiculo fue eliminado correctamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar este vehiculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ChasisTextBox.Focus();
                        }
                        return;
                    }
                }

            }
            ChasisTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            Guardar();
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void rVehiculos_Load(object sender, EventArgs e)
        {
            if (VehiculoId > 0)
            {
                Buscar();
            }
            else
                AnoFabricacionNumericUpDown.Value = Convert.ToInt32(DateTime.Now.Year);
        }
    }
}
