using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class InformacionUsuario
    {
        public static string usuarioId = "";
        public static string nombreUsuario = "";
        public static string usuarioRol = "";
    }

    class ClassDA
    {
        public static SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oagalindo\Documents\me\2023\p\app\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
        
        public static DataSet dataSetConexion;        
        public static DataTable Mostrar ()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM cliente", conexion);
            try
            {
                conexion.Open();
                SqlDataAdapter adapterCommand = new SqlDataAdapter(command);
                dataSetConexion = new DataSet();
                adapterCommand.Fill(dataSetConexion, "nombreCliente");
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return dataSetConexion.Tables["nombreCliente"];
            //return dataSetConexion.Tables["cliente"];
        }

        public static DataSet dataSetConexionProducto;
        public static DataTable MostrarProducto ()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM producto3", conexion);
            try
            {
                conexion.Open();
                SqlDataAdapter adapterCommand = new SqlDataAdapter(command);
                dataSetConexionProducto = new DataSet();
                adapterCommand.Fill(dataSetConexionProducto, "nombre");
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return dataSetConexionProducto.Tables["nombre"];
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
        public static Boolean openDashBoard {  get; set; }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            if (openDashBoard) {
                Application.Run(new Form1());
            }

        }
    }
}
