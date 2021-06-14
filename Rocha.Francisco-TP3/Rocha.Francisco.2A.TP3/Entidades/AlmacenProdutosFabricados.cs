using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    [Serializable]
    public class AlmacenProdutosFabricados<T> where T : IProductos
    {
        #region Atributos
        private List<T> producto;
        private string directorio;
        private string nombreAlmacen;
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad que asigna y retorna el nombre al almacen de productos fabricados
        /// </summary>
        public string NombreAlmacen
        {
            get { return nombreAlmacen; }
            set { nombreAlmacen = value; }
        }

        /// <summary>
        /// Priepidad que setea y retorna los productos
        /// </summary>
        public List<T> Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        /// <summary>
        /// Propiedad a la cual se le pasa el directorio a ser utilizado para el XML
        /// </summary>
        public string Directorio
        {
            get { return directorio; }
            set { directorio = value; }
        }

        /// <summary>
        /// Propiedad la cual retorna la cantidad de productos fabricados en el almacen
        /// </summary>
        public int CantidadGenerica
        {
            get
            {
                try
                {
                    return producto.Count();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Archivos<Producto>.LogErrores(ex.ToString());
                    throw;
                }
            }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros el cual crea la lista de productos
        /// </summary>
        private AlmacenProdutosFabricados()
        {
            try
            {
                Producto = new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Constructor al que se le pasa el nombre por parametro
        /// </summary>
        /// <param name="nombre">Nombre del almacen</param>
        private AlmacenProdutosFabricados(string nombre) : this()
        {
            try
            {
                this.nombreAlmacen = nombre;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }
        }
        #endregion

        #region Sobrecarga

        /// <summary>
        /// Sobrecarga implicita la cual sirve para crear un almacen mediante el nombre ingresado
        /// </summary>
        /// <param name="nombre">Nombre del almacen</param>
        public static implicit operator AlmacenProdutosFabricados<T>(string nombre)
        {
            try
            {
                return new AlmacenProdutosFabricados<T>(nombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
                throw;
            }
        }

        /// <summary>
        /// Sobrecarga del operador pipe para verificar si un producto ya se encuentra ingresado o no
        /// </summary>
        /// <param name="h">Almacen</param>
        /// <param name="p">Producto</param>
        /// <returns>Retorna -1 en caso de que el producto no se encuentre en el almacen</returns>
        public static int operator |(AlmacenProdutosFabricados<T> h, T p)
        {
            int contador = 0;
            int retorno = -1;

            try
            {
                foreach (T personalito in h.Producto)
                {
                    if (personalito.Equals(p))
                    {
                        retorno = contador;
                        break;
                    }
                    contador++;
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
        /// Sobrecarga del operador + el cual agrega el producto al almacen
        /// </summary>
        /// <param name="h">Almacen</param>
        /// <param name="p">Producto</param>
        /// <returns></returns>
        public static AlmacenProdutosFabricados<T> operator +(AlmacenProdutosFabricados<T> h, T p)
        {
            int indice;

            try
            {
                indice = h | p;

                if (indice == -1)
                {
                    h.Producto.Add(p);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return h;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del tostring que retorna la informacion del almacen
        /// </summary>
        /// <returns>Retorna toda la informacion del almacen en caso de ser posible</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string informacion = String.Format("Almacen: " + this.NombreAlmacen + "\nCantidad de productos fabricados: " + this.producto.Count + "\n\nListado de productos: \n");

                sb.Append(informacion);

                foreach (T p in this.Producto)
                {
                    sb.AppendLine(p.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return sb.ToString();
        }
        #endregion
    }
}