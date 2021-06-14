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
using System.IO;

namespace FormFranciscoRocha
{
    public partial class FormPrincipal : Form
    {
        protected AlmacenProdutosFabricados<Producto> miAlmacen;

        public FormPrincipal()
        {
            InitializeComponent();
            this.miAlmacen = "Productos fabricados Francisco Rocha";

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region Botones

        /// <summary>
        /// Boton para fabricar la PC llamando al formulario de PC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarPC_Click(object sender, EventArgs e)
        {
            FrmFabricaPC PC = new FrmFabricaPC();

            PC.StartPosition = FormStartPosition.CenterScreen;

            this.Hide();

            if (PC.ShowDialog() == DialogResult.OK)
            {
                this.miAlmacen += (Producto)PC.ProductoDelForm;
            }

            this.Show();
        }

        /// <summary>
        /// Boton para fabricar al Celular llamando al formulario del celular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarCelular_Click(object sender, EventArgs e)
        {
            FrmFabricaCelular Celular = new FrmFabricaCelular();

            Celular.StartPosition = FormStartPosition.CenterScreen;

            this.Hide();

            if (Celular.ShowDialog() == DialogResult.OK)
            {
                this.miAlmacen += (Producto)Celular.ProductoDelForm;
            }

            this.Show();
        }

        /// <summary>
        /// Boton para mostrar los productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMostrar_Click(object sender, EventArgs e)
        {
            if (miAlmacen.CantidadGenerica == 0)
            {
                MessageBox.Show("No hay productos fabricados en el almacen para ser mostrados", "Error al guardar el XML");
            }
            else
            {
                FrnMostrarProductosFabricados Mostrar = new FrnMostrarProductosFabricados(miAlmacen);

                Mostrar.StartPosition = FormStartPosition.CenterScreen;

                this.Hide();

                if (Mostrar.ShowDialog() == DialogResult.OK)
                {

                }

                this.Show();
            }
        }

        /// <summary>
        /// Boton para guardar los productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Directorio();
            
            if(miAlmacen.CantidadGenerica == 0)
            {
                MessageBox.Show("No hay productos fabricados en el almacen para ser guardados", "Error al guardar el XML");
            }
            else
            {
                Archivos<Producto>.GuardarFabrica(miAlmacen);
                MessageBox.Show("Se guardaron los datos en: " + miAlmacen.Directorio,"Guardado correcto");
            }
        }

        /// <summary>
        /// Boton para cargar los productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCargar_Click(object sender, EventArgs e)
        {
            Directorio();

            if (File.Exists(miAlmacen.Directorio))
            {
                DialogResult Confirmacion;

                Confirmacion = MessageBox.Show("¿ Desea cargar los datos XML de los productos fabricados ? Se van a sobreescribir los datos actuales", "Acuerdo legal", MessageBoxButtons.OKCancel);

                if (Confirmacion == DialogResult.OK)
                {
                    miAlmacen = Archivos<Producto>.CargarFabrica(miAlmacen);
                    MessageBox.Show("Se cargaron los datos del XML", "Cargado correctamente");
                }
            }
            else
            {
                MessageBox.Show("No existe el archivo para ser cargado, pruebe guardando por primera vez los datos","Error al cargar el XML");
            }
        }

        /// <summary>
        /// Boton para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion;

            Confirmacion = MessageBox.Show("Desea cerrar el form?", "Cerrar", MessageBoxButtons.OKCancel);

            if (Confirmacion == DialogResult.OK)
            {
                Close();
            }
        }
        #endregion

        #region Directorio

        /// <summary>
        /// Establece la ruta en la cual se guardara el XML
        /// </summary>
        private void Directorio()
        {
            miAlmacen.Directorio = AppDomain.CurrentDomain.BaseDirectory + "ProductosFabricadosEnForm.xml";
        }
        #endregion

        #region Eventos de botones

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonCerrar.BackgroundImage = FormFranciscoRocha.Properties.Resources.Cerrar;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonCerrar.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarPC_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonFabricarPC.BackgroundImage = FormFranciscoRocha.Properties.Resources.FabricarPC;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarPC_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonFabricarPC.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarCelular_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonFabricarCelular.BackgroundImage = FormFranciscoRocha.Properties.Resources.Screenshot_2;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarCelular_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonFabricarCelular.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMostrar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonMostrar.BackgroundImage = FormFranciscoRocha.Properties.Resources.MostrarProductos;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMostrar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonMostrar.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonGuardar.BackgroundImage = FormFranciscoRocha.Properties.Resources.GuardarProductos;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonGuardar.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCargar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonCargar.BackgroundImage = FormFranciscoRocha.Properties.Resources.CargarProductos;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCargar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonCargar.BackgroundImage = null;
        }
        #endregion

    }
}
