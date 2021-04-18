using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            Operador.Text = " ";
        }

        /// <summary>
        /// Boton para realizar la operacion seleccionada con los numeros ingresados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;

            resultado = Operar(Numero1.Text,Numero2.Text,Operador.Text);

            Resultado.Text = Convert.ToString(resultado);
        }

        /// <summary>
        /// Llama a la funcion limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Boton que convierte el numero decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBinario_Click(object sender, EventArgs e)
        { 
            if(Resultado.Text != null)
            {
                Numero binario = new Numero(Resultado.Text);

                Resultado.Text = binario.DecimalBinario(Resultado.Text);
            }
        }

        /// <summary>
        /// Boton que convierte un binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero(Resultado.Text);

            Resultado.Text = binario.BinarioDecimal(Resultado.Text);
        }

        /// <summary>
        /// Limpia del form los numeros, el operador y el resultado
        /// </summary>
        private void Limpiar()
        {
            this.Numero1.Clear();
            this.Numero2.Clear();
            this.Operador.Text = "";
            this.Resultado.Text = null;
        }

        /// <summary>
        /// Realiza la operacion con los numeros y el operador seleccionado
        /// </summary>
        /// <param name="numero1">Primer numero ingresado</param>
        /// <param name="numero2">Segundo numero ingresado</param>
        /// <param name="operador">Operador seleccionado</param>
        /// <returns>Retorna el valor de la operacion realizada</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);

            if(operador == "")
            {
                operador = "+";
            }

            return Entidades.Calculadora.Operar(n1, n2, operador);

        }

    }
}
