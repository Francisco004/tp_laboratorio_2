using System;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrnMostrarProductosFabricados : Form
    {
        #region Atributo

        protected FormPrincipal PropiedadAlmacen;
        #endregion

        public FrnMostrarProductosFabricados(FormPrincipal ProductosFabricados)
        {
            InitializeComponent();
            PropiedadAlmacen = ProductosFabricados;
            Mostrar();
        }

        #region Metodos

        /// <summary>
        /// Metodo que muestra en el richTextBox los productos fabricados que se encuentran en el almacen
        /// </summary>
        public void Mostrar()
        {
            try
            {
                this.richTextBox1.Clear();
                this.richTextBox1.AppendText(this.PropiedadAlmacen.Almacen.ToString());

                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

                this.richTextBox1.DeselectAll();
            }
            catch (Exception ex )
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo el cual si se dispara el evento RefreshMostrar del form principal actualiza el richtextbox
        /// </summary>
        public void RefreshRichMostrar()
        {
            try
            {
                if (this.InvokeRequired)
                {
                    Callback callback = new Callback(this.RefreshRichMostrar);
                    object[] args = new object[] { };

                    this.Invoke(callback);
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
            
        }
        #endregion

        #region Evento cerrar

        /// <summary>
        /// Evento que hace que al cerrar el formulario el DialogResult sea OK 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrnMostrarProductosFabricados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
