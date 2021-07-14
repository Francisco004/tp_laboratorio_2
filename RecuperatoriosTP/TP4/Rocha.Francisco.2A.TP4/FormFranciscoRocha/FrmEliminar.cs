using System;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrmEliminar : Form
    {
        #region Propiedad

        int UPC;

        /// <summary>
        /// Propiedad la cual retorna un codigo de barras y setea un codigo de barras al atributo UPC
        /// </summary>
        public int UPCBorrar
        {
            get { return UPC; }
            set { UPC = value; }
        }

        public FormPrincipal PropiedadAlmacen;
        #endregion

        public FrmEliminar(FormPrincipal ProductosFabricados)
        {
            InitializeComponent();

            PropiedadAlmacen = ProductosFabricados;
        }

        #region Boton Eliminar

        /// <summary>
        /// Boton que se encarga de borrar el producto del almacen y de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                UPCBorrar = this.PropiedadAlmacen.Almacen.BuscarUPC(textBoxEliminar.Text);

                this.PropiedadAlmacen.Almacen -= UPCBorrar;
                this.PropiedadAlmacen.BorrarProducto(UPCBorrar);

                this.DialogResult = DialogResult.OK;
            }
            catch (NoSeEncontroException ex)
            {
                MessageBox.Show(ex.InformarExcepcion());
                Archivos<IProductos>.LogErrores(ex.InformarExcepcion());
            }
        }
        #endregion

        #region Eventos

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEliminar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonEliminar.BackgroundImage = FormFranciscoRocha.Properties.Resources.Screenshot_21;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonEliminar.BackgroundImage = null;
        }
        #endregion
    }
}
