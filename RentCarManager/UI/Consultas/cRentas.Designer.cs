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
            this.ConsultaGroupBox = new System.Windows.Forms.GroupBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.DataGridViewGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.RentasDataGridView)).BeginInit();
            this.ConsultaGroupBox.SuspendLayout();
            this.DataGridViewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RentasDataGridView
            // 
            this.RentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentasDataGridView.Location = new System.Drawing.Point(5, 10);
            this.RentasDataGridView.Name = "RentasDataGridView";
            this.RentasDataGridView.Size = new System.Drawing.Size(577, 388);
            this.RentasDataGridView.TabIndex = 0;
            // 
            // ConsultaGroupBox
            // 
            this.ConsultaGroupBox.Controls.Add(this.CriterioTextBox);
            this.ConsultaGroupBox.Controls.Add(this.HastaDateTimePicker);
            this.ConsultaGroupBox.Controls.Add(this.HastaLabel);
            this.ConsultaGroupBox.Controls.Add(this.DesdeLabel);
            this.ConsultaGroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.ConsultaGroupBox.Controls.Add(this.FiltroComboBox);
            this.ConsultaGroupBox.Controls.Add(this.FiltroLabel);
            this.ConsultaGroupBox.Location = new System.Drawing.Point(5, 0);
            this.ConsultaGroupBox.Name = "ConsultaGroupBox";
            this.ConsultaGroupBox.Size = new System.Drawing.Size(162, 279);
            this.ConsultaGroupBox.TabIndex = 1;
            this.ConsultaGroupBox.TabStop = false;
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(5, 10);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(63, 16);
            this.FiltroLabel.TabIndex = 26;
            this.FiltroLabel.Text = "Nombre";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(6, 29);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltroComboBox.TabIndex = 27;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(29, 108);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.DesdeDateTimePicker.TabIndex = 28;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.Location = new System.Drawing.Point(6, 76);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(63, 16);
            this.DesdeLabel.TabIndex = 29;
            this.DesdeLabel.Text = "Nombre";
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.Location = new System.Drawing.Point(7, 166);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(63, 16);
            this.HastaLabel.TabIndex = 30;
            this.HastaLabel.Text = "Nombre";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(38, 205);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.HastaDateTimePicker.TabIndex = 31;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(36, 124);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(100, 22);
            this.CriterioTextBox.TabIndex = 32;
            // 
            // DataGridViewGroupBox
            // 
            this.DataGridViewGroupBox.Controls.Add(this.RentasDataGridView);
            this.DataGridViewGroupBox.Location = new System.Drawing.Point(170, 0);
            this.DataGridViewGroupBox.Name = "DataGridViewGroupBox";
            this.DataGridViewGroupBox.Size = new System.Drawing.Size(588, 405);
            this.DataGridViewGroupBox.TabIndex = 2;
            this.DataGridViewGroupBox.TabStop = false;
            // 
            // cRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewGroupBox);
            this.Controls.Add(this.ConsultaGroupBox);
            this.Name = "cRentas";
            this.Text = "cRentas";
            ((System.ComponentModel.ISupportInitialize)(this.RentasDataGridView)).EndInit();
            this.ConsultaGroupBox.ResumeLayout(false);
            this.ConsultaGroupBox.PerformLayout();
            this.DataGridViewGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RentasDataGridView;
        private System.Windows.Forms.GroupBox ConsultaGroupBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.GroupBox DataGridViewGroupBox;
    }
}