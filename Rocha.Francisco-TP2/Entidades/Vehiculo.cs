using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo  
    {
        #region "Atributos"
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Retornará el tamaño en formato Enum
        /// </summary>
        protected abstract ETamanio Tamanio { get; }
        #endregion

        #region "Enum"
        /// <summary>
        /// Lista de elementos de tipo enmum de Marcas
        /// </summary>
        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }

        /// <summary>
        /// Lista de elementos de tipo enmum de Tamaños
        /// </summary>
        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor unico de vehiculo
        /// </summary>
        /// <param name="chasis">Le asigna un chasis al atributo chasis</param>
        /// <param name="marca">Le asigna una marca al atributo marca</param>
        /// <param name="color">Le asigna un color al atributo color</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que se sobrescribe en las clases que heredan de vehiculo
        /// </summary>
        /// <returns>La informacion del vehiculo utilizando el explicit string</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Sobrecarca explicita del operador string retornando los datos del vehiculo
        /// </summary>
        /// <param name="p">Vehiculo del cual se toman los datos</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.Append("---------------------\n");

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Sobrecarga del operador igual entre dos vehiculos
        /// </summary>
        /// <param name="v1">primer vehiculo</param>
        /// <param name="v2">segundo vehiculo a ser comparado con el primero</param>
        /// <returns>retorna si los chasis de los vehiculos son iguales</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (((object)v1) == null && ((object)v2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)v1) != null && ((object)v2) != null)
                {
                    if (v1.chasis == v2.chasis)
                    {
                        retorno = true;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador distinto entre dos vehiculos
        /// </summary>
        /// <param name="v1">Primer vehiculo</param>
        /// <param name="v2">Segundo vehiculo a ser comparado con el primero</param>
        /// <returns>Retorna el valor negado de la sobrecarga de igualacion</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
