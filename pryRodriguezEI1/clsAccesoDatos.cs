using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace pryRodriguezEI1
{
    internal class clsAccesoDatos
    { //declaro
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        public string cadenaConexion;
        public string estadoConexion;
        public string Errores;
        
        OleDbDataAdapter AdaptadorDS;
        DataSet objDataSet= new DataSet();
        public void ConectarBD()
        {
            cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=../../Resources/El_CLUB.accdb";
            try
            { 
                conexionBD = new OleDbConnection(); //instancio en memoria
                conexionBD.ConnectionString = cadenaConexion; //donde esta la conexion
                conexionBD.Open(); //abre base de datos
                estadoConexion = "Conectado";
            } 
            catch (Exception ex)
            {
                estadoConexion = "Error:" + ex.Message + "\nRuta: " + System.IO.Path.GetFullPath("../../Resources/El_CLUB"); ;
            }
        }

        public void TraerDatos(DataGridView grilla)
        { 
            comandoBD = new OleDbCommand();
            //lectorBD = new OleDbDataReader();
            try
            {
                comandoBD.Connection = conexionBD; //vinculo comando con conexion 
                comandoBD.CommandType = System.Data.CommandType.TableDirect; // el tipo de accion (traer tabla)
                comandoBD.CommandText = "SOCIOS"; // nombre de la tabla que ejecuta la accion 

                lectorBD = comandoBD.ExecuteReader(); //extraer tabla socios y meter dentro del lectorBD

                while (lectorBD.Read())
                {
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[7]);
                }
            }

            catch (Exception ex)
            {
                Errores = ex.Message;
            }
        }

        public void TraerDatosDataSet(DataGridView grilla)
        {
            try
            {   ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD; //vinculo comando con conexion 
                comandoBD.CommandType = System.Data.CommandType.TableDirect; // el tipo de accion (traer tabla)
                comandoBD.CommandText = "SOCIOS"; // nombre de la tabla que ejecuta la accion 

                AdaptadorDS = new OleDbDataAdapter(comandoBD);
                AdaptadorDS.Fill(objDataSet);

                if (objDataSet.Tables["SOCIOS"].Rows.Count > 0)
                {  
                    grilla.Columns.Add("ID", "ID");
                    grilla.Columns.Add("Nombre", "Nombre");
                    grilla.Columns.Add("Apellido", "Apellido");
                    foreach (DataRow fila in objDataSet.Tables[0].Rows)
                    {

                    }
                     

                }

            }
            catch (Exception ex)
            {
                Errores = ex.Message;
                
            }
        }


    }
}
