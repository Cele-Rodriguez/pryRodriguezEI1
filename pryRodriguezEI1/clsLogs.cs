using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezEI1
{
    internal class clsLogs
    {
        public class menu

        {
            OleDbCommand comando;
            OleDbDataReader reader;
            OleDbConnection conexionBD;
            OleDbDataAdapter adapter;
            string cadenaconexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Users\\Nico\\Downloads\\EL_CLUB1.accdb";
            public string estadoconexion = "";

            public void insertar(TextBox fechahora, TextBox nombre, TextBox accion)
            {
                var cadena = ConfigurationManager.ConnectionStrings["dbacces"].ConnectionString;
                try
                {
                    using (OleDbConnection conector = new OleDbConnection(cadena))
                    {
                        //6b
                        conector.Open();
                        string query = @"insert into Tabla1(fechahora,nombre,accion )values(@fecha,@nombre,@accion);";
                        comando = new OleDbCommand(query, conector);
                        comando.Parameters.AddWithValue("@fecha", fechahora.Text);
                        comando.Parameters.AddWithValue("@nombre", nombre.Text);
                        comando.Parameters.AddWithValue("@accion", accion.Text);
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Datos Guardados ");
                        }
                    }




                }
                catch (Exception ex)
                {
                    estadoconexion = "Error " + ex;
                }
            }
        }
    }
ç
