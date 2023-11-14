using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

namespace pryRodriguezEI1
{
    public partial class frmCargaProv : Form
    {
        StreamReader LectorArchivo;
        StreamWriter EscribirArchivo;
        string rutaArchivo;
        string leerLinea;
        string[] separadorTexto;

        public frmCargaProv()
        {
            InitializeComponent();
        }

        private void frmCargaProv_Load(object sender, EventArgs e)
        {   // defino la ruta dinamica
            DirectoryInfo InfoCarpetas = new DirectoryInfo(@"..\..");

            rutaArchivo = InfoCarpetas.FullName;
            rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";
           //leo el archivo tomando la ruta 
            LectorArchivo = new StreamReader(rutaArchivo);

            // leo archivo, separo texto y muestro en grilla
            while (!LectorArchivo.EndOfStream)
            { 
                leerLinea = LectorArchivo.ReadLine();
                separadorTexto = leerLinea.Split(';') ;
                dgvDatos.Rows.Add(separadorTexto);
            }
            // cierro archivo
            LectorArchivo.Close();  

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           // DirectoryInfo InfoCarpetas = new DirectoryInfo(@"..\..");
           // rutaArchivo = InfoCarpetas.FullName;
           // rutaArchivo += "\\basedatos\\Listado de aseguradores.csv";

            EscribirArchivo = new StreamWriter(rutaArchivo, true);

            EscribirArchivo.WriteLine(txtApertura.Text + ";" + txtDireccion.Text + ";" + 
                txtEntidad.Text + ";" + txtExpediente.Text + ";" + txtJurisdiccion.Text 
                + ";" + txtJuz.Text + ";" + txtLiq.Text + ";" + txtNum.Text) ;
            EscribirArchivo.Close ();

            MessageBox.Show("almacenado");
            txtNum.Text = "";
            txtApertura.Text = "";
            txtDireccion.Text   = "";
            txtExpediente.Text= "";
            txtJurisdiccion.Text = "";
            txtJuz.Text = "";  
            txtLiq.Text = "";
            txtNum.Focus(); 
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            // al hacer doble click en la fila lleno todos los txt con su info
            // para despues poder modificarlos 
        {   txtNum.Text = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEntidad.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtApertura.Text = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtExpediente.Text = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtJuz.Text = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtJurisdiccion.Text = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtLiq.Text= dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    //identificar el registro a modificar
        //   DirectoryInfo infoCarpeta = new DirectoryInfo(@"../..");
        //
        //    string rutaarchivo = infoCarpeta.FullName + "\\BasesDatos\\base.csv";
        //    string rutaarchivoaux = infoCarpeta.FullName + "\\BasesDatos\\temporal.csv";
        //
        //    StreamReader lectorArchivo = new StreamReader(rutaarchivo);
        //    StreamWriter archivoAuxiliar = new StreamWriter(rutaarchivoaux);

        //    string linea;
        //     string[] textoSeparado;

        //        while (!lectorArchivo.EndOfStream)
        //  {
        //      linea = lectorArchivo.ReadLine();

        //            textoSeparado = linea.Split(';');
        //
        //        if (Codigo == textoSeparado[0])
        //        {
        //            MessageBox.Show("aquì hay que modificar " + textoSeparado[2]);
                    //grabarlo
        //            textoSeparado[1] =  ;
        //            archivoAuxiliar.WriteLine(textoSeparado[0]);
        //        }
        //        else
        //        {
                    //grabo
        //            archivoAuxiliar.WriteLine(linea);
        //        }

        //    }
        //    archivoAuxiliar.Close();
        //    lectorArchivo.Close();

         
      
        //}
        //string Codigo;

        //private void dgvDatos_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        //{
        //    Codigo = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
        //    txtModificar.Text = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
        //}
    }
}
