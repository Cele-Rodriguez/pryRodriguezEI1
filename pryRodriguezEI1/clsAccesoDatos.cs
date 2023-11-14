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
        DataSet objDataSet = new DataSet();
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
            { ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD; //vinculo comando con conexion 
                comandoBD.CommandType = System.Data.CommandType.TableDirect; // el tipo de accion (traer tabla)
                comandoBD.CommandText = "SOCIOS"; // nombre de la tabla que ejecuta la accion 

                AdaptadorDS = new OleDbDataAdapter(comandoBD);
                AdaptadorDS.Fill(objDataSet);

                while (objDataSet.Tables["SOCIOS"].Rows.Count > 0)
                {
                    //


                }

            }
            catch (Exception ex)
            {
                Errores = ex.Message;

            }
        }





        public bool AutenticarUsuario(string nombreUsuario, string contraseña)
        {   bool bandera = new bool();
            bandera = false;
            try
            {  // Define la consulta parametrizada
                string consulta = "SELECT * FROM SOCIOS WHERE NOMBRE = @Usuario AND CODIGO_SOCIO = @Contraseña";

                using (OleDbCommand comando = new OleDbCommand(consulta, conexionBD))
                {// Agrega el parámetro
                    bandera = true;
                    comando.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);
                    // Crea un adaptador de datos y un conjunto de datos
                    using (OleDbDataReader reader = comando.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                     
                }
                if (bandera)
                {
                    // Registro del inicio de sesión
                    RegistrarInicioSesion(nombreUsuario);
                    
                }
                
              


            }
            catch (OleDbException ex)
            {
                throw new Exception("Error al acceder a la base de datos: " + ex.Message);
            }
           
        }

        public void RegistrarInicioSesion(string nombreUsuario)
        {
            try
            {
                    // Crea una consulta SQL para insertar el registro de inicio de sesión
                    string consulta = "INSERT INTO REGISTRO (NOMBRE, FECHA) VALUES (@NombreUsuario, @FechaInicioSesion)";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexionBD))
                    {
                        // Agrega los parámetros a la consulta
                        comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        comando.Parameters.AddWithValue("@FechaInicioSesion", DateTime.Now);

                        // Ejecuta la consulta
                        comando.ExecuteNonQuery();
                    }
                
            }
            catch (OleDbException ex)
            {
                // Maneja las excepciones según tus necesidades
                Console.WriteLine("Error al registrar inicio de sesión: " + ex.Message);
            }
        }



        public void FiltrarPorId(DataGridView dataGridView, string idIngresado)
            {
                if (!string.IsNullOrEmpty(idIngresado))
                {
                    try
                    {
                        // Define la consulta parametrizada
                        string consulta = "SELECT * FROM SOCIOS WHERE CODIGO_SOCIO = @Id";

                        using (OleDbCommand comando = new OleDbCommand(consulta, conexionBD))
                        {
                            // Agrega el parámetro a la consulta
                            comando.Parameters.AddWithValue("@Id", idIngresado);

                            // Crea un adaptador de datos y un conjunto de datos
                            using (OleDbDataAdapter adaptador = new OleDbDataAdapter(comando))
                            {
                                // Crea un nuevo conjunto de datos
                                DataSet dataSet = new DataSet();

                                // Llena el conjunto de datos con los resultados de la consulta
                                adaptador.Fill(dataSet, "SOCIOS");

                                // Asigna el conjunto de datos a la DataGridView
                                dataGridView.DataSource = dataSet.Tables["TuTabla"];
                            }
                        }
                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error al acceder a la base de datos: " + ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID antes de filtrar.");
                }
            

        }

    }
}
        
    
