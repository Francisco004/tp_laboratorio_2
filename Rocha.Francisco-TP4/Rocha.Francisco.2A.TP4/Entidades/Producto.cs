using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(FabricaPC))]
    [XmlInclude(typeof(FabricaCelular))]
    
    public class Producto : IProductos
    {
        #region Atributos
        protected int UPC;
        protected GPU graficos;
        protected RAM memoriaRam;
        protected MarcaCPU procesador;
        protected SistemaOP sistemaOperativo;
        protected Almacenamiento almacenamiento;
        #endregion

        #region Propiedades 

        public virtual GPU GRAFICOS {get => graficos; set => graficos = value; }

        public virtual int CODIGO_DE_BARRAS { get => UPC; set => UPC = value; }

        public virtual RAM MEMORIA_RAM { get => memoriaRam; set => memoriaRam = value; }

        public virtual MarcaCPU MARCA_CPU { get => procesador; set => procesador = value; }

        public virtual SistemaOP SISTEMA_OPERATIVO { get => sistemaOperativo; set => sistemaOperativo = value; }

        public virtual Almacenamiento ALMACENAMIENTO { get => almacenamiento; set => almacenamiento = value; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor vacio para el XML
        /// </summary>
        public Producto()
        {

        }

        /// <summary>
        /// Constructor de producto el cual se usa en PC Y Celular el cual asigna los valores mediante las propiedades
        /// </summary>
        /// <param name="Marca">Marca del producto</param>
        /// <param name="Gpu">Chip grafico del producto</param>
        /// <param name="memoriaRam">Memoria ram del producto</param>
        /// <param name="sistemaOperativo">Sistema operativo del producto</param>
        /// <param name="almacenamiento">Almacenamiento del producto</param>
        /// <param name="CodigoDeBarras">Codigo de barras "UPC" del producto</param>
        public Producto (MarcaCPU Marca, GPU Gpu, RAM memoriaRam, SistemaOP sistemaOperativo, Almacenamiento almacenamiento, int CodigoDeBarras)
        {
            try
            {
                GRAFICOS = Gpu;
                MARCA_CPU = Marca;
                MEMORIA_RAM = memoriaRam;
                ALMACENAMIENTO = almacenamiento;
                SISTEMA_OPERATIVO = sistemaOperativo;
                CODIGO_DE_BARRAS = CodigoDeBarras;
            }
            catch (System.OverflowException ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                CODIGO_DE_BARRAS = Random();
            }
            catch (System.FormatException ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                CODIGO_DE_BARRAS = Random();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                CODIGO_DE_BARRAS = Random();
            }
        }
        #endregion

        #region Metodos

        #region Metodo para mostar
        /// <summary>
        /// Sobrecarga del to string para mostrar la informacion
        /// </summary>
        /// <returns>Retorna el metodo Informacion</returns>
        public override string ToString()
        {
            try
            {
                return Informacion();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                return ex.ToString();
            }
        }

        /// <summary>
        /// Muestra toda la informacion del producto
        /// </summary>
        /// <returns>Retorna la informacion completa del producto</returns>
        public virtual string Informacion()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                string informacion = String.Format(" Marca CPU: {0} \n GPU: {1} \n RAM: {2} \n Sistema operativo: {3} \n Almacenamiento: {4} \n " +
                                        "Codigo de barras: {5}", MARCA_CPU, this.Fix(GRAFICOS.ToString()), this.Fix(MEMORIA_RAM.ToString()), this.Fix(SISTEMA_OPERATIVO.ToString()), this.Fix(ALMACENAMIENTO.ToString()), CODIGO_DE_BARRAS);

                sb.Append(informacion);

                return sb.ToString();
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                return ex.ToString();
            }
        }
        #endregion

        #region Metodo para no mostrar

        /// <summary>
        /// Metodo que se utiliza en las clases PC Y Celular, hace que si el atributo de dichas clases no es compatible que no muestre el producto
        /// </summary>
        /// <returns>Retorna un booleano indicando si el producto tiene componentes compatibles o no</returns>
        public virtual bool NoMostrar()
        {
            bool retorno = false;

            try
            {
                if (MARCA_CPU == 0)
                {
                    retorno = true;
                }
                else if (GRAFICOS == 0)
                {
                    retorno = true;
                }
                else if (MEMORIA_RAM == 0)
                {
                    retorno = true;
                }
                else if (SISTEMA_OPERATIVO == 0)
                {
                    retorno = true;
                }
                else if (ALMACENAMIENTO == 0)
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
                return retorno;
            }
        }
        #endregion

        #region Metodo Random

        /// <summary>
        /// Metodo que genera un numero random por si ocurre alguna excepcion en el codigo de barras
        /// </summary>
        /// <returns>Retorna un numero random entre 100000000 y 999999999</returns>
        private int Random()
        {
            int aux;
            try
            {
                Random numeroRandom = new Random();
                aux = numeroRandom.Next(100000000, 999999999);
            }
            catch (Exception)
            {
                aux = 0;
            }

            return aux;
        }

        #endregion

        #endregion

        #region Sobrecarga 
        /// <summary>
        /// Sobrecarga del operador igual
        /// </summary>
        /// <param name="producto1">Primer producto a ser comparado</param>
        /// <param name="producto2">Segundo producto a ser comparado</param>
        /// <returns>Retorna true si los productos tienen el mismo codigo de barras o si tienen un componente incompatible</returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.Equals(producto2);
        }

        /// <summary>
        /// Sobrecarga del operador distinto
        /// </summary>
        /// <param name="producto1">Primer producto a ser comparado</param>
        /// <param name="producto2">Segundo producto a ser comparado</param>
        /// <returns>Retorna lo opuesto al operador igual</returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1.Equals(producto2));
        }

        /// <summary>
        /// Sobrecarga de Equals
        /// </summary>
        /// <param name="obj">Objeto a ser comparado</param>
        /// <returns>Retorna true si los productos tienen el mismo codigo de barras o si tienen un componente incompatible</returns>
        public override bool Equals(object obj)
        {
            bool booleano = false;

            try
            {
                if (((Producto)obj).NoMostrar() == true)
                {
                    booleano = true;
                }
                else if (((Producto)obj).CODIGO_DE_BARRAS == CODIGO_DE_BARRAS)
                {
                    booleano = true;
                }
                
            }
            catch (Exception ex)
            {
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return booleano;
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
