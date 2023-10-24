using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryRodriguezEI1
{
    internal class clsAccesoDatos
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;


        string cadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0" +
                                    "Data Source= 2_El_Club.accdb";

        public string estadoConexion = "";
        
        public void ConectarBD()
        {
            try
            { 
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";
            } 
            catch (Exception ex)
            {
                estadoConexion = "Error:" + ex.Message;
            }
        }

        public void TraerDatos()
        { 
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect; // el tipo de accion 
            comandoBD.CommandText = "SOCIOS"; // nombre de la tabla que ejecuta la accion 

            if (lectorBD.Read())
            {
                datosTabla = lectorBD[0];

            }
        }
    }
}
