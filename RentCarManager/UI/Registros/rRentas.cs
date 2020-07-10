using RentCarManager.BLL;
using RentCarManager.Entidades;
using RentCarManager.UI.Consultas;
using System;
using System.Windows.Forms;

namespace RentCarManager.UI.Registros
{
    public partial class rRentas : Form
    {
        int RentaId;
        int VehiculoId;
        Vehiculos Vehiculo = new Vehiculos();

        public rRentas(int rentaId)
        {
            this.RentaId = rentaId;
            InitializeComponent();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            RentaId = 0;
            NombreTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
            DiasNumericUpDown.Value = 0;
            FechaInicioDateTimePicker.Value = DateTime.Now;
            FechaEntregaDateTimePicker.Value = DateTime.Now;
            VehiculoTextBox.Text = string.Empty;
            Vehiculo = new Vehiculos();
            PrecioNumericUpDown.Value = 0;
            TotalNumericUpDown.Value = 0;
            SeleccionarButton.Enabled = false;
        }

        private Rentas LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Rentas Renta = new Rentas();

            Renta.RentaId = RentaId;
            Renta.NombreCliente = NombreTextBox.Text;
            Renta.Cedula = CedulaMaskedTextBox.Text;
            Renta.Celular = CedulaMaskedTextBox.Text;
            Renta.Direccion = DireccionTextBox.Text;
            Renta.FechaRegistro = FechaRegistroDateTimePicker.Value;
            Renta.Dias = Convert.ToInt32(DiasNumericUpDown.Value);
            Renta.FechaInicio = FechaInicioDateTimePicker.Value;
            Renta.FechaEntrega = FechaEntregaDateTimePicker.Value;
            Renta.VehiculoId = Vehiculo.VehiculoId;
            Renta.Precio = Convert.ToSingle(PrecioNumericUpDown.Value);
            Renta.Total = Convert.ToSingle(TotalNumericUpDown.Value);

            return Renta;
        }

        private void LlenaCampo(Rentas Renta)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            RentaId = Renta.RentaId;
            NombreTextBox.Text = Renta.NombreCliente;
            CedulaMaskedTextBox.Text = Renta.Cedula;
            CelularMaskedTextBox.Text = Renta.Celular;
            DireccionTextBox.Text = Renta.Direccion;
            FechaRegistroDateTimePicker.Value = Renta.FechaRegistro;
            DiasNumericUpDown.Value = Renta.Dias;
            FechaInicioDateTimePicker.Value = Renta.FechaInicio;
            FechaEntregaDateTimePicker.Value = Renta.FechaEntrega;
            VehiculoTextBox.Text = Vehiculo.Marca + " " + Vehiculo.Modelo + " " + Vehiculo.Version + " " + Vehiculo.AnoFabricacion;
            PrecioNumericUpDown.Value = Convert.ToDecimal(Renta.Precio);
            TotalNumericUpDown.Value = Convert.ToDecimal(Renta.Total);

        }

        private bool Validar() //Funcion que valida todo el registro
        {

            bool paso = true;
            MyErrorProvider.Clear();

            if (NombreTextBox.Text == string.Empty) //Validando que el nombre no este vacio
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo \"Nombre\" no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (CedulaMaskedTextBox.Text == string.Empty) //Validando que el Cedula no este vacio
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo \"Cedula\" no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (CelularMaskedTextBox.Text == string.Empty) //Validando que el celular no este vacio
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo \"Celular\" no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (DireccionTextBox.Text == string.Empty) //Validando que el Direccion no este vacio
            {
                MyErrorProvider.SetError(DireccionTextBox, "El campo \"Direccion\" no puede estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }

            if (DiasNumericUpDown.Value <= 0) //Validando que los dias sean mayor a 0
            {
                MyErrorProvider.SetError(DiasNumericUpDown, "El campo \"Dias\" debe ser mayor a 0");
                DiasNumericUpDown.Focus();
                paso = false;
            }

            if (FechaInicioDateTimePicker.Value.Date < FechaRegistroDateTimePicker.Value.Date) //Validando la fecha de inicio sea mayor o igual a la de registro
            {
                MyErrorProvider.SetError(FechaInicioDateTimePicker, "La fecha de inicio debe ser mayor o igual a la fecha de registro");
                FechaInicioDateTimePicker.Focus();
                paso = false;
            }

            if (VehiculoTextBox.Text == string.Empty) //Validando que se haya seleccionado un vehiculo
            {
                MyErrorProvider.SetError(VehiculoTextBox, "Debe seleccionar un vehiculo");
                VehiculoTextBox.Focus();
                paso = false;
            }

            if (PrecioNumericUpDown.Value <= 0) //Validando que el precio sea mayor a 0
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "El campo \"Precio\" debe ser mayor a 0");
                PrecioNumericUpDown.Focus();
                paso = false;
            }

            if (TotalNumericUpDown.Value <= 0) //Validando que el total sea mayor a 0
            {
                MyErrorProvider.SetError(TotalNumericUpDown, "El campo \"Total\" debe ser mayor a 0");
                TotalNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos() //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<Rentas> Repositorio = new RepositorioBase<Rentas>();
            Rentas Renta = Repositorio.Buscar(RentaId);
            return (Renta != null);
        }

        private void Buscar()
        {
            RepositorioBase<Rentas> Repositorio = new RepositorioBase<Rentas>();
            Rentas Renta = new Rentas();

            Renta = Repositorio.Buscar(RentaId);

            RepositorioBase<Vehiculos> Repositorio2 = new RepositorioBase<Vehiculos>();
            Vehiculo = Repositorio2.Buscar(Renta.VehiculoId);

            if (Renta != null)
            {
                LlenaCampo(Renta);
            }
            else
            {
                Limpiar();
                MessageBox.Show("No fue posible culminar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guardar()
        {
            RepositorioBase<Rentas> Repositorio = new RepositorioBase<Rentas>();
            RepositorioBase<Vehiculos> Repositorio2 = new RepositorioBase<Vehiculos>();

            Rentas Renta = new Rentas();

            bool Paso = false;

            Renta = LlenaClase();

            if (RentaId == 0)
            {
                Paso = Repositorio.Guardar(Renta);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No fue posible modificar este renta, inténtelo mas tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar este renta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Paso = Repositorio.Modificar(Renta);
                    if (Paso)
                    {
                        MessageBox.Show("El renta se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible guardar este renta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Vehiculo.Estado = 1;
                Repositorio2.Modificar(Vehiculo);
                MessageBox.Show("El renta se guardó correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible guardar este renta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            NombreTextBox.Focus();
        }

        private void Eliminar()
        {
            RepositorioBase<Rentas> Repositorio = new RepositorioBase<Rentas>();
            RepositorioBase<Vehiculos> Repositorio2 = new RepositorioBase<Vehiculos>();

            bool Paso = false;

            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se pudo eliminar este renta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreTextBox.Focus();
                return;
            }
            else
            {
                Rentas Renta = Repositorio.Buscar(RentaId);
                if (Renta != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar este renta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Vehiculo = Repositorio2.Buscar(Renta.VehiculoId);
                        Paso = Repositorio.Eliminar(RentaId);
                        if (Paso)
                        {
                            Vehiculo.Estado = 0;
                            Repositorio2.Guardar(Vehiculo);
                            MessageBox.Show("El renta fue eliminado correctamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar este renta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NombreTextBox.Focus();
                        }
                        return;
                    }
                }

            }
            NombreTextBox.Focus();
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

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            sVehiculos sV = new sVehiculos();
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();

            if (sV.ShowDialog() == DialogResult.OK)
            {

                Vehiculo = repositorio.Buscar(sV.IdVehiculoSeleccionado);
                VehiculoTextBox.Text = Vehiculo.Marca + " " + Vehiculo.Modelo + " " + Vehiculo.Version + " " + Vehiculo.AnoFabricacion;
                PrecioNumericUpDown.Value = Convert.ToDecimal(Vehiculo.Precio);
            }
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            Guardar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void rRentas_Load(object sender, EventArgs e)
        {
            if (RentaId > 0)
            {
                Buscar();
            }

        }

        private void FechaInicioDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FechaEntregaDateTimePicker.Value = FechaInicioDateTimePicker.Value.AddDays(Convert.ToInt32(DiasNumericUpDown.Value));
        }

        private void DiasNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FechaEntregaDateTimePicker.Value = FechaInicioDateTimePicker.Value.AddDays(Convert.ToInt32(DiasNumericUpDown.Value));
            TotalNumericUpDown.Value = DiasNumericUpDown.Value * PrecioNumericUpDown.Value;
        }

        private void PrecioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TotalNumericUpDown.Value = DiasNumericUpDown.Value * PrecioNumericUpDown.Value;
        }
    }
}
