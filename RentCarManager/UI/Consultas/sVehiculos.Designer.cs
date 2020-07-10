namespace RentCarManager.UI.Consultas
{
    partial class sVehiculos
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
            this.DataGridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.VehiculosDataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultaGroupBox = new System.Windows.Forms.GroupBox();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.DataGridViewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDataGridView)).BeginInit();
            this.ConsultaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewGroupBox
            // 
            this.DataGridViewGroupBox.Controls.Add(this.VehiculosDataGridView);
            this.DataGridViewGroupBox.Location = new System.Drawing.Point(170, 0);
            this.DataGridViewGroupBox.Name = "DataGridViewGroupBox";
            this.DataGridViewGroupBox.Size = new System.Drawing.Size(641, 288);
            this.DataGridViewGroupBox.TabIndex = 4;
            this.DataGridViewGroupBox.TabStop = false;
            // 
            // VehiculosDataGridView
            // 
            this.VehiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDataGridView.Location = new System.Drawing.Point(5, 10);
            this.VehiculosDataGridView.Name = "VehiculosDataGridView";
            this.VehiculosDataGridView.ReadOnly = true;
            this.VehiculosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiculosDataGridView.Size = new System.Drawing.Size(628, 271);
            this.VehiculosDataGridView.TabIndex = 0;
            this.VehiculosDataGridView.DoubleClick += new System.EventHandler(this.VehiculosDataGridView_DoubleClick);
            // 
            // ConsultaGroupBox
            // 
            this.ConsultaGroupBox.Controls.Add(this.SeleccionarButton);
            this.ConsultaGroupBox.Controls.Add(this.HastaNumericUpDown);
            this.ConsultaGroupBox.Controls.Add(this.DesdeNumericUpDown);
            this.ConsultaGroupBox.Controls.Add(this.CriterioTextBox);
            this.ConsultaGroupBox.Controls.Add(this.HastaLabel);
            this.ConsultaGroupBox.Controls.Add(this.DesdeLabel);
            this.ConsultaGroupBox.Controls.Add(this.FiltroComboBox);
            this.ConsultaGroupBox.Controls.Add(this.FiltroLabel);
            this.ConsultaGroupBox.Location = new System.Drawing.Point(5, 0);
            this.ConsultaGroupBox.Name = "ConsultaGroupBox";
            this.ConsultaGroupBox.Size = new System.Drawing.Size(162, 288);
            this.ConsultaGroupBox.TabIndex = 3;
            this.ConsultaGroupBox.TabStop = false;
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarButton.Location = new System.Drawing.Point(10, 233);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(130, 37);
            this.SeleccionarButton.TabIndex = 36;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            this.SeleccionarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaNumericUpDown
            // 
            this.HastaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaNumericUpDown.Location = new System.Drawing.Point(10, 190);
            this.HastaNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.HastaNumericUpDown.Name = "HastaNumericUpDown";
            this.HastaNumericUpDown.Size = new System.Drawing.Size(130, 22);
            this.HastaNumericUpDown.TabIndex = 35;
            this.HastaNumericUpDown.ValueChanged += new System.EventHandler(this.HastaNumericUpDown_ValueChanged);
            // 
            // DesdeNumericUpDown
            // 
            this.DesdeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeNumericUpDown.Location = new System.Drawing.Point(10, 115);
            this.DesdeNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.DesdeNumericUpDown.Name = "DesdeNumericUpDown";
            this.DesdeNumericUpDown.Size = new System.Drawing.Size(130, 22);
            this.DesdeNumericUpDown.TabIndex = 34;
            this.DesdeNumericUpDown.ValueChanged += new System.EventHandler(this.DesdeNumericUpDown_ValueChanged);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(10, 115);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(130, 22);
            this.CriterioTextBox.TabIndex = 32;
            this.CriterioTextBox.TextChanged += new System.EventHandler(this.CriterioTextBox_TextChanged);
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.Location = new System.Drawing.Point(10, 160);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(49, 16);
            this.HastaLabel.TabIndex = 30;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.Location = new System.Drawing.Point(10, 90);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(54, 16);
            this.DesdeLabel.TabIndex = 29;
            this.DesdeLabel.Text = "Desde";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Marca",
            "Modelo",
            "Version",
            "Año de fabricacion",
            "Placa",
            "Precio"});
            this.FiltroComboBox.Location = new System.Drawing.Point(10, 45);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(130, 24);
            this.FiltroComboBox.TabIndex = 27;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(10, 20);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(43, 16);
            this.FiltroLabel.TabIndex = 26;
            this.FiltroLabel.Text = "Filtro";
            // 
            // sVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 295);
            this.Controls.Add(this.DataGridViewGroupBox);
            this.Controls.Add(this.ConsultaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "sVehiculos";
            this.Text = "Consulta de Vehiculos";
            this.Activated += new System.EventHandler(this.cVehiculos_Activated);
            this.DataGridViewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDataGridView)).EndInit();
            this.ConsultaGroupBox.ResumeLayout(false);
            this.ConsultaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DataGridViewGroupBox;
        private System.Windows.Forms.GroupBox ConsultaGroupBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
        private System.Windows.Forms.DataGridView VehiculosDataGridView;
        private System.Windows.Forms.Button SeleccionarButton;
    }
}