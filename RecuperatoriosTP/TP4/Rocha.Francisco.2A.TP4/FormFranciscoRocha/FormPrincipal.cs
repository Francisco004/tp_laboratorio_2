using System;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using System.IO;
using System.Threading;

namespace FormFranciscoRocha
{
    public delegate void Callback();

    public partial class FormPrincipal : Form
    {
        public event Callback RefreshMostrar;

        #region Atributos

        Thread mostrar;
        Thread eliminar;
        private bool Arrastrar;
        private Point PuntoInicio = new Point(0, 0);
        protected AlmacenProdutosFabricados<Producto> miAlmacen;
        #endregion

        #region Propiedad

        /// <summary>
        /// Propiedad de tipo almacen que retorna el almacen de productos fabricados y un setter para poder borrar un producto 
        /// </summary>
        public AlmacenProdutosFabricados<Producto> Almacen { get { return this.miAlmacen; } set { this.miAlmacen = value; } }
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();

            this.miAlmacen = "Productos fabricados Francisco Rocha";
            this.StartPosition = FormStartPosition.CenterScreen;

            this.AlmacenSQL();
        }

        #region Botones

        /// <summary>
        /// Boton para fabricar la PC llamando al formulario de PC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarPC_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadPC = new Thread(HiloPC);
                threadPC.IsBackground = true;
                threadPC.Start();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton para fabricar al Celular llamando al formulario del celular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricarCelular_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadCelular = new Thread(HiloCelular);
                threadCelular.IsBackground = true;
                threadCelular.Start();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton para mostrar los productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.miAlmacen.CantidadGenerica > 0)
                {
                    if (this.mostrar != null)
                    {
                        this.mostrar.Abort();
                        MessageBox.Show("Ya estaba abierto un mostrar, se ha cerrado el que estaba abierto...");
                    }

                    this.mostrar = new Thread(HiloMostrar);
                    this.mostrar.IsBackground = true;
                    this.mostrar.Start();
                }
                else
                {
                    MessageBox.Show("No hay productos fabricados en el almacen para ser mostrados", "Error al mostrar");
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton para guardar los productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Directorio();

                if (miAlmacen.CantidadGenerica == 0)
                {
                    MessageBox.Show("No hay productos fabricados en el almacen para ser guardados", "Error al guardar el XML");
                }
                else
                {
                    Archivos<Producto>.GuardarFabrica(miAlmacen);
                    MessageBox.Show("Se guardaron los datos en: " + miAlmacen.Directorio, "Guardado correcto");
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton para cargar los productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCargar_Click(object sender, EventArgs e)
        {
            try
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
                        this.ActualizarCantidadSQL();
                    }
                }
                else
                {
                    MessageBox.Show("No existe el archivo para ser cargado, pruebe guardando por primera vez los datos", "Error al cargar el XML");
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton que carga los datos de la base de datos al almacen de productos fabricados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarSQL_Click(object sender, EventArgs e)
        {
            try
            {
                this.CargarDesdeSQL();
                this.ActualizarCantidadSQL();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton que abre un form para borrar un producto del almacen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.eliminar != null)
                {
                    this.eliminar.Abort();
                }

                if (this.miAlmacen.CantidadGenerica > 0)
                {
                    this.WindowState = FormWindowState.Minimized;

                    if (this.mostrar == null)
                    {
                        this.mostrar = new Thread(HiloMostrar);
                        this.mostrar.IsBackground = true;
                        this.mostrar.Start();
                    }

                    this.eliminar = new Thread(HiloBorrar);
                    this.eliminar.IsBackground = true;
                    this.eliminar.Start();
                }
                else
                {
                    MessageBox.Show("No hay productos fabricados en el almacen para ser eliminados", "Error al eliminar");
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton que se encarga de cargar los datos del XML al la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXMLaSQL_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadXML = new Thread(HiloXMLToSQL);
                threadXML.IsBackground = true;
                MessageBox.Show("Se estan guardando los datos del XML a la base de datos...");
                threadXML.Start();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
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

        /// <summary>
        /// Boton para minimizar el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            this.ButtonGuardar.BackgroundImage = FormFranciscoRocha.Properties.Resources.GuardarEnXML;
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
            this.ButtonCargar.BackgroundImage = FormFranciscoRocha.Properties.Resources.CargarXML;
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

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_MouseEnter(object sender, EventArgs e)
        {
            this.buttonEliminar.BackgroundImage = FormFranciscoRocha.Properties.Resources.EliminarProducto;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.buttonEliminar.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarSQL_MouseEnter(object sender, EventArgs e)
        {
            this.CargarSQL.BackgroundImage = FormFranciscoRocha.Properties.Resources.CargarDesdeSQL;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarSQL_MouseLeave(object sender, EventArgs e)
        {
            this.CargarSQL.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXMLaSQL_MouseEnter(object sender, EventArgs e)
        {
            this.buttonXMLaSQL.BackgroundImage = FormFranciscoRocha.Properties.Resources.CargarXMLalSQL;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXMLaSQL_MouseLeave(object sender, EventArgs e)
        {
            this.buttonXMLaSQL.BackgroundImage = null;
        }

        /// <summary>
        /// Evento para mostrar la imagen del boton cuando se pone el mouse por encima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinimizar_MouseEnter(object sender, EventArgs e)
        {
            this.buttonMinimizar.BackgroundImage = FormFranciscoRocha.Properties.Resources.MinimizarFinal;
        }

        /// <summary>
        /// Evento para dejar de mostrar la imagen cuando el mouse se salga del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinimizar_MouseLeave(object sender, EventArgs e)
        {
            this.buttonMinimizar.BackgroundImage = null;
        }
        #endregion

        #region Eventos Mover Form

        /// <summary>
        /// Eventos para poder mover el form desde la barra superior donde se encuentra "Fabrica de productos informticos"
        /// </summary>

        private void PanelMovimientoForm_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastrar = true;
            PuntoInicio = new Point(e.X, e.Y);
        }

        private void PanelMovimientoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastrar)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - PuntoInicio.X, p.Y - PuntoInicio.Y);
            }
        }

        private void PanelMovimientoForm_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastrar = false;
        }
        #endregion

        #region Metodos Hilos

        /// <summary>
        /// Metodo el cual abre el formulario FrmFabricaPC y en caso de aceptar se guarda la PC fabricada en el almacen y en la base de datos
        /// </summary>
        private void HiloPC()
        {
            try
            {
                SQLPC SQL = new SQLPC();
                FrmFabricaPC PC = new FrmFabricaPC();

                PC.StartPosition = FormStartPosition.CenterScreen;

                if (PC.ShowDialog() == DialogResult.OK)
                {
                    this.miAlmacen += (Producto)PC.ProductoDelForm;

                    if (SQL.InsertarPC((FabricaPC)PC.ProductoDelForm))
                    {
                        if (RefreshMostrar != null)
                        {
                            RefreshMostrar.Invoke();
                        }
                        MessageBox.Show("Se inserto la PC en la base de datos y en el almacen exitosamente.");
                        this.ActualizarCantidadSQL();
                    }
                }
            }
            catch(ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL() + " pero se guardaro el producto fabricado en el almacen");
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo el cual abre el formulario FrmFabricaCelular y en caso de aceptar se guarda el Celular fabricado en el almacen y en la base de datos
        /// </summary>
        private void HiloCelular()
        {
            try
            {
                SQLCelular SQL = new SQLCelular();
                FrmFabricaCelular Celular = new FrmFabricaCelular();

                Celular.StartPosition = FormStartPosition.CenterScreen;

                if (Celular.ShowDialog() == DialogResult.OK)
                {
                    this.miAlmacen += (Producto)Celular.ProductoDelForm;

                    if (SQL.InsertarCelular((FabricaCelular)Celular.ProductoDelForm))
                    {
                        if (RefreshMostrar != null)
                        {
                            RefreshMostrar.Invoke();
                        }
                        MessageBox.Show("Se inserto el celular en la base de datos y en el almacen exitosamente.");
                        this.ActualizarCantidadSQL();
                    }
                }
            }
            catch (ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL() + " pero se guardaro el producto fabricado en el almacen");
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo que se encarga de abrir el FrnMostrarProductosFabricados
        /// </summary>
        private void HiloMostrar()
        {
            try
            {
                FrnMostrarProductosFabricados Mostrar = new FrnMostrarProductosFabricados(this);

                Mostrar.StartPosition = FormStartPosition.Manual;

                Point newpoint = new Point(300, 250);

                Mostrar.Location = newpoint;

                RefreshMostrar += Mostrar.RefreshRichMostrar;

                if (Mostrar.ShowDialog() == DialogResult.OK)
                {
                    RefreshMostrar -= Mostrar.RefreshRichMostrar;
                    this.mostrar = null;
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo que se encarga de abrir el FrmEliminar 
        /// </summary>
        private void HiloBorrar()
        {
            try
            {
                int IndexActual = this.miAlmacen.CantidadGenerica;

                FrmEliminar Eliminar = new FrmEliminar(this);

                Eliminar.StartPosition = FormStartPosition.Manual;

                Point newpoint = new Point(800, 400);

                Eliminar.Location = newpoint;


                if (Eliminar.ShowDialog() == DialogResult.OK)
                {
                    if (Eliminar.PropiedadAlmacen.miAlmacen.CantidadGenerica != IndexActual)
                    {
                        RefreshMostrar.Invoke();

                        if (this.mostrar != null)
                        {
                            MessageBox.Show("Se refresco el formulario mostrar que se encontraba abierto con los nuevos datos...");
                        }

                        this.ActualizarCantidadSQL();
                    }
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo que se encarga cargar los datos del XML a la base de datos
        /// </summary>
        private void HiloXMLToSQL()
        {
            try
            {
                Directorio();

                XMLaSQL.XMLASQL(miAlmacen.Directorio);

                Thread.Sleep(3000);

                MessageBox.Show("Se guardaron los datos del XML en la base de datos exitosamente!");

                this.ActualizarCantidadSQL();
            }
            catch (ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL());
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        #endregion

        #region Metodos SQL

        /// <summary>
        /// Metodo el cual borra un producto de la base de datos mediante un codigo de barras pasado por parametro e informa de lo sucedido 
        /// </summary>
        /// <param name="UPC">Codigo de barras del producto a ser borrado</param>
        public void BorrarProducto(int UPC)
        {
            try
            {
                SQLPC SQLPC = new SQLPC();
                SQLCelular SQLCelular = new SQLCelular();

                if (SQLPC.BorrarPC(UPC))
                {
                    MessageBox.Show("La PC fabricada seleccionada se borro de la base de datos y del almacen");
                }
                else
                {
                    SQLCelular.BorrarCelular(UPC);
                    MessageBox.Show("El Celular fabricado seleccionado se borro de la base de datos y del almacen");
                }
            }
            catch (ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL());
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo que se encarga de traer los productos desde la base de datos al almacen de productos fabricados
        /// </summary>
        private void CargarDesdeSQL()
        {
            try
            {
                int aux = this.miAlmacen.CantidadGenerica;

                SQLPC PC = new SQLPC();
                SQLCelular Celular = new SQLCelular();

                this.miAlmacen = PC.ObtenerListaDato(this.miAlmacen);
                this.miAlmacen = Celular.ObtenerListaDato(this.miAlmacen);

                if(this.miAlmacen.CantidadGenerica > aux)
                {
                    MessageBox.Show("Se cargaron los datos del SQL correctamente", "Carga satisfactoria");
                }
                else
                {
                    MessageBox.Show("No habia datos en la base de datos para ser cargados", "Carga insatisfactoria");
                }
            }
            catch (ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL());
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        private void AlmacenSQL()
        {
            try
            {
                SQLAlmacen Almacen = new SQLAlmacen();

                Almacen.InsertarAlmacen(miAlmacen);

                this.ActualizarCantidadSQL();
            }
            catch (ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL());
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        private void ActualizarCantidadSQL()
        {
            try
            {
                SQLAlmacen Almacen = new SQLAlmacen();

                Almacen.ModificarCantidad(this.miAlmacen);
            }
            catch (ConexionSQLException ex)
            {
                MessageBox.Show(ex.InformarExcepcionSQL() + " para poder actualizar la tabla almacen");
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }
        #endregion
    }
}
