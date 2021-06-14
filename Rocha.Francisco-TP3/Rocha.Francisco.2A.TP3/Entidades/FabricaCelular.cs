using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class FabricaCelular : Producto
    {
        #region Atributos
        protected bool jack;
        protected bool huella;
        protected Camara camara;
        protected Bateria bateria;
        protected MaterialCarcasa carcasa;
        protected PantallaPulgadas pulgadas;
        protected PantallaResolucion resolucion;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad enum CAMARA que retorna la camara y setea el camara
        /// </summary>
        public Camara CAMARA { get => camara; set => camara = value; }

        /// <summary>
        /// Propiedad enum BATERIA que retorna la batertia y setea la bateria
        /// </summary>
        public Bateria BATERIA { get => bateria; set => bateria = value; }

        /// <summary>
        /// Propiedad enum CARCASA que retorna la carcasa y setea la carcasa
        /// </summary>
        public MaterialCarcasa CARCASA { get => carcasa; set => carcasa = value; }

        /// <summary>
        /// Propiedad enum PULGADAS que retorna las pulgadas y setea las pulgadas
        /// </summary>
        public PantallaPulgadas PULGADAS { get => pulgadas; set => pulgadas = value; }

        /// <summary>
        /// Propiedad enum RESOLUCION que retorna la resolucion y setea la resolucion
        /// </summary>
        public PantallaResolucion RESOLUCION { get => resolucion; set => resolucion = value; }

        /// <summary>
        /// Propiedad bool JACK que retorna un booleano indicando si tiene o no y setea un booleano indicando si tiene o no
        /// </summary>
        public bool JACK { get => jack; set => jack = value; }

        /// <summary>
        /// Propiedad bool HUELLA que retorna un booleano indicando si tiene o no y setea un booleano indicando si tiene o no
        /// </summary>
        public bool HUELLA { get => huella; set => huella = value; }

        #region Propiedades override

        /// <summary>
        /// Propiedad que retorna la marcay que setea la marca en caso de ser compatible con el celular
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
        /// Propiedad que retorna la GPU y que setea la GPU en caso de ser compatible con el celular
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
        /// Propiedad que retorna la RAM y que setea la RAM en caso de ser compatible con el celular
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
        /// Propiedad que retorna el Sistema operativo y que setea el Sistema operativo en caso de ser compatible con el celular
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
        /// Propiedad que retorna el almacenamiento y que setea el almacenamiento en caso de ser compatible con el celular
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
        public FabricaCelular()
        {

        }


        /// <summary>
        /// Constructor principal de FabricaPC el cual le asigna todos los datos por medio de las propiedades
        /// </summary>
        /// <param name="Marca">Marca</param>
        /// <param name="Gpu">Chip grafico</param>
        /// <param name="memoriaRam">Memoria ram</param>
        /// <param name="sistemaOperativo">Sistema operativo</param>
        /// <param name="almacenamiento">Almacenamiento</param>
        /// <param name="CodigoDeBarras">Codigo de barras </param>
        /// <param name="camara">Camara</param>
        /// <param name="bateria">Bateria</param>
        /// <param name="material">Material</param>
        /// <param name="pulgadas">Pulgadas</param>
        /// <param name="resolucion">Resolucion</param>
        /// <param name="jack">Jack</param>
        /// <param name="huella">Huella</param>
        public FabricaCelular(MarcaCPU Marca, GPU Gpu, RAM memoriaRam, SistemaOP sistemaOperativo, Almacenamiento almacenamiento, int CodigoDeBarras, Camara camara,
                                  Bateria bateria, MaterialCarcasa material, PantallaPulgadas pulgadas, PantallaResolucion resolucion, bool jack, bool huella) :
                                                                                base(Marca, Gpu, memoriaRam, sistemaOperativo, almacenamiento, CodigoDeBarras)
        {
            try
            {
                JACK = jack;
                HUELLA = huella;
                CAMARA = camara;
                BATERIA = bateria;
                CARCASA = material;
                PULGADAS = pulgadas;
                RESOLUCION = resolucion;
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
        /// Sobrescribe la informacion de Producto y muestra toda la informacion del Celular fabricado
        /// </summary>
        /// <returns>Retorna la informacion completa del Celular</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                string infoCelular = String.Format(" \n Camara: {0} \n Bateria: {1} \n Carcasa: {2} \n Pulgadas: {3} \n Resolucion: {4} \n Jack: {5} \n Huella dactilar: " +
                                    "{6}\n-----------------------------------------------------------------------------\n\n", Fix(CAMARA.ToString()), Fix(BATERIA.ToString()),
                                                                              CARCASA, FixPulgadas(PULGADAS.ToString()), Fix(RESOLUCION.ToString()), BoolFix(JACK), BoolFix(HUELLA));
                if (NoMostrar())
                {
                    sb.AppendLine("La pc ingresada no tiene componentes compatibles...");
                }
                else
                {
                    sb.AppendLine("---------------------------------- Celular ---------------------------------");
                    sb.Append(base.Informacion());
                    sb.Append(infoCelular);
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
        /// Sobrescribe el metodo nomostar de producto para indicar que es un celular 
        /// </summary>
        /// <returns>Retorna un booleano indicando si el Celular tiene componentes compatibles o no</returns>
        public override bool NoMostrar()
        {
            bool retorno = false;

            try
            {
                if (base.NoMostrar())
                {
                    Console.WriteLine("Celular...");
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
        /// Sobrecarga del to string para mostrar la informacion
        /// </summary>
        /// <returns>Retorna el metodo Informacion</returns>
        public override string ToString()
        {
            return Informacion();
        }

        /// <summary>
        /// Metodo para rempalzar los _ de los enum por puntos '.', en caso de iniciar con _ elimina el caracter
        /// </summary>
        /// <param name="arreglar">String a ser arreglado por el metodo</param>
        /// <returns>Retorna el string ingresado pero sin guines bajos</returns>
        public string FixPulgadas(string arreglar)
        {
            StringBuilder correcion = new StringBuilder(arreglar);

            try
            {
                for (int i = 0; i < correcion.Length; i++)
                {
                    if (correcion[i] == '_' && i == 0)
                    {
                        correcion.Remove(0, 1);
                    }
                    else if (correcion[i] == '_')
                    {
                        correcion[i] = '.';
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return correcion.ToString();
        }
        #endregion

        #region Validaciones de propiedades override

        /// <summary>
        /// Metodo que se utiliza en la propiedad Procesador para validar si el procesador es compatible o no
        /// </summary>
        /// <param name="marca">Marca a ser validada</param>
        /// <returns>Retrona un booleano indicando si la marca es compatible o no con el celular</returns>
        public override bool ValidarMarca(MarcaCPU marca)
        {
            bool retorno = false;

            try
            {
                if ((int)marca >= 3 || (int)marca <= 6)
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
        /// <returns>Retrona un booleano indicando si la GPU es compatible o no con el celular</returns>
        public override bool ValidarGpu(GPU placa)
        {
            bool retorno = false;

            try
            {
                if ((int)placa >= 50 && (int)placa < 70)
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
        /// <returns>Retrona un booleano indicando si la RAM es compatible o no con el celular</returns>
        public override bool ValidarRam(RAM ram)
        {
            bool retorno = false;

            try
            {
                if ((int)ram >= 40 && (int)ram < 50)
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
        /// Metodo que se utiliza en la propiedad SISTEMA_OPERATIVO para validar si el sistema operativo es compatible o no
        /// </summary>
        /// <param name="SO">Sistema operativo a ser validado</param>
        /// <returns>Retrona un booleano indicando si el sistema operativo es compatible o no con el celular</returns>
        public override bool ValidarSistemaOperativo(SistemaOP SO)
        {
            bool retorno = false;

            try
            {
                if ((int)SO >= 20 && (int)SO < 40)
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
        /// <returns>Retrona un booleano indicando si el almacenamiento es compatible o no con el celular</returns>

        public override bool ValidarAlmacenamiento(Almacenamiento almacenamiento)
        {
            bool retorno = false;

            try
            {
                if ((int)almacenamiento >= 60 && (int)almacenamiento < 70)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
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
