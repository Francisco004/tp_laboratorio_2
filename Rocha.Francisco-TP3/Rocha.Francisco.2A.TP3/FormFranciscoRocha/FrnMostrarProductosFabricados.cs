using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrnMostrarProductosFabricados : Form
    {
        protected AlmacenProdutosFabricados<Producto> MostrarProdutosFabricados;

        public FrnMostrarProductosFabricados(AlmacenProdutosFabricados<Producto> ProductosFabricados)
        {
            InitializeComponent();

            
            MostrarProdutosFabricados = ProductosFabricados;
            Mostrar();
        }

        /// <summary>
        /// Metodo que muestra en el richTextBox los productos fabricados que se encuentran en el almacen
        /// </summary>
        private void Mostrar()
        {
            this.richTextBox1.Clear();
            this.richTextBox1.AppendText(this.MostrarProdutosFabricados.ToString());

            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
