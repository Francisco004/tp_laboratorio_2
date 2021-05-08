using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Unico constructor de Ciclomotor
        /// </summary>
        /// <param name="marca">Le asigna una marca al atributo marca de vehiculo</param>
        /// <param name="chasis">Le asigna un chasis al atributo chasis de vehiculo</param>
        /// <param name="color">Le asigna un color al atributo color de vehiculo</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {

        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sobrecarga la propiedad de tipo Enum llamada ETamanio asignandole "Chico"
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que sobrescribe al de la clase base mostrando la informacion de Vehiculo y Ciclomotor
        /// </summary>
        /// <returns>Retorna la informacion de Ciclomotor y Vehiculo en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
