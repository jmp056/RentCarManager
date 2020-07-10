namespace RentCarManager.UI.Consultas
{
    partial class cRentas
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
            this.RentasDataGridView = new System.Windows.Forms.DataGridView();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DataGridViewGroupBox = new System.Windows.Forms.GroupBox();
            this.ConsultaGroupBox = new System.Windows.Forms.GroupBox();
            this.SeleccionarButton = new System.Windows.Forms.Button();
            this.HastaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DesdeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RentasDataGridView)).BeginInit();
            this.DataGridViewGroupBox.SuspendLayout();
            this.ConsultaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RentasDataGridView
            // 
            this.RentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentasDataGridView.Location = new System.Drawing.Point(5, 10);
            this.RentasDataGridView.Name = "RentasDataGridView";
            this.RentasDataGridView.Size = new System.Drawing.Size(807, 269);
            this.RentasDataGridView.TabIndex = 0;
            this.RentasDataGridView.DoubleClick += new System.EventHandler(this.RentasDataGridView_DoubleClick);
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(10, 190);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(127, 22);
            this.HastaDateTimePicker.TabIndex = 31;
            this.HastaDateTimePicker.ValueChanged += new System.EventHandler(this.HastaDateTimePicker_ValueChanged);
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(10, 115);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(127, 22);
            this.DesdeDateTimePicker.TabIndex = 28;
            this.DesdeDateTimePicker.ValueChanged += new System.EventHandler(this.DesdeDateTimePicker_ValueChanged);
            // 
            // DataGridViewGroupBox
            // 
            this.DataGridViewGroupBox.Controls.Add(this.RentasDataGridView);
            this.DataGridViewGroupBox.Location = new System.Drawing.Point(170, 0);
            this.DataGridViewGroupBox.Name = "DataGridViewGroupBox";
            this.DataGridViewGroupBox.Size = new System.Drawing.Size(819, 285);
            this.DataGridViewGroupBox.TabIndex = 2;
            this.DataGridViewGroupBox.TabStop = false;
            // 
            // ConsultaGroupBox
            // 
            this.ConsultaGroupBox.Controls.Add(this.SeleccionarButton);
            this.ConsultaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.ConsultaGroupBox.Controls.Add(this.HastaNumericUpDown);
            this.ConsultaGroupBox.Controls.Add(this.DesdeNumericUpDown);
            this.ConsultaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.ConsultaGroupBox.Controls.Add(this.CriterioTextBox);
            this.ConsultaGroupBox.Controls.Add(this.HastaLabel);
            this.ConsultaGroupBox.Controls.Add(this.DesdeLabel);
            this.ConsultaGroupBox.Controls.Add(this.FiltroComboBox);
            this.ConsultaGroupBox.Controls.Add(this.FiltroLabel);
            this.ConsultaGroupBox.Location = new System.Drawing.Point(7, 0);
            this.ConsultaGroupBox.Name = "ConsultaGroupBox";
            this.ConsultaGroupBox.Size = new System.Drawing.Size(162, 285);
            this.ConsultaGroupBox.TabIndex = 32;
            this.ConsultaGroupBox.TabStop = false;
            // 
            // SeleccionarButton
            // 
            this.SeleccionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarButton.Location = new System.Drawing.Point(7, 232);
            this.SeleccionarButton.Name = "SeleccionarButton";
            this.SeleccionarButton.Size = new System.Drawing.Size(130, 37);
            this.SeleccionarButton.TabIndex = 37;
            this.SeleccionarButton.Text = "Seleccionar";
            this.SeleccionarButton.UseVisualStyleBackColor = true;
            this.SeleccionarButton.Click += new System.EventHandler(this.SeleccionarButton_Click);
            // 
            // HastaNumericUpDown
            // 
            this.HastaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaNumericUpDown.Location = new System.Drawing.Point(13, 190);
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
            "Nombre del cliente",
            "Celular",
            "Fecha de registro",
            "Marca",
            "Modelo",
            "Version",
            "Año",
            "Placa"});
            this.FiltroComboBox.Location = new System.Drawing.Point(10, 45);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(130, 24);
            this.FiltroComboBox.TabIndex = 27;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged_1);
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
            // cRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 294);
            this.Controls.Add(this.ConsultaGroupBox);
            this.Controls.Add(this.DataGridViewGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "cRentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de rentas";
            this.Activated += new System.EventHandler(this.cRentas_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.RentasDataGridView)).EndInit();
            this.DataGridViewGroupBox.ResumeLayout(false);
            this.ConsultaGroupBox.ResumeLayout(false);
            this.ConsultaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesdeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RentasDataGridView;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.GroupBox DataGridViewGroupBox;
        private System.Windows.Forms.GroupBox ConsultaGroupBox;
        private System.Windows.Forms.Button SeleccionarButton;
        private System.Windows.Forms.NumericUpDown HastaNumericUpDown;
        private System.Windows.Forms.NumericUpDown DesdeNumericUpDown;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
    }
}