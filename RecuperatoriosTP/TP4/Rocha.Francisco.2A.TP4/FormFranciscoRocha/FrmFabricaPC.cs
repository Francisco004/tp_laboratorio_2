using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace FormFranciscoRocha
{
    public partial class FrmFabricaPC : FrmProducto
    {
        #region Atributos
        private FabricaPC PC;
        private bool Arrastrar;
        private Point PuntoInicio = new Point(0, 0);
        #endregion

        #region Propiedad

        public override Producto ProductoDelForm => this.PC;
        #endregion

        public FrmFabricaPC()
        {
            InitializeComponent();
        }

        #region Botones
        /// <summary>
        /// Boton que fabrica la PC con los componentes seleccionados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFabricar_Click(object sender, EventArgs e)
        {
            try
            {
                FabricarPC();

                this.DialogResult = DialogResult.OK;
            }
            catch (CargarTodosLosDatosException ex)
            {
                MessageBox.Show(ex.InformarExcepcionCargarTodosLosDatos());
                Archivos<Producto>.LogErrores(ex.ToString());
            }
            catch(Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Boton que cierra el formulario de fabricacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Boton que genera aleatoriamente un codigo de barras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUPC_Click(object sender, EventArgs e)
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
        private void FrmFabricaPC_Load(object sender, EventArgs e)
        {
            try
            {
                string[] BorrarGuion = Enum.GetNames(typeof(Fuente));
                foreach (string Fuentes in BorrarGuion)
                {
                    comboBoxFuente.Items.Add(Fuentes.Replace("_", " "));
                }

                BorrarGuion = Enum.GetNames(typeof(Gabinete));
                foreach (string Gabinetes in BorrarGuion)
                {
                    comboBoxGabo.Items.Add(Gabinetes.Replace("_", " "));
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Evento el cual informa que el procesador se ensamblo en la motherboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMother_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha ensamblado el procesador en la motherboard");
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que fabrica la pc con todos los componentes seleccionados
        /// </summary>
        private void FabricarPC()
        {
            try
            {
                int UPC = Convert.ToInt32(CodigoUPC.Text);

                GPU EGpu = (GPU)Enum.Parse(typeof(GPU), ComboboxToStringOriginal(2));
                RAM ERam = (RAM)Enum.Parse(typeof(RAM), ComboboxToStringOriginal(3));
                Fuente EFuente = (Fuente)Enum.Parse(typeof(Fuente), ComboboxToStringOriginal(7));
                MarcaCPU EMarca = (MarcaCPU)Enum.Parse(typeof(MarcaCPU), ComboboxToStringOriginal(1));
                Gabinete EGabinete = (Gabinete)Enum.Parse(typeof(Gabinete), ComboboxToStringOriginal(8));
                SistemaOP ESistemaOp = (SistemaOP)Enum.Parse(typeof(SistemaOP), ComboboxToStringOriginal(5));
                Motherboard EMother = (Motherboard)Enum.Parse(typeof(Motherboard), ComboboxToStringOriginal(9));
                Procesador EProcesador = (Procesador)Enum.Parse(typeof(Procesador), ComboboxToStringOriginal(6));
                Almacenamiento EAlmacenamiento = (Almacenamiento)Enum.Parse(typeof(Almacenamiento), ComboboxToStringOriginal(4));

                this.PC = new FabricaPC(EMarca, EProcesador, EMother, EGpu, ERam, EFuente, EGabinete, ESistemaOp, EAlmacenamiento, BoolSelec(comboBoxLector.SelectedIndex), UPC);
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                throw new CargarTodosLosDatosException();
            }
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

        /// <summary>
        /// Metodo que reforma los espacios vacios a guines bajos
        /// </summary>
        /// <param name="Aux">Sttring a ser modificado</param>
        /// <returns>Retrona el string modificado</returns>
        protected override string ReformarString(string Aux)
        {
            StringBuilder correcion = new StringBuilder(Aux);

            for (int i = 0; i < correcion.Length; i++)
            {
                if (correcion[i] == ' ')
                {
                    correcion[i] = '_';
                }
            }

            return correcion.ToString();
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
                        Retorno = ReformarString(this.comboBoxCPU.Text);
                        break;
                    case 7:
                        Retorno = ReformarString(this.comboBoxFuente.Text);
                        break;
                    case 8:
                        Retorno = ReformarString(this.comboBoxGabo.Text);
                        break;
                    case 9:
                        Retorno = ReformarString(this.comboBoxMother.Text);
                        break;
                }  
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return Retorno;
        }
        #endregion

        #region Procesador Por Marca
        /// <summary>
        /// Evento que carga los procesadores dependienddo de la marca seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Parar = 0;
                string[] BorrarGuion;

                comboBoxCPU.Items.Clear();

                if (this.comboBoxMarca.SelectedIndex == 0)
                {
                    BorrarGuion = Enum.GetNames(typeof(Procesador));
                    foreach (string Procesadores in BorrarGuion)
                    {
                        if (Parar >= 30)
                        {
                            comboBoxCPU.Items.Add(Procesadores.Replace("_", " "));
                        }
                        Parar++;
                    }
                }
                else if (this.comboBoxMarca.SelectedIndex == 1)
                {
                    BorrarGuion = Enum.GetNames(typeof(Procesador));
                    foreach (string Procesadores in BorrarGuion)
                    {
                        comboBoxCPU.Items.Add(Procesadores.Replace("_", " "));
                        if (Parar == 29)
                        {
                            Parar = 0;
                            break;
                        }
                        Parar++;
                    }
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }
        #endregion

        #region Mother por Procesador y Marca

        /// <summary>
        /// Evento que carga las motherboards dependiendo del procesador y marca seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int Parar = 0;
                string[] BorrarGuion;

                comboBoxMother.Items.Clear();

                if (this.comboBoxMarca.SelectedIndex == 1)   ///INTEL
                {
                    if (this.comboBoxCPU.SelectedIndex >= 0 && this.comboBoxCPU.SelectedIndex <= 5)   ///Si es septima generacion
                    {
                        BorrarGuion = Enum.GetNames(typeof(Motherboard));
                        foreach (string Mothers in BorrarGuion)
                        {
                            comboBoxMother.Items.Add(Mothers.Replace("_", " "));
                            if (Parar == 4)
                            {
                                Parar = 0;
                                break;
                            }
                            Parar++;
                        }
                    }
                    else if (this.comboBoxCPU.SelectedIndex >= 6 && this.comboBoxCPU.SelectedIndex <= 13)   ///Si es decima generacion
                    {
                        BorrarGuion = Enum.GetNames(typeof(Motherboard));
                        foreach (string Mothers in BorrarGuion)
                        {
                            if (Parar >= 5)
                            {
                                comboBoxMother.Items.Add(Mothers.Replace("_", " "));
                            }
                            if (Parar == 10)
                            {
                                break;
                            }
                            Parar++;
                        }
                    }
                    else if (this.comboBoxCPU.SelectedIndex >= 14 && this.comboBoxCPU.SelectedIndex <= 30)   //Si es octava y novena generacion
                    {
                        BorrarGuion = Enum.GetNames(typeof(Motherboard));
                        foreach (string Mothers in BorrarGuion)
                        {
                            if (Parar >= 11)
                            {
                                comboBoxMother.Items.Add(Mothers.Replace("_", " "));
                            }
                            if (Parar == 17)
                            {
                                break;
                            }
                            Parar++;
                        }
                    }
                }
                else if (this.comboBoxMarca.SelectedIndex == 0)   ///AMD
                {
                    BorrarGuion = Enum.GetNames(typeof(Motherboard));
                    foreach (string Mothers in BorrarGuion)
                    {
                        if (Parar >= 18)
                        {
                            comboBoxMother.Items.Add(Mothers.Replace("_", " "));
                        }
                        if (Parar == 27)
                        {
                            break;
                        }
                        Parar++;
                    }
                }
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }
        #endregion

        #region Override Load
        /// <summary>
        /// Sobrecarga del evento load de FrmProducto el cual carga los combobox 
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
                    comboBoxMarca.Items.Add(MARCAS.Replace("_", " "));
                    if (Parar == 1)
                    {
                        Parar = 0;
                        break;
                    }
                    Parar++;
                }

                BorrarGuion = Enum.GetNames(typeof(GPU));
                foreach (string GPUS in BorrarGuion)
                {
                    comboBoxGPU.Items.Add(GPUS.Replace("_", " "));
                    if (Parar == 44)
                    {
                        Parar = 0;
                        break;
                    }
                    Parar++;
                }

                BorrarGuion = Enum.GetNames(typeof(RAM));
                foreach (string RAMS in BorrarGuion)
                {
                    comboBoxRam.Items.Add(RAMS.Replace("_", " "));
                    if (Parar == 32)
                    {
                        Parar = 0;
                        break;
                    }
                    Parar++;
                }

                BorrarGuion = Enum.GetNames(typeof(Almacenamiento));
                foreach (string Almacenamientos in BorrarGuion)
                {
                    comboBoxAlmacenamiento.Items.Add(Almacenamientos.Replace("_", " "));
                    if (Parar == 36)
                    {
                        Parar = 0;
                        break;
                    }
                    Parar++;
                }

                BorrarGuion = Enum.GetNames(typeof(SistemaOP));
                foreach (string SistemaOperativos in BorrarGuion)
                {
                    comboBoxSistemaOP.Items.Add(SistemaOperativos.Replace("_", " "));
                    if (Parar == 8)
                    {
                        Parar = 0;
                        break;
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
        /// Eventos para poder mover el form desde la barra superior donde se encuentra "Computadora"
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
