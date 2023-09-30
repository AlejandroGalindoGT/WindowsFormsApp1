using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        decimal totalFactura = 0;
        int idCliente = 0;
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

        private void comboBox1_Click(object sender, EventArgs e)
        {
            int seleccionado = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            idCliente = seleccionado + 1;
            txtNombreCliente.Text = dataTable.Rows[seleccionado][1].ToString();
            txtDireccionCliente.Text = dataTable.Rows[seleccionado][2].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int seleccionado = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
                idCliente = seleccionado + 1;
                txtNombreCliente.Text = dataTable.Rows[seleccionado][1].ToString();
                txtDireccionCliente.Text = dataTable.Rows[seleccionado][2].ToString();
            } 
            catch { }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            int seleccionado = int.Parse(comboBox1.SelectedValue.ToString()) - 1;
            idCliente = seleccionado + 1;
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
            decimal total = 0;
          
            total = decimal.Parse(txtPrecioProducto.Text) * decimal.Parse(txtCantidadProductos.Text);

            if (contadorDGV == 1)
            {
                dgwDetalle.Rows.Add(contadorDGV.ToString(), txtNombreProducto.Text, txtPrecioProducto.Text, txtCantidadProductos.Text, total.ToString(), "x");
                totalFactura = totalFactura + total;               
                dgwDetalle.Rows.Add(" ", " ", " ", "Total", totalFactura.ToString());                
            }
            else
            {
                dgwDetalle.Rows.RemoveAt(contadorDGV - 1);
                dgwDetalle.Rows.Add(contadorDGV.ToString(), txtNombreProducto.Text, txtPrecioProducto.Text, txtCantidadProductos.Text, total.ToString(), "x");
                totalFactura = totalFactura + total;                
                dgwDetalle.Rows.Add(" ", " ", " ", "Total", totalFactura.ToString());
            }

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

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            // Validar que haya productos ingresados
            if (totalFactura != 0)
            {
                if (idCliente != 0)
                {

                }
                SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oagalindo\Documents\me\2023\p\app\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
                SqlCommand command = new SqlCommand(@"INSERT INTO Factura (idCliente, totalFactura, fechaFactura)
                    VALUES(@idCliente, @totalFactura, @fechaFactura)", conexion);
                conexion.Open();
                command.Parameters.AddWithValue("@idCliente", idCliente.ToString());
                command.Parameters.AddWithValue("@totalFactura", totalFactura.ToString());
                command.Parameters.AddWithValue("@fechaFactura", Convert.ToDateTime(DateTime.Now));
                command.ExecuteNonQuery();
                conexion.Close();
                //SqlCommand commandSelectUltimo = new SqlCommand(@"SELECT TOP 1 idFactura FROM Factura ORDER BY idFactura DESC", conexion);
                SqlCommand commandSelectUltimo = new SqlCommand(@"SELECT idFactura FROM Factura ORDER BY idFactura DESC", conexion);
                SqlDataReader reader;
                conexion.Open();
                reader = commandSelectUltimo.ExecuteReader();

                string idFactura = "";
                if (reader.Read())
                {
                    idFactura = reader["idFactura"].ToString();
                }
                
                conexion.Close();
                command = new SqlCommand(@"INSERT INTO DetalleFactura (idFactura, idProducto, cantidad)
                        VALUES (@idFactura, @idProducto, @cantidad)", conexion);
                conexion.Open();
                foreach (DataGridViewRow row in dgwDetalle.Rows)
                {
                    MessageBox.Show("Valor idFactura: " + idFactura);
                    command.Parameters.AddWithValue("@idFactura", idFactura);
                    MessageBox.Show("Valor idProducto: " + row.Cells[""]);
                    command.Parameters.AddWithValue("@idProducto", row.Cells[1]);
                    command.Parameters.AddWithValue("@cantidad", row.Cells[3]);
                    command.ExecuteNonQuery();
                }
                conexion.Close();
            }
            else
            {
                MessageBox.Show("No hay productos agregados");
            }
        }
    }
}
