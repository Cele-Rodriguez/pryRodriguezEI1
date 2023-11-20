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

            
        }
        internal class LogsManager
        {
            OleDbCommand comando;
            OleDbConnection conexionBD;
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Nico\\Downloads\\EL_CLUB1.accdb";
            public string EstadoConexion = "";

            public void InsertarRegistro(TextBox fechahora, TextBox nombre, TextBox accion)
            {
                try
                {
                    using (OleDbConnection conector = new OleDbConnection(cadenaConexion))
                    {
                        conector.Open();
                        string query = "INSERT INTO Tabla1 (fechahora, nombre, accion) VALUES (@fecha, @nombre, @accion)";
                        comando = new OleDbCommand(query, conector);
                        comando.Parameters.AddWithValue("@fecha", fechahora.Text);
                        comando.Parameters.AddWithValue("@nombre", nombre.Text);
                        comando.Parameters.AddWithValue("@accion", accion.Text);

                        if (comando.ExecuteNonQuery() > 0)
                        {
                            // Considera devolver un resultado en lugar de mostrar un mensaje aquí
                            // MessageBox.Show("Datos Guardados ");
                            EstadoConexion = "Datos Guardados";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Aquí puedes lograr o registrar detalles más específicos sobre la excepción
                    EstadoConexion = "Error: " + ex.Message;
                }
            }
        }


    }
}
