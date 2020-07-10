namespace RentCarManager
{
    partial class MainForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeRentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeRentasToolStripMenuItem,
            this.registroDeVehiculosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeRentasToolStripMenuItem
            // 
            this.registroDeRentasToolStripMenuItem.Name = "registroDeRentasToolStripMenuItem";
            this.registroDeRentasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registroDeRentasToolStripMenuItem.Text = "Registro de rentas";
            this.registroDeRentasToolStripMenuItem.Click += new System.EventHandler(this.registroDeRentasToolStripMenuItem_Click);
            // 
            // registroDeVehiculosToolStripMenuItem
            // 
            this.registroDeVehiculosToolStripMenuItem.Name = "registroDeVehiculosToolStripMenuItem";
            this.registroDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.registroDeVehiculosToolStripMenuItem.Text = "Registro de vehiculos";
            this.registroDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.registroDeVehiculosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeRentasToolStripMenuItem,
            this.consultaDeVehiculosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeRentasToolStripMenuItem
            // 
            this.consultaDeRentasToolStripMenuItem.Name = "consultaDeRentasToolStripMenuItem";
            this.consultaDeRentasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultaDeRentasToolStripMenuItem.Text = "Consulta de rentas";
            this.consultaDeRentasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeRentasToolStripMenuItem_Click);
            // 
            // consultaDeVehiculosToolStripMenuItem
            // 
            this.consultaDeVehiculosToolStripMenuItem.Name = "consultaDeVehiculosToolStripMenuItem";
            this.consultaDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultaDeVehiculosToolStripMenuItem.Text = "Consulta de vehiculos";
            this.consultaDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVehiculosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Car Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeRentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeRentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVehiculosToolStripMenuItem;
    }
}

