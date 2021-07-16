using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrmFabricaCelular : FrmProducto
    {
        #region Atributos 

        private bool Arrastrar;
        private Point PuntoInicio = new Point(0, 0);
        private FabricaCelular Celular;
        #endregion

        #region Propiedad

        public override Producto ProductoDelForm => this.Celular;
        #endregion

        public FrmFabricaCelular()
        {
            InitializeComponent();
        }

        #region Botones

        /// <summary>
        /// Boton que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Boton que fabrica el celular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricar_Click(object sender, EventArgs e)
        {
            try
            {
                FabricarCelular();

                this.DialogResult = DialogResult.OK;
            }
            catch (CargarTodosLosDatosException ex)
            {
                MessageBox.Show(ex.InformarExcepcionCargarTodosLosDatos());
                Archivos<Producto>.LogErrores(ex.ToString());
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton que genera un codigo de barras de manera aleatoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUPC_Click_1(object sender, EventArgs e)
        {
            Random numeroRandom = new Random();
            this.CodigoUPC.Text = numeroRandom.Next(100000000, 999999999).ToString();
        }
        #endregion

        #region Eventos
        private void ButtonCerrar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonCerrar.BackgroundImage = FormFranciscoRocha.Properties.Resources.Screenshot_13;
        }

        private void ButtonCerrar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonCerrar.BackgroundImage = null;
        }

        private void ButtonFabricar_MouseEnter(object sender, EventArgs e)
        {
            this.ButtonFabricar.BackgroundImage = FormFranciscoRocha.Properties.Resources.Screenshot_12;
        }

        private void ButtonFabricar_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonFabricar.BackgroundImage = null;
        }

        /// <summary>
        /// Evento que se realiza al abrir el formulario, carga los combobox y remplaza los guion bajo por espacios vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFabricaCelular_Load(object sender, EventArgs e)
        {
            try
            {
                string[] BorrarGuion = Enum.GetNames(typeof(Bateria));
                foreach (string Bateria in BorrarGuion)
                {
                    comboBoxBateria.Items.Add(Bateria.Replace("_", " "));
                }

                BorrarGuion = Enum.GetNames(typeof(PantallaResolucion));
                foreach (string PantallaResolucion in BorrarGuion)
                {
                    comboBoxRes.Items.Add(PantallaResolucion.Replace("_", " "));
                }

                BorrarGuion = Enum.GetNames(typeof(PantallaPulgadas));
                foreach (string PantallaPulgadas in BorrarGuion)
                {
                    comboBoxPulgadas.Items.Add(PantallaPulgadas.Replace("_", " "));
                }

                BorrarGuion = Enum.GetNames(typeof(Camara));
                foreach (string Camara in BorrarGuion)
                {
                    comboBoxCamara.Items.Add(Camara.Replace("_", " "));
                }

                BorrarGuion = Enum.GetNames(typeof(MaterialCarcasa));
                foreach (string MaterialCarcasa in BorrarGuion)
                {
                    comboBoxMaterial.Items.Add(MaterialCarcasa.Replace("_", " "));
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            } 
        }

        /// <summary>
        /// Evento el cual informa el material seleccionado para el celular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se utilizara " + this.comboBoxMaterial.Text + " como material de carcasa");
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que fabrica la pc con todos los componentes seleccionados
        /// </summary>
        private void FabricarCelular()
        {
            try
            {
                int UPC = Convert.ToInt32(CodigoUPC.Text);

                GPU EGpu = (GPU)Enum.Parse(typeof(GPU), ComboboxToStringOriginal(2));
                RAM ERam = (RAM)Enum.Parse(typeof(RAM), ComboboxToStringOriginal(3));
                PantallaResolucion EResolucion = (PantallaResolucion)Enum.Parse(typeof(PantallaResolucion), ComboboxToStringOriginal(7));
                MarcaCPU EMarca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), ComboboxToStringOriginal(1));
                PantallaPulgadas EPulgadas = (PantallaPulgadas)Enum.Parse(typeof(PantallaPulgadas), ComboboxToStringOriginal(8));
                SistemaOP ESistemaOp = (SistemaOP)Enum.Parse(typeof(SistemaOP), ComboboxToStringOriginal(5));
                Camara ECamara = (Camara)Enum.Parse(typeof(Camara), ComboboxToStringOriginal(9));
                Bateria EBateria = (Bateria)Enum.Parse(typeof(Bateria), ComboboxToStringOriginal(6));
                Almacenamiento EAlmacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), ComboboxToStringOriginal(4));
                MaterialCarcasa EMaterial = (MaterialCarcasa)Enum.Parse(typeof(MaterialCarcasa), ComboboxToStringOriginal(10));

                this.Celular = new FabricaCelular(EMarca, EGpu, ERam, ESistemaOp, EAlmacenamiento, UPC, ECamara, EBateria, EMaterial, EPulgadas, EResolucion, BoolSelec(this.comboBoxJack.SelectedIndex), BoolSelec(this.comboBoxHuella.SelectedIndex));

            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                throw new CargarTodosLosDatosException();
            }  
        }

        /// <summary>
        /// Metodo que se utiliza en la fabricacion de pc para modificar el texto de los combobox
        /// </summary>
        /// <param name="indice">Indice del combobox a ser modificado</param>
        /// <returns>Retorna el string modificado dependiendo del indice pasado por parametro</returns>
        protected override string ComboboxToStringOriginal(int indice)
        {
            string Retorno = "";

            try
            {
                switch (indice)
                {
                    case 1:
                        Retorno = ReformarString(this.comboBoxMarca.Text);
                        break;
                    case 2:
                        Retorno = ReformarString(this.comboBoxGPU.Text);
                        break;
                    case 3:
                        Retorno = ReformarString(this.comboBoxRam.Text);
                        break;
                    case 4:
                        Retorno = ReformarString(this.comboBoxAlmacenamiento.Text);
                        break;
                    case 5:
                        Retorno = ReformarString(this.comboBoxSistemaOP.Text);
                        break;
                    case 6:
                        Retorno = ReformarString(this.comboBoxBateria.Text);
                        break;
                    case 7:
                        Retorno = ReformarString(this.comboBoxRes.Text);
                        break;
                    case 8:
                        Retorno = ReformarString(this.comboBoxPulgadas.Text);
                        break;
                    case 9:
                        Retorno = ReformarString(this.comboBoxCamara.Text);
                        break;
                    case 10:
                        Retorno = ReformarString(this.comboBoxMaterial.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return Retorno;
        }


        /// <summary>
        /// Metodo que reforma los espacios vacios a guines bajos
        /// </summary>
        /// <param name="Aux">Sttring a ser modificado</param>
        /// <returns>Retrona el string modificado</returns>
        protected override string ReformarString(string Aux)
        {
            StringBuilder correcion = new StringBuilder(Aux);

            try
            {
                for (int i = 0; i < correcion.Length; i++)
                {
                    if (correcion[i] == ' ')
                    {
                        correcion[i] = '_';
                    }
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return correcion.ToString();
        }

        /// <summary>
        /// Metodo que retorna si la pc tiene o no lector de cd
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override bool BoolSelec(int index)
        {
            bool retorno;

            if (index == 0)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion

        #region Override Load

        /// <summary>
        /// Sobrecarga del evento load de FrmProducto el cual carga los combobox y remplaza los guines bajos por espacios vacios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void FrmProducto_Load(object sender, EventArgs e)
        {
            try
            {
                int Parar = 0;

                string[] BorrarGuion = Enum.GetNames(typeof(MarcaCPU));
                foreach (string MARCAS in BorrarGuion)
                {
                    if (Parar >= 2)
                    {
                        comboBoxMarca.Items.Add(MARCAS.Replace("_", " "));
                    }
                    Parar++;
                }

                Parar = 0;

                BorrarGuion = Enum.GetNames(typeof(GPU));
                foreach (string GPUS in BorrarGuion)
                {
                    if (Parar >= 45)
                    {
                        comboBoxGPU.Items.Add(GPUS.Replace("_", " "));
                    }
                    Parar++;
                }

                Parar = 0;

                BorrarGuion = Enum.GetNames(typeof(RAM));
                foreach (string RAMS in BorrarGuion)
                {
                    if (Parar >= 33)
                    {
                        comboBoxRam.Items.Add(RAMS.Replace("_", " "));
                    }
                    Parar++;
                }

                Parar = 0;

                BorrarGuion = Enum.GetNames(typeof(Almacenamiento));
                foreach (string Almacenamiento in BorrarGuion)
                {
                    if (Parar >= 37)
                    {
                        comboBoxAlmacenamiento.Items.Add(Almacenamiento.Replace("_", " "));
                    }
                    Parar++;
                }

                Parar = 0;

                BorrarGuion = Enum.GetNames(typeof(SistemaOP));
                foreach (string SitemaOP in BorrarGuion)
                {
                    if (Parar >= 9)
                    {
                        comboBoxSistemaOP.Items.Add(SitemaOP.Replace("_", " "));
                    }
                    Parar++;
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        #endregion

        #region Eventos Mover Form

        /// <summary>
        /// Eventos para poder mover el form desde la barra superior donde se encuentra "Celular"
        /// </summary>
        private void MovimientoForm_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastrar = true;
            PuntoInicio = new Point(e.X, e.Y);
        }

        private void MovimientoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastrar)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - PuntoInicio.X, p.Y - PuntoInicio.Y);
            }
        }

        private void MovimientoForm_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastrar = false;
        }
        #endregion
    }
}
