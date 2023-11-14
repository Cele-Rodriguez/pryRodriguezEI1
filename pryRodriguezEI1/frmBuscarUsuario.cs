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
    public partial class frmBuscarUsuario : Form
    {
        public frmBuscarUsuario()
        {
            InitializeComponent();
            
        }
        clsAccesoDatos objAccesoBD = new clsAccesoDatos();

        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {
            objAccesoBD = new clsAccesoDatos(); //Instancio el objeto     

            objAccesoBD.ConectarBD(); //Llamo procedimiento
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //objAccesoBD.TraerDatosDataSet(DGVUsuarios);

            objAccesoBD.FiltrarPorId(DGVUsuarios, txtIDCliente.Text);       

        }
        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            objAccesoBD.FiltrarApellido(DGVUsuarios, txtApellido.Text);
        }

    }    
    
}
