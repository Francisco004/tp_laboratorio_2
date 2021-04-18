using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el si el operador ingresado es "+" "-" "*" "/" 
        /// </summary>
        /// <param name="operador">Caracter que funcionara como operador</param>
        /// <returns>Retorna el operador ingresado en forma de string</returns>
        private static string ValidarOperador (char operador)
        {
            string retorno = "+";

            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                retorno = operador.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// Realiza la operacion deseada con los numeros ingresador por el usuario
        /// </summary>
        /// <param name="num1">Primer numero operador</param>
        /// <param name="num2">Segundo numero operando</param>
        /// <param name="operador">Operador con el que se realiza la cuenta</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            operador = ValidarOperador(Convert.ToChar(operador));

            switch(operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado; 
        }
    }
}
