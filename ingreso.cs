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
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }

        DataTable dataTable         = new DataTable();
        DataTable dataTableProducto = new DataTable();
        int contadorDGV = 0;
        private void ingreso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.cliente' Puede moverla o quitarla según sea necesario.
            //this.clienteTableAdapter.Fill(this.database1DataSet.cliente);

            comboBox1.DataSource = dataTable = ClassDA.Mostrar();
            cmbProducto.DataSource = dataTableProducto = ClassDA.MostrarProducto();

            comboBox1.DisplayMember = "nombreCliente";          
            comboBox1.ValueMember = "idCliente";

            cmbProducto.DisplayMember = "nombre";
            cmbProducto.ValueMember = "idProducto";            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try {

            }
            catch {

            }
        }      

        private void comboBox1_Click(object sender, EventArgs e)
        {
            int seleccionado = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            txtNombreCliente.Text = dataTable.Rows[seleccionado][1].ToString();
            txtDireccionCliente.Text = dataTable.Rows[seleccionado][2].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int seleccionado = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
                txtNombreCliente.Text = dataTable.Rows[seleccionado][1].ToString();
                txtDireccionCliente.Text = dataTable.Rows[seleccionado][2].ToString();
            } 
            catch { }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            int seleccionado = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            txtNombreCliente.Text = dataTable.Rows[seleccionado][1].ToString();
            txtDireccionCliente.Text = dataTable.Rows[seleccionado][2].ToString();
        }

        private void cmbProducto_Leave(object sender, EventArgs e)
        {
            int seleccionado = int.Parse(cmbProducto.SelectedValue.ToString()) - 1;
            txtNombreProducto.Text = dataTableProducto.Rows[seleccionado][1].ToString();
            txtDescripcionProducto.Text = dataTableProducto.Rows[seleccionado][2].ToString();
            txtPrecioProducto.Text = dataTableProducto.Rows[seleccionado][3].ToString();
        }

        private void cmbProducto_Click(object sender, EventArgs e)
        {
            int seleccionado = int.Parse(cmbProducto.SelectedValue.ToString()) - 1;
            txtNombreProducto.Text = dataTableProducto.Rows[seleccionado][1].ToString();
            txtDescripcionProducto.Text = dataTableProducto.Rows[seleccionado][2].ToString();
            txtPrecioProducto.Text = dataTableProducto.Rows[seleccionado][3].ToString();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int seleccionado = int.Parse(cmbProducto.SelectedValue.ToString()) - 1;
                txtNombreProducto.Text = dataTableProducto.Rows[seleccionado][1].ToString();
                txtDescripcionProducto.Text = dataTableProducto.Rows[seleccionado][2].ToString();
                txtPrecioProducto.Text = dataTableProducto.Rows[seleccionado][3].ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            contadorDGV++;
            /*
            int? userVal;
            if (int.TryParse(txtPrecioProducto.Text), out userVal)
            {

            }
            */
            decimal total;
            total = decimal.Parse(txtPrecioProducto.Text) * decimal.Parse(txtCantidadProductos.Text);
            dgwDetalle.Rows.Add(contadorDGV.ToString(), txtNombreProducto.Text, txtPrecioProducto.Text, txtCantidadProductos.Text, total.ToString(), "x");
        }

        private void txtCantidadProductos_Validating(object sender, CancelEventArgs e)
        {
            uint i;
            if (string.IsNullOrEmpty(txtCantidadProductos.Text))
            {
                e.Cancel = true;
            }
            else
            {                
                if (!uint.TryParse(txtCantidadProductos.Text, out i))
                {
                    e.Cancel= true;
                }
                else
                {
                    int cero;
                    cero = int.Parse(txtCantidadProductos.Text);
                    if (cero == 0)
                        e.Cancel= true;
                }
            }
            if (e.Cancel)
                MessageBox.Show("Debe ingresar una cantidad entera y distinta de cero.");
        }
    }
}
