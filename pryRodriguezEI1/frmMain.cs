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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mostrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarProv frmMostrarProv = new frmMostrarProv();
            frmMostrarProv.ShowDialog();
        }

        private void cargaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProv frmCargaProveedores = new frmCargaProv();
            frmCargaProveedores.ShowDialog();
        }

        private void mostrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
