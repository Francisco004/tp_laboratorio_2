using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class FabricaPC : Producto
    {
        #region Atributos
        protected bool LectorCD;
        protected Gabinete gabinete;
        protected Fuente fuenteDePoder;
        protected Motherboard placaMadre;
        protected Procesador micropocesador;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad enum PROCESADOR que retorna el procesador y setea el procesador en caso de ser compatible con su marca, caso contrario le asigna 0
        /// </summary>
        public Procesador PROCESADOR
        {
            get { return micropocesador; }
            set
            {
                if (ValidarProcesador(value, MARCA_CPU) == true)
                {
                    micropocesador = value;
                }
            }
        }

        /// <summary>
        /// Propiedad enum PLACA_MADRE que retorna la placa madre y setea la placa madre en caso de ser compatible con su marca, caso contrario le asigna 0
        /// </summary>
        public Motherboard PLACA_MADRE
        {
            get { return placaMadre; }
            set
            {
                if (ValidarMotherboard(value, PROCESADOR) == true)
                {
                    placaMadre = value;
                }
            }
        }

        /// <summary>
        /// Propiedad enum GABINETE que retorna el gabinete y setea el gabinete
        /// </summary>
        public Gabinete GABINETE { get => gabinete; set => gabinete = value; }

        /// <summary>
        /// Propiedad enum FUENTE que retorna la fuente y setea la fuente
        /// </summary>
        public Fuente FUENTE { get => fuenteDePoder; set => fuenteDePoder = value; }

        /// <summary>
        /// Propiedad bool LECTOR_CD que retorna un booleano indicando si tiene o no y setea un booleano indicando si tiene o no
        /// </summary>
        public bool LECTOR_CD { get => LectorCD; set => LectorCD = value; }

        #region Propiedades override

        /// <summary>
        /// Propiedad que retorna la marcay que setea la marca en caso de ser compatible con la PC
        /// </summary>
        public override MarcaCPU MARCA_CPU
        {
            get { return base.procesador; }
            set
            {
                if (ValidarMarca(value) == true)
                {
                    base.procesador = value;
                }
            }
        }

        /// <summary>
        /// Propiedad que retorna la GPU y que setea la GPU en caso de ser compatible con la PC
        /// </summary>
        public override GPU GRAFICOS
        {
            get { return base.graficos; }
            set
            {
                if (ValidarGpu(value) == true)
                {
                    base.graficos = value;
                }
            }
        }

        /// <summary>
        /// Propiedad que retorna la RAM y que setea la RAM en caso de ser compatible con la PC
        /// </summary>
        public override RAM MEMORIA_RAM
        {
            get { return base.memoriaRam; }
            set
            {
                if (ValidarRam(value) == true)
                {
                    base.memoriaRam = value;
                }
            }
        }

        /// <summary>
        /// Propiedad que retorna el Sistema operativo y que setea el Sistema operativo en caso de ser compatible con la PC
        /// </summary>
        public override SistemaOP SISTEMA_OPERATIVO
        {
            get { return base.sistemaOperativo; }
            set
            {
                if (ValidarSistemaOperativo(value) == true)
                {
                    base.sistemaOperativo = value;
                }
            }
        }

        /// <summary>
        /// Propiedad que retorna el almacenamiento y que setea el almacenamiento en caso de ser compatible con la PC
        /// </summary>
        public override Almacenamiento ALMACENAMIENTO
        {
            get { return base.almacenamiento; }
            set
            {
                if (ValidarAlmacenamiento(value) == true)
                {
                    base.almacenamiento = value;
                }
            }
        }
        #endregion

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor vacio para el XML
        /// </summary>
        public FabricaPC()
        {

        }

        /// <summary>
        /// Constructor principal de FabricaPC el cual le asigna todos los datos por medio de las propiedades
        /// </summary>
        /// <param name="Marca">Marca del procesador</param>
        /// <param name="cpu">Procesador</param>
        /// <param name="placamadre">Placa madre</param>
        /// <param name="Gpu">Tarjeta grafica</param>
        /// <param name="memoriaRam">Memoria ram</param>
        /// <param name="fuente">Fuente</param>
        /// <param name="gabinete">Gabinete</param>
        /// <param name="sistemaOperativo">Sistema operativo</param>
        /// <param name="almacenamiento">Almacenamiento</param>
        /// <param name="lector">Lector</param>
        /// <param name="CodigoDeBarras">Codigo de barras</param>
        public FabricaPC(MarcaCPU Marca, Procesador cpu, Motherboard placamadre, GPU Gpu, RAM memoriaRam, Fuente fuente, Gabinete gabinete,
                                        SistemaOP sistemaOperativo, Almacenamiento almacenamiento, bool lector, int CodigoDeBarras) :
                                                     base(Marca, Gpu, memoriaRam, sistemaOperativo, almacenamiento, CodigoDeBarras)
        {
            try
            {
                FUENTE = fuente;
                PROCESADOR = cpu;
                LECTOR_CD = lector;
                GABINETE = gabinete;
                PLACA_MADRE = placamadre;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrescribe la informacion de Producto y muestra toda la informacion de la PC fabricada
        /// </summary>
        /// <returns>Retorna la informacion completa de la PC</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                if (NoMostrar())
                {
                    sb.AppendLine("La pc ingresada no tiene componentes compatibles...");
                }
                else
                {
                    string infoPc = String.Format(" \n Procesador: {0} \n Motherboard: {1} \n Gabinete: {2} \n Fuente {3} \n Lector CD: {4}" +
                         "\n----------------------------------------------------------------------------\n\n", Fix(PROCESADOR.ToString()),
                                        Fix(PLACA_MADRE.ToString()), Fix(GABINETE.ToString()), Fix(FUENTE.ToString()), BoolFix(LECTOR_CD));
                    sb.AppendLine("------------------------------------ PC ------------------------------------");
                    sb.Append(base.Informacion());
                    sb.Append(infoPc);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del to string para mostrar la informacion
        /// </summary>
        /// <returns>Retorna el metodo Informacion</returns>
        public override string ToString()
        {
            return Informacion();
        }

        /// <summary>
        /// Sobrescribe el metodo nomostar de producto para usar 2 filtros mas 
        /// </summary>
        /// <returns>Retorna un booleano indicando si la PC tiene componentes compatibles o no</returns>
        public override bool NoMostrar()
        {
            bool retorno = false;

            try
            {
                if (base.NoMostrar())
                {
                    Console.WriteLine("PC...");
                    retorno = true;
                }
                else if (PROCESADOR == 0)
                {
                    Console.WriteLine("El procesador ingresado no corresponde a la marca seleccionada: " + this.MARCA_CPU);
                    retorno = true;
                }
                else if (PLACA_MADRE == 0)
                {
                    Console.WriteLine("La mother ingresada no corresponde a el procesador seleccionado: " + this.PROCESADOR);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        #region Validacion propiedad
        /// <summary>
        /// Valida que la motherboard sea compatible con el procesador ingresado
        /// </summary>
        /// <param name="mother">Motherboard a ser validada</param>
        /// <param name="cpu">Procesador</param>
        /// <returns>Retorna un booleano indicando si la mother es compatible o no</returns>
        private bool ValidarMotherboard(Motherboard mother, Procesador cpu)
        {
            bool retorno = false;

            try
            {
                if ((int)cpu >= 1151 && (int)cpu < 1200 && (int)mother >= 1151 && (int)mother < 1200 || ((int)cpu >= 21151 && (int)cpu < 30000 && (int)mother >= 21151 && (int)mother < 30000 || (int)cpu >= 1200 && (int)cpu < 1300 && (int)mother >= 1200 && (int)mother < 1300))
                {
                    retorno = true;
                }
                else if ((int)cpu >= 40000 && (int)cpu < 50000 && (int)mother >= 40000 && (int)mother < 50000)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el procesaor sea compatible con la marca ingresada
        /// </summary>
        /// <param name="cpu">Procesador a ser validado</param>
        /// <param name="marca">Marca</param>
        /// <returns>Retorna un booleano indicando si el procesador es compatible o no</returns>
        private bool ValidarProcesador(Procesador cpu, MarcaCPU marca)
        {
            bool retorno = false;

            try
            {
                if ((int)marca == 2 && (int)cpu >= 1151 && (int)cpu < 30000)
                {
                    retorno = true;
                }
                else if ((int)marca == 1 && (int)cpu >= 40000 && (int)cpu < 50000)
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }
        #endregion

        #endregion

        #region Validaciones de propiedades override
        /// <summary>
        /// Metodo que se utiliza en la propiedad Procesador para validar si el procesador es compatible o no
        /// </summary>
        /// <param name="marca">Marca a ser validada</param>
        /// <returns>Retrona un booleano indicando si la marca es compatible o no con la PC</returns>
        public override bool ValidarMarca(MarcaCPU marca)
        {
            bool retorno = false;

            try
            {
                if ((int)marca == 1 || (int)marca == 2)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad GRAFICOS para validar si el chip grafico es compatible o no
        /// </summary>
        /// <param name="placa">Chip grafico a ser validado</param>
        /// <returns>Retrona un booleano indicando si la GPU es compatible o no con la PC</returns>
        public override bool ValidarGpu(GPU placa)
        {
            bool retorno = false;

            try
            {
                if ((int)placa >= 1 && (int)placa < 50)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad MEMORIA_RAM para validar si la ram es compatible o no
        /// </summary>
        /// <param name="ram">Memoria ram a ser validada</param>
        /// <returns>Retrona un booleano indicando si la RAM es compatible o no con la PC</returns>
        public override bool ValidarRam(RAM ram)
        {
            bool retorno = false;

            try
            {
                if ((int)ram >= 1 && (int)ram < 40)
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad SISTEMA_OPERATIVO para validar si el sistema operativo es compatible o no
        /// </summary>
        /// <param name="SO">Sistema operativo a ser validado</param>
        /// <returns>Retrona un booleano indicando si el sistema operativo es compatible o no con la PC</returns>
        public override bool ValidarSistemaOperativo(SistemaOP SO)
        {
            bool retorno = false;

            try
            {
                if ((int)SO >= 1 && (int)SO < 20)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad ALMACENAMIENTO para validar si el almacenamiento es compatible o no
        /// </summary>
        /// <param name="almacenamiento">Almacenamiento a ser validado</param>
        /// <returns>Retrona un booleano indicando si el almacenamiento es compatible o no con la PC</returns>
        public override bool ValidarAlmacenamiento(Almacenamiento almacenamiento)
        {
            bool retorno = false;

            try
            {
                if ((int)almacenamiento >= 1 && (int)almacenamiento < 60)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }


            return retorno;
        }
        #endregion

        #region Equals & GetHashCode
        /// <summary>
        /// Sobrecarga del operador equals
        /// </summary>
        /// <param name="obj">objeto a ser comparado</param>
        /// <returns>Retorna true si los productos tienen el mismo codigo de barras o si tienen un componente incompatible</returns>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// sobrecarga del GetHashCode para que no aparezca el warning
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
