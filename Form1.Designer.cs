namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem1,
            this.reportesToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ingresoToolStripMenuItem.Text = "Menú";
            // 
            // ingresoToolStripMenuItem1
            // 
            this.ingresoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarFacturaToolStripMenuItem,
            this.eliminarFacturaToolStripMenuItem});
            this.ingresoToolStripMenuItem1.Name = "ingresoToolStripMenuItem1";
            this.ingresoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ingresoToolStripMenuItem1.Text = "Ingreso";
            this.ingresoToolStripMenuItem1.Click += new System.EventHandler(this.ingresoToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salidaToolStripMenuItem.Text = "Salida";
            // 
            // agregarFacturaToolStripMenuItem
            // 
            this.agregarFacturaToolStripMenuItem.Name = "agregarFacturaToolStripMenuItem";
            this.agregarFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarFacturaToolStripMenuItem.Text = "Agregar factura";
            this.agregarFacturaToolStripMenuItem.Click += new System.EventHandler(this.agregarFacturaToolStripMenuItem_Click);
            // 
            // eliminarFacturaToolStripMenuItem
            // 
            this.eliminarFacturaToolStripMenuItem.Name = "eliminarFacturaToolStripMenuItem";
            this.eliminarFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarFacturaToolStripMenuItem.Text = "Eliminar factura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFacturaToolStripMenuItem;
    }
}