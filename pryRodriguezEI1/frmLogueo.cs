using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryRodriguezEI1
{
    public partial class frmLogueo : Form
    {
        
        clsAccesoDatos objBaseDatos; //Declaro un objeto de la clase clsAccesoDatos
        Int32 Incorrecto;
        
        public frmLogueo()
        {
            InitializeComponent();
        }


        public void frmLogueo_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsAccesoDatos(); //Intancio el objeto     

            objBaseDatos.ConectarBD(); //Llamo procedimiento 

        }
        
        public void btnIngresar_Click(object sender, EventArgs e)
        {
            
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            
            try
            {
                objBaseDatos.ConectarBD();

                if (objBaseDatos.AutenticarUsuario(nombreUsuario, contraseña)) //LLamo procedimiento
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    frmMain frmMain = new frmMain();
                    frmMain.ShowDialog();
                    this.Close();                   
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    
                    Incorrecto = Incorrecto + 1;
                    
                    if (Incorrecto == 3)
                    {   MessageBox.Show("Intentos máximos superados");
                        //frmLogueo frmLogueo = new frmLogueo();
                        //frmLogueo.Close();
                        this.Close();
                        Application.Exit();
                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                

            }

        }
        
    }
}
