using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"
        /// <summary>
        /// Unico constructor publico que asigna inicializa Suv
        /// </summary>
        /// <param name="marca">Le asigna un chasis al atributo chasis de vehiculo</param>
        /// <param name="chasis">Le asigna una marca al atributo marca de vehiculo</param>
        /// <param name="color">Le asigna un color al atributo color de vehiculo</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {

        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sobrecarga la propiedad de tipo Enum llamada ETamanio asignandole "Grande"
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que sobrescribe al de la clase base mostrando la informacion de Vehiculo y Suv
        /// </summary>
        /// <returns>Retorna la informacion de Suv y Vehiculo en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.Append("---------------------\n");

            return sb.ToString();
        }
        #endregion
    }
}
