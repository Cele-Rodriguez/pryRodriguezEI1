using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;


namespace pryRodriguezEI1
{
    public partial class frmMain : Form
    { 
        clsAccesoDatos objBaseDatos;

        public frmMain()
        {
            InitializeComponent();
            objBaseDatos = new clsAccesoDatos();
        }

        private void mostrarProveedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMostrarProv frmMostrarProv = new frmMostrarProv();
            frmMostrarProv.ShowDialog();
        }

        private void cargarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProv frmCargaProveedores = new frmCargaProv();
            frmCargaProveedores.ShowDialog();
        }

        private void mostrarUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSocios frmUsuarios = new frmSocios();
            frmUsuarios.ShowDialog();
        }

         private void buscarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario frmBuscarUsuario = new frmBuscarUsuario();
            frmBuscarUsuario.ShowDialog();
        }      
        private void frmMain_Load(object sender, EventArgs e)
        {
            objBaseDatos.ConectarBD();
            lblEstadoConexion.Text = objBaseDatos.estadoConexion;
        }


    }
}
