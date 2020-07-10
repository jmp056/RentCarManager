namespace RentCarManager.UI.Registros
{
    partial class rRentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VehiculoTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.DiasLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.VehiculoLabel = new System.Windows.Forms.Label();
            this.DireccionLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DiasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FechaRegistroLabel = new System.Windows.Forms.Label();
            this.FechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaInicioLabel = new System.Windows.Forms.Label();
            this.FechaEntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaEntregaLlabel = new System.Windows.Forms.Label();
            this.TotalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Totallabel = new System.Windows.Forms.Label();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RentaGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.RentaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.DecimalPlaces = 2;
            this.PrecioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(80, 123);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(147, 22);
            this.PrecioNumericUpDown.TabIndex = 100;
            this.PrecioNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioNumericUpDown_ValueChanged);
            // 
            // VehiculoTextBox
            // 
            this.VehiculoTextBox.Enabled = false;
            this.VehiculoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculoTextBox.Location = new System.Drawing.Point(80, 88);
            this.VehiculoTextBox.Name = "VehiculoTextBox";
            this.VehiculoTextBox.Size = new System.Drawing.Size(217, 22);
            this.VehiculoTextBox.TabIndex = 140;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextBox.Location = new System.Drawing.Point(105, 58);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(232, 22);
            this.DireccionTextBox.TabIndex = 30;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(398, 280);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 130;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(217, 280);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 110;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(28, 280);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 120;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // DiasLabel
            // 
            this.DiasLabel.AutoSize = true;
            this.DiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasLabel.Location = new System.Drawing.Point(240, 20);
            this.DiasLabel.Name = "DiasLabel";
            this.DiasLabel.Size = new System.Drawing.Size(40, 16);
            this.DiasLabel.TabIndex = 32;
            this.DiasLabel.Text = "Días";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(5, 125);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(53, 16);
            this.PrecioLabel.TabIndex = 31;
            this.PrecioLabel.Text = "Precio";
            // 
            // VehiculoLabel
            // 
            this.VehiculoLabel.AutoSize = true;
            this.VehiculoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculoLabel.Location = new System.Drawing.Point(5, 90);
            this.VehiculoLabel.Name = "VehiculoLabel";
            this.VehiculoLabel.Size = new System.Drawing.Size(68, 16);
            this.VehiculoLabel.TabIndex = 29;
            this.VehiculoLabel.Text = "Vehículo";
            // 
            // DireccionLabel
            // 
            this.DireccionLabel.AutoSize = true;
            this.DireccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionLabel.Location = new System.Drawing.Point(20, 60);
            this.DireccionLabel.Name = "DireccionLabel";
            this.DireccionLabel.Size = new System.Drawing.Size(74, 16);
            this.DireccionLabel.TabIndex = 28;
            this.DireccionLabel.Text = "Dirección";
            // 
            // CelularLabel
            // 
            this.CelularLabel.AutoSize = true;
            this.CelularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.Location = new System.Drawing.Point(350, 25);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(57, 16);
            this.CelularLabel.TabIndex = 27;
            this.CelularLabel.Text = "Celular";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(350, 60);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(57, 16);
            this.CedulaLabel.TabIndex = 26;
            this.CedulaLabel.Text = "Cedula";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(20, 25);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(63, 16);
            this.NombreLabel.TabIndex = 25;
            this.NombreLabel.Text = "Nombre";
            // 
            // DiasNumericUpDown
            // 
            this.DiasNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasNumericUpDown.Location = new System.Drawing.Point(290, 18);
            this.DiasNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.DiasNumericUpDown.Name = "DiasNumericUpDown";
            this.DiasNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DiasNumericUpDown.TabIndex = 60;
            this.DiasNumericUpDown.ValueChanged += new System.EventHandler(this.DiasNumericUpDown_ValueChanged);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(105, 23);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(232, 22);
            this.NombreTextBox.TabIndex = 10;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(415, 58);
            this.CedulaMaskedTextBox.Mask = "999-9999999-9";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(83, 20);
            this.CedulaMaskedTextBox.TabIndex = 40;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(415, 23);
            this.CelularMaskedTextBox.Mask = "999-999-9999";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(83, 20);
            this.CelularMaskedTextBox.TabIndex = 20;
            // 
            // FechaRegistroLabel
            // 
            this.FechaRegistroLabel.AutoSize = true;
            this.FechaRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRegistroLabel.Location = new System.Drawing.Point(5, 20);
            this.FechaRegistroLabel.Name = "FechaRegistroLabel";
            this.FechaRegistroLabel.Size = new System.Drawing.Size(130, 16);
            this.FechaRegistroLabel.TabIndex = 46;
            this.FechaRegistroLabel.Text = "Fecha de registro";
            // 
            // FechaRegistroDateTimePicker
            // 
            this.FechaRegistroDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaRegistroDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaRegistroDateTimePicker.Location = new System.Drawing.Point(140, 18);
            this.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker";
            this.FechaRegistroDateTimePicker.Size = new System.Drawing.Size(87, 22);
            this.FechaRegistroDateTimePicker.TabIndex = 50;
            // 
            // FechaInicioDateTimePicker
            // 
            this.FechaInicioDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaInicioDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaInicioDateTimePicker.Location = new System.Drawing.Point(140, 53);
            this.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            this.FechaInicioDateTimePicker.Size = new System.Drawing.Size(87, 22);
            this.FechaInicioDateTimePicker.TabIndex = 70;
            this.FechaInicioDateTimePicker.ValueChanged += new System.EventHandler(this.FechaInicioDateTimePicker_ValueChanged);
            // 
            // FechaInicioLabel
            // 
            this.FechaInicioLabel.AutoSize = true;
            this.FechaInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicioLabel.Location = new System.Drawing.Point(5, 55);
            this.FechaInicioLabel.Name = "FechaInicioLabel";
            this.FechaInicioLabel.Size = new System.Drawing.Size(114, 16);
            this.FechaInicioLabel.TabIndex = 48;
            this.FechaInicioLabel.Text = "Fecha de inicio";
            // 
            // FechaEntregaDateTimePicker
            // 
            this.FechaEntregaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaEntregaDateTimePicker.Enabled = false;
            this.FechaEntregaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaEntregaDateTimePicker.Location = new System.Drawing.Point(380, 53);
            this.FechaEntregaDateTimePicker.Name = "FechaEntregaDateTimePicker";
            this.FechaEntregaDateTimePicker.Size = new System.Drawing.Size(87, 22);
            this.FechaEntregaDateTimePicker.TabIndex = 80;
            // 
            // FechaEntregaLlabel
            // 
            this.FechaEntregaLlabel.AutoSize = true;
            this.FechaEntregaLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEntregaLlabel.Location = new System.Drawing.Point(240, 55);
            this.FechaEntregaLlabel.Name = "FechaEntregaLlabel";
            this.FechaEntregaLlabel.Size = new System.Drawing.Size(130, 16);
            this.FechaEntregaLlabel.TabIndex = 50;
            this.FechaEntregaLlabel.Text = "Fecha de entrega";
            // 
            // TotalNumericUpDown
            // 
            this.TotalNumericUpDown.DecimalPlaces = 2;
            this.TotalNumericUpDown.Enabled = false;
            this.TotalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNumericUpDown.Location = new System.Drawing.Point(290, 123);
            this.TotalNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.TotalNumericUpDown.Name = "TotalNumericUpDown";
            this.TotalNumericUpDown.Size = new System.Drawing.Size(177, 22);
            this.TotalNumericUpDown.TabIndex = 150;
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(240, 125);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(44, 16);
            this.Totallabel.TabIndex = 52;
            this.Totallabel.Text = "Total";
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarButton.Location = new System.Drawing.Point(303, 85);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(164, 29);
            this.SeleccionarButton.TabIndex = 90;
            this.SeleccionarButton.Text = "Seleccionar vehiculo";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RentaGroupBox
            // 
            this.RentaGroupBox.Controls.Add(this.FechaRegistroLabel);
            this.RentaGroupBox.Controls.Add(this.TotalNumericUpDown);
            this.RentaGroupBox.Controls.Add(this.Totallabel);
            this.RentaGroupBox.Controls.Add(this.SeleccionarButton);
            this.RentaGroupBox.Controls.Add(this.FechaRegistroDateTimePicker);
            this.RentaGroupBox.Controls.Add(this.DiasLabel);
            this.RentaGroupBox.Controls.Add(this.PrecioNumericUpDown);
            this.RentaGroupBox.Controls.Add(this.DiasNumericUpDown);
            this.RentaGroupBox.Controls.Add(this.FechaEntregaDateTimePicker);
            this.RentaGroupBox.Controls.Add(this.FechaInicioLabel);
            this.RentaGroupBox.Controls.Add(this.FechaEntregaLlabel);
            this.RentaGroupBox.Controls.Add(this.VehiculoTextBox);
            this.RentaGroupBox.Controls.Add(this.PrecioLabel);
            this.RentaGroupBox.Controls.Add(this.FechaInicioDateTimePicker);
            this.RentaGroupBox.Controls.Add(this.VehiculoLabel);
            this.RentaGroupBox.Location = new System.Drawing.Point(20, 95);
            this.RentaGroupBox.Name = "RentaGroupBox";
            this.RentaGroupBox.Size = new System.Drawing.Size(478, 163);
            this.RentaGroupBox.TabIndex = 45;
            this.RentaGroupBox.TabStop = false;
            // 
            // rRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 333);
            this.Controls.Add(this.RentaGroupBox);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.DireccionLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.NombreTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rRentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Rentas";
            this.Load += new System.EventHandler(this.rRentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.RentaGroupBox.ResumeLayout(false);
            this.RentaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.TextBox VehiculoTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label DiasLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label VehiculoLabel;
        private System.Windows.Forms.Label DireccionLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.NumericUpDown DiasNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.Label FechaRegistroLabel;
        private System.Windows.Forms.DateTimePicker FechaRegistroDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaInicioDateTimePicker;
        private System.Windows.Forms.Label FechaInicioLabel;
        private System.Windows.Forms.DateTimePicker FechaEntregaDateTimePicker;
        private System.Windows.Forms.Label FechaEntregaLlabel;
        private System.Windows.Forms.NumericUpDown TotalNumericUpDown;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox RentaGroupBox;
    }
}