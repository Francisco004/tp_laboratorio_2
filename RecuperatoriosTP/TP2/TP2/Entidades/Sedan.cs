using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Atributos"

        private ETipo tipo;

        #endregion

        #region "Enum"
        /// <summary>
        /// Lista de elementos de tipo enmum de Tipos
        /// </summary>
        public enum ETipo 
        { 
          CuatroPuertas,
          CincoPuertas 
        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor de sedan que le asigna un tipo pasado por parametro al atributo "tipo"
        /// </summary>
        /// <param name="marca">Le asigna una marca al atributo marca de vehiculo</param>
        /// <param name="chasis">Le asigna un chasis al atributo chasis de vehiculo></param>
        /// <param name="color">Le asigna un color al atributo color de vehiculo</param>
        /// <param name="tipo">Le asigna un tipo al atributo tipo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor de sedan que asigna por defecto el valor "CuatroPuertas" al atributo "tipo"
        /// </summary>
        /// <param name="marca">Le asigna una marca al atributo marca de vehiculo</param>
        /// <param name="chasis">Le asigna un chasis al atributo chasis de vehiculo</param>
        /// <param name="color">Le asigna un color al atributo color de vehiculo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {

        }
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sobrecarga la propiedad de tipo Enum llamada ETamanio asignandole "Mediano"
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo que sobrescribe al de la clase base mostrando la informacion de Vehiculo y Sedan
        /// </summary>
        /// <returns>Retorna la informacion de Sedan y Vehiculo en formato string</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("\n---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
