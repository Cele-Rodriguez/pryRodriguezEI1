using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezEI1
{
    public partial class frmUsuarios : Form
    {
        clsAccesoDatos objBaseDatos; //Declaro un objeto de la clase clsAccesoDatos

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsAccesoDatos(); //Intancio el objeto     

            objBaseDatos.ConectarBD(); //Llamo procedimiento 

            toolStripStatusLabel1.Text = objBaseDatos.estadoConexion; 
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objBaseDatos.TraerDatos(DGVUsuarios);
        }
    }
}
