using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Archivos<T> where T : IProductos
    {
        #region Metodos archivos

        /// <summary>
        /// Metodo el cual se encarga de guardar todos las excepciones en archivos de texto
        /// </summary>
        /// <param name="error">La excepcion a ser guardada en el archivo</param>
        public static void LogErrores(string error)
        {
            string CarpetaExcepciones = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\LogErrores";

            try
            {
                if (!Directory.Exists(CarpetaExcepciones))
                {
                    Directory.CreateDirectory(CarpetaExcepciones);
                }

                CarpetaExcepciones += @"\Error Rocha Francisco Hora " + DateTime.Now.ToString("HH_mm_ss") + ".txt";

                using (StreamWriter Error = new StreamWriter(CarpetaExcepciones, true))
                {
                    Error.WriteLine(error);
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Metodo que se encarga de guardar el almacen de productos fabricados en un XML
        /// </summary>
        /// <param name="Datos">Almacen a ser serializado</param>
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
            }
            catch (Exception ex)
            {
                LogErrores(ex.ToString());
            }

            return Datos;
        }
        #endregion
    }
}
