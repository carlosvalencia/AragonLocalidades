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

namespace AragonLocalidades
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
    }

    private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      String msg = "Nombre: " + e.Node.Text + Environment.NewLine + "Código: " + e.Node.Name;
      MessageBox.Show(msg, "Información");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string path = Application.StartupPath;

      if (radioButton1.Checked) path += "\\Aragon_Comarcas_Localidades.txt"; 
      else path += "\\Aragon_Provincias_Localidades.txt";

      LeeTreeViewDesdeTXT(path, treeView1);
    }

    private void LeeTreeViewDesdeTXT(string path, TreeView arbol)
    {
      // Limpia el TreeView
      arbol.Nodes.Clear();

      Dictionary<int, TreeNode> padre = new Dictionary<int, TreeNode>();

      using (StreamReader sr = File.OpenText(path))
      {
        string linea = "";

        while ((linea = sr.ReadLine()) != null)
        {
          /*
             Dividir en columnas la línea actual, separadas por '#'
             columna[0] = Nivel
             columna[1] = Código-Id
             columna[2] = Nombre
          */
          string[] columna = linea.Split('#');
          int nivel = int.Parse(columna[0]);

          // Añadir un nuevo nodo
          if (nivel == 0) padre[0] = arbol.Nodes.Add(columna[1], columna[2]);
          else padre[nivel] = padre[nivel - 1].Nodes.Add(columna[1], columna[2]);

          //Expandir nodos
          //padre[nivel].EnsureVisible();
        }
      }
      // Expandir nodos
      //if (arbol.Nodes.Count > 0) arbol.Nodes[0].EnsureVisible();
    }


  }
}
