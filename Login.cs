using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection conexion;
        SqlCommand command;
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            String resultado = "";
            try {
                conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oagalindo\Documents\me\2023\p\app\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
                command = new SqlCommand("SELECT * FROM usuario WHERE usuario=@uid AND password=@pass", conexion);
                conexion.Open();
                command.Parameters.AddWithValue("@uid", txtUser.Text.ToString());
                command.Parameters.AddWithValue("@pass", txtPassword.Text.ToString());
                reader = command.ExecuteReader();
                if (reader.Read()) {
                    if (reader["password"].ToString().Equals(txtPassword.Text.ToString(), StringComparison.InvariantCulture))
                    {
                        resultado = "1";
                        InformacionUsuario.usuarioRol = reader["idRol"].ToString();
                        InformacionUsuario.usuarioId = reader["idUsuario"].ToString();
                        InformacionUsuario.nombreUsuario = reader["nombre"].ToString();
                    }
                    else
                    {
                        resultado = "Crendciales no validas";
                        MessageBox.Show(reader["password"].ToString() + " " + txtPassword.Text.ToString());
                    }
                    //if (reader["password"].ToString() == "1234")
                    if (reader["password"].ToString().Equals("1234", StringComparison.InvariantCulture))
                    {
                        resultado = "Aca.";
                        MessageBox.Show(reader["usuario"].ToString());
                    }
                }
                else {
                    resultado = "Conexion a la base de datos fallida.";
                }
                reader.Close();
                command.Dispose();
                conexion.Close();
            }
            catch (Exception ex) {
                resultado = ex.Message.ToString();
            }
            if (resultado == "1")
            {
                Program.openDashBoard = true;
                this.Close();
            }
            else
                MessageBox.Show(resultado);
        }
    }
}
