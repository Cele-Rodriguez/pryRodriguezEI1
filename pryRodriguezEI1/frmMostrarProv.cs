using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryRodriguezEI1
{
    public partial class frmMostrarProv : Form
    {
        public frmMostrarProv()
        {
            InitializeComponent();
            LlenarTreeView();
            this.treeView1.NodeMouseClick +=
             new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        private void LlenarTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"../../");
            if (info.Exists == true) //POR DEFECTO el IF pregunta true
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                treeView1.Nodes.Add(nodoMadre);
            }
        }
            //desde info.GetDirectories() nos da todos los nombrs
            //de carpetas
        
        private void ObtenerCarpetas (DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
            {
                TreeNode aNode;
                DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    aNode.ImageKey = "carpeta.png";

                    //recursiva - se llama a si mismo para
                    //buscar màs carpetas
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        ObtenerCarpetas(subSubDirs, aNode);
                    }

                    nodeToAddTo.Nodes.Add(aNode);
                }
            
        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag; //
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                { new ListViewItem.ListViewSubItem(item, @"../../"),
                    new ListViewItem.ListViewSubItem(item,
                    dir.LastAccessTime.ToShortDateString())
                };
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                { new ListViewItem.ListViewSubItem(item, "Archivo.png"),
                      new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())
                };

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            
            }
           

           // listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

    }
    
}
