using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ingreso ingresoForm = new ingreso();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Usuario: " + InformacionUsuario.nombreUsuario;            
        }

        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ingreso ingresoForm = new ingreso();
            ingresoForm.ShowDialog();
        }

        private void agregarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ingreso ingresoForm = new ingreso();
            ingresoForm.ShowDialog();         
        }
    }
}
