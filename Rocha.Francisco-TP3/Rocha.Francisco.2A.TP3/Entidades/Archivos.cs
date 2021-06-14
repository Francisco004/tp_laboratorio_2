using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Reflection;
using System.Xml.Serialization;

namespace Entidades
{
    public class Archivos<T> where T : IProductos
    {
        #region Metodos archivos

        /// <summary>
        /// Metodo el cual se encarga de guardar todos las excepciones en archivos de texto
        /// </summary>
        /// <param name="error"></param>
        public static void LogErrores(string error)
        {
            try
            {
                string Base = AppDomain.CurrentDomain.BaseDirectory;
                string Carpeta = System.IO.Path.Combine(Base, @"..\..\..\LogErrores\");
                string PathCarpeta = Path.GetFullPath(Carpeta);

                string RutaLogERROR = PathCarpeta + "LogErrores_" + DateTime.Now.ToString("HH_mm_ss") + ".txt";

                using (StreamWriter Error = new StreamWriter(RutaLogERROR, true))
                {
                    Error.WriteLine(error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Metodo que se encarga de guardar el almacen de productos fabricados en un XML
        /// </summary>
        /// <param name="Datos"></param>
        public static void GuardarFabrica(AlmacenProdutosFabricados<T> Datos)
        {
            try
            {
                using (XmlTextWriter auxArchivo = new XmlTextWriter(Datos.Directorio, Encoding.UTF8))
                {
                    XmlSerializer auxEscritor = new XmlSerializer(typeof(AlmacenProdutosFabricados<T>));

                    auxEscritor.Serialize(auxArchivo, Datos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LogErrores(ex.ToString());
            }
        }

        /// <summary>
        /// Metodo el cual se encarga de cargarle los datos de un XML a un almacen de productos fabricados
        /// </summary>
        /// <param name="Datos">Almacen a ser cargado con los datos</param>
        /// <returns>Retorna el almacen con los productos fabricados</returns>
        public static AlmacenProdutosFabricados<T> CargarFabrica(AlmacenProdutosFabricados<T> Datos)
        {
            try
            {
                if (File.Exists(Datos.Directorio))
                {
                    using (XmlTextReader auxArchivoLeer = new XmlTextReader(Datos.Directorio))
                    {
                        XmlSerializer auxLector = new XmlSerializer(typeof(AlmacenProdutosFabricados<T>));

                        Datos = (AlmacenProdutosFabricados<T>)auxLector.Deserialize(auxArchivoLeer);
                    }
                }
                else
                {
                    Console.WriteLine("No existe el archivo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LogErrores(ex.ToString());
            }

            return Datos;
        }
        #endregion
    }
}
