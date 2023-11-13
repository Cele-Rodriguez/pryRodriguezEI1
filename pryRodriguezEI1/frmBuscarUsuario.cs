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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatosDataSet(DGVUsuarios);
        }
    }
}
