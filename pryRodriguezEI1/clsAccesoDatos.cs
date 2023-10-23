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
        string cadenaConexion = "Provider = Microsoft.ACE.OLEDB.12.0" +
                                    "Data Source= 2_El_Club.accdb";
        public void ConectarBD()
        {
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexion;
            conexionBD.Open();

        }
    }
}
