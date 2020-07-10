namespace RentCarManager.UI.Registros
{
    partial class rVehiculos
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
            this.ChasisTextBox = new System.Windows.Forms.TextBox();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChasisLabel = new System.Windows.Forms.Label();
            this.MatriculaLabel = new System.Windows.Forms.Label();
            this.PlacaLabel = new System.Windows.Forms.Label();
            this.MarcaLabel = new System.Windows.Forms.Label();
            this.ModeloLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AnoFabricacionLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MatriculaTextBox = new System.Windows.Forms.TextBox();
            this.PlacaTextBox = new System.Windows.Forms.TextBox();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.ModeloTextBox = new System.Windows.Forms.TextBox();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.AnoFabricacionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnoFabricacionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChasisTextBox
            // 
            this.ChasisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChasisTextBox.Location = new System.Drawing.Point(110, 23);
            this.ChasisTextBox.Name = "ChasisTextBox";
            this.ChasisTextBox.Size = new System.Drawing.Size(136, 22);
            this.ChasisTextBox.TabIndex = 1;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.DecimalPlaces = 2;
            this.PrecioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(365, 128);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(136, 22);
            this.PrecioNumericUpDown.TabIndex = 3;
            // 
            // ChasisLabel
            // 
            this.ChasisLabel.AutoSize = true;
            this.ChasisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChasisLabel.Location = new System.Drawing.Point(20, 25);
            this.ChasisLabel.Name = "ChasisLabel";
            this.ChasisLabel.Size = new System.Drawing.Size(83, 16);
            this.ChasisLabel.TabIndex = 4;
            this.ChasisLabel.Text = "No. Chasis";
            // 
            // MatriculaLabel
            // 
            this.MatriculaLabel.AutoSize = true;
            this.MatriculaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaLabel.Location = new System.Drawing.Point(275, 25);
            this.MatriculaLabel.Name = "MatriculaLabel";
            this.MatriculaLabel.Size = new System.Drawing.Size(71, 16);
            this.MatriculaLabel.TabIndex = 5;
            this.MatriculaLabel.Text = "Matricula";
            // 
            // PlacaLabel
            // 
            this.PlacaLabel.AutoSize = true;
            this.PlacaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaLabel.Location = new System.Drawing.Point(20, 60);
            this.PlacaLabel.Name = "PlacaLabel";
            this.PlacaLabel.Size = new System.Drawing.Size(48, 16);
            this.PlacaLabel.TabIndex = 6;
            this.PlacaLabel.Text = "Placa";
            // 
            // MarcaLabel
            // 
            this.MarcaLabel.AutoSize = true;
            this.MarcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaLabel.Location = new System.Drawing.Point(275, 60);
            this.MarcaLabel.Name = "MarcaLabel";
            this.MarcaLabel.Size = new System.Drawing.Size(51, 16);
            this.MarcaLabel.TabIndex = 7;
            this.MarcaLabel.Text = "Marca";
            // 
            // ModeloLabel
            // 
            this.ModeloLabel.AutoSize = true;
            this.ModeloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloLabel.Location = new System.Drawing.Point(20, 95);
            this.ModeloLabel.Name = "ModeloLabel";
            this.ModeloLabel.Size = new System.Drawing.Size(60, 16);
            this.ModeloLabel.TabIndex = 8;
            this.ModeloLabel.Text = "Modelo";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(275, 95);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(61, 16);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "Versión";
            // 
            // AnoFabricacionLabel
            // 
            this.AnoFabricacionLabel.AutoSize = true;
            this.AnoFabricacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoFabricacionLabel.Location = new System.Drawing.Point(20, 130);
            this.AnoFabricacionLabel.Name = "AnoFabricacionLabel";
            this.AnoFabricacionLabel.Size = new System.Drawing.Size(35, 16);
            this.AnoFabricacionLabel.TabIndex = 10;
            this.AnoFabricacionLabel.Text = "Año";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.Location = new System.Drawing.Point(275, 130);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(53, 16);
            this.PrecioLabel.TabIndex = 11;
            this.PrecioLabel.Text = "Precio";
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoLabel.Location = new System.Drawing.Point(20, 163);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(57, 16);
            this.EstadoLabel.TabIndex = 12;
            this.EstadoLabel.Text = "Estado";
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(23, 208);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 35);
            this.LimpiarButton.TabIndex = 13;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(213, 208);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 35);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(401, 208);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 35);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MatriculaTextBox
            // 
            this.MatriculaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaTextBox.Location = new System.Drawing.Point(365, 23);
            this.MatriculaTextBox.Name = "MatriculaTextBox";
            this.MatriculaTextBox.Size = new System.Drawing.Size(136, 22);
            this.MatriculaTextBox.TabIndex = 16;
            // 
            // PlacaTextBox
            // 
            this.PlacaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacaTextBox.Location = new System.Drawing.Point(110, 58);
            this.PlacaTextBox.Name = "PlacaTextBox";
            this.PlacaTextBox.Size = new System.Drawing.Size(136, 22);
            this.PlacaTextBox.TabIndex = 17;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaTextBox.Location = new System.Drawing.Point(365, 58);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(136, 22);
            this.MarcaTextBox.TabIndex = 18;
            // 
            // ModeloTextBox
            // 
            this.ModeloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloTextBox.Location = new System.Drawing.Point(110, 93);
            this.ModeloTextBox.Name = "ModeloTextBox";
            this.ModeloTextBox.Size = new System.Drawing.Size(136, 22);
            this.ModeloTextBox.TabIndex = 19;
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionTextBox.Location = new System.Drawing.Point(365, 93);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(136, 22);
            this.VersionTextBox.TabIndex = 20;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Disponible",
            "Rentado",
            "En reparacion",
            "No disponible"});
            this.EstadoComboBox.Location = new System.Drawing.Point(110, 161);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(136, 24);
            this.EstadoComboBox.TabIndex = 21;
            // 
            // AnoFabricacionNumericUpDown
            // 
            this.AnoFabricacionNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnoFabricacionNumericUpDown.Location = new System.Drawing.Point(110, 128);
            this.AnoFabricacionNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.AnoFabricacionNumericUpDown.Name = "AnoFabricacionNumericUpDown";
            this.AnoFabricacionNumericUpDown.Size = new System.Drawing.Size(136, 22);
            this.AnoFabricacionNumericUpDown.TabIndex = 22;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 264);
            this.Controls.Add(this.AnoFabricacionNumericUpDown);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(this.VersionTextBox);
            this.Controls.Add(this.ModeloTextBox);
            this.Controls.Add(this.MarcaTextBox);
            this.Controls.Add(this.PlacaTextBox);
            this.Controls.Add(this.MatriculaTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.EstadoLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.AnoFabricacionLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ModeloLabel);
            this.Controls.Add(this.MarcaLabel);
            this.Controls.Add(this.PlacaLabel);
            this.Controls.Add(this.MatriculaLabel);
            this.Controls.Add(this.ChasisLabel);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.ChasisTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "rVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de vehiculos";
            this.Load += new System.EventHandler(this.rVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnoFabricacionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ChasisTextBox;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label ChasisLabel;
        private System.Windows.Forms.Label MatriculaLabel;
        private System.Windows.Forms.Label PlacaLabel;
        private System.Windows.Forms.Label MarcaLabel;
        private System.Windows.Forms.Label ModeloLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AnoFabricacionLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox MatriculaTextBox;
        private System.Windows.Forms.TextBox PlacaTextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox ModeloTextBox;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.NumericUpDown AnoFabricacionNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}