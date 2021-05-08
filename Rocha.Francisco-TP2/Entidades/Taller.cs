using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taller
    {
        #region "Atributos"
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        #endregion

        #region "Enum"
        /// <summary>
        /// Lista de elementos de tipo enmum de Tipos
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, 
            Sedan, 
            SUV, 
            Todos
        }
        #endregion

        #region "Constructores"

        /// <summary>
        /// Constructor privado de taller que crea una lista de vehiculos
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor publico que asigna espacio y llama al constructor privado
        /// </summary>
        /// <param name="espacioDisponible">Le asigna el espacio al espacioDisponible chasi</param>
        public Taller(int espacioDisponible):this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Sobrecargo el metodo ToString para listar todos los vehiculos
        /// </summary>
        /// <returns>Retorna el listado de todos los vehiculos</returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Metodo que muestra todos los vehiculos dependiendo el tipo pasado por parametro
        /// </summary>
        /// <param name="taller">la lista de vehiculos que posee taller</param>
        /// <param name="tipo">El Enum del tipo de vehiculo que se quiere mostrar</param>
        /// <returns>Retorna la lista de vehiculos en forma de string</returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\n", taller.vehiculos.Count, taller.espacioDisponible);

            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Todos:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="taller">Taller al cual se le añade el vehiculo</param>
        /// <param name="vehiculo">Vehiculo a ser añadido en el taller</param>
        /// <returns>Retorna el taller con el vehiculo agregado en caso de ser posible</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            int bandera = 0;

            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    bandera = 1;
                    break;
                }
            }

            if(bandera == 0 && taller.vehiculos.Count < taller.espacioDisponible)
            {
                taller.vehiculos.Add(vehiculo);
            }

            return taller;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// </summary>
        /// <param name="taller">Taller al cual se le elimina el vehiculo</param>
        /// <param name="vehiculo">Vehiculo a ser eliminado en el taller</param>
        /// <returns>Retorna el taller con el vehiculo eliminado en caso de ser posible</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(vehiculo);
                    break;
                }
            }

            return taller;
        }
        #endregion
    }
}
