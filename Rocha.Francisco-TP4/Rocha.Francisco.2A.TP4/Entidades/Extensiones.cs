using System;
using System.Text;

namespace Entidades
{
    public static class Extensiones
    {
        #region Metodos 

        #region Fixeos

        /// <summary>
        /// Metodo para rempalzar los _ de los enum por puntos '.', en caso de iniciar con _ elimina el caracter
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="arreglar">String a ser arreglado por el metodo</param>
        /// <returns>Retorna el string ingresado pero sin guines bajos</returns>
        public static string Fix(this IProductos extension, string arreglar)
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
                        correcion[i] = ' ';
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
        /// Metodo el cual transforma un booleano a un string
        /// </summary>
        /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="tiene">Booleano a ser convertido a string</param>
        /// <returns>Retorna Tiene si el booleano ingresado es true, caso contrario No tiene</returns>
        public static string BoolFix(this IProductos extension, bool tiene)
        {
            string retorno = "No tiene";

            if (tiene == true)
            {
                retorno = "Tiene";
            }

            return retorno;
        }

        /// <summary>
        /// Metodo el cual transforma un entero a un booleano
        /// </summary>
        /// /// /// <param name="extension">Extension de la clase ISQL</param>
        /// <param name="index">Entero a ser convertido a booleano</param>
        /// <returns>Retorna true si el entero ingresado es 0, caso contrario false</returns>
        public static bool BoolSelec(this ISQL extension, int index)
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

        #region Validaciones 

        /// <summary>
        /// Metodo que se utiliza en la propiedad Procesador para validar si el procesador es compatible o no
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="marca">Marca a ser validada</param>
        /// <returns>Retrona un booleano indicando si la marca es compatible o no con la PC</returns>
        public static bool ValidarMarca(this IProductos extension, MarcaCPU marca)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad GRAFICOS para validar si el chip grafico es compatible o no
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="placa">Chip grafico a ser validado</param>
        /// <returns>Retrona un booleano indicando si la GPU es compatible o no con la PC</returns>
        public static bool ValidarGpu(this IProductos extension, GPU placa)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad MEMORIA_RAM para validar si la ram es compatible o no
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="ram">Memoria ram a ser validada</param>
        /// <returns>Retrona un booleano indicando si la RAM es compatible o no con la PC</returns>
        public static bool ValidarRam(this IProductos extension, RAM ram)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad SISTEMA_OPERATIVO para validar si el sistema operativo es compatible o no
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="SO">Sistema operativo a ser validado</param>
        /// <returns>Retrona un booleano indicando si el sistema operativo es compatible o no con la PC</returns>
        public static bool ValidarSistemaOperativo(this IProductos extension, SistemaOP SO)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Metodo que se utiliza en la propiedad ALMACENAMIENTO para validar si el almacenamiento es compatible o no
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="almacenamiento">Almacenamiento a ser validado</param>
        /// <returns>Retrona un booleano indicando si el almacenamiento es compatible o no con la PC</returns>
        public static bool ValidarAlmacenamiento(this IProductos extension, Almacenamiento almacenamiento)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }


            return retorno;
        }

        /// <summary>
        /// Valida que la motherboard sea compatible con el procesador ingresado
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="mother">Motherboard a ser validada</param>
        /// <param name="cpu">Procesador</param>
        /// <returns>Retorna un booleano indicando si la mother es compatible o no</returns>
        public static bool ValidarMotherboard(this IProductos extension, Motherboard mother, Procesador cpu)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el procesaor sea compatible con la marca ingresada
        /// </summary>
        /// /// <param name="extension">Extension de la clase IProducto</param>
        /// <param name="cpu">Procesador a ser validado</param>
        /// <param name="marca">Marca</param>
        /// <returns>Retorna un booleano indicando si el procesador es compatible o no</returns>
        public static bool ValidarProcesador(this IProductos extension, Procesador cpu, MarcaCPU marca)
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
                Archivos<Producto>.LogErrores(ex.ToString());
            }

            return retorno;
        }
        #endregion

        #region Exepciones
        /// <summary>
        /// Metodo que informa la excepcion ocurrida
        /// </summary>
        /// <param name="excepcion">Extension de la clase NoSeEncontroException</param>
        /// <returns>Retorna un string con el mensaje de la excepcion</returns>
        public static string InformarExcepcion(this NoSeEncontroException excepcion)
        {
            return "No se encontro el UPC indicado";
        }

        /// <summary>
        /// Metodo que informa la excepcion ocurrida
        /// </summary>
        /// <param name="excepcion">Extension de la clase NoSeEncontroException</param>
        /// <returns>Retorna un string con el mensaje de la excepcion</returns>
        public static string InformarExcepcionSQL(this NoSeEncontroException excepcion)
        {
            return "No se pudo conectar a la base de datos";
        }
        #endregion

        #endregion
    }
}
