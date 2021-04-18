using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor que inicializa el parametro numero en 0
        /// </summary>
        public Numero ()
        {
            this.numero = 0;
        }


        /// <summary>
        /// Constructor que inicializa el parametro numero un double ingresado por el usuario
        /// </summary>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que inicializa el parametro numero un string ingresado por el usuario
        /// </summary>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// Sobrecarga de operador +
        /// </summary>
        /// <param name="n1">Priemer numero para la operacion</param>
        /// <param name="n2">Segundo numero para la operacion</param>
        /// <returns>Resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero + n2.numero;

            return resultado;
        }

        /// <summary>
        /// Sobrecarga de operador -
        /// </summary>
        /// <param name="n1">Priemer numero para la operacion</param>
        /// <param name="n2">Segundo numero para la operacion</param>
        /// <returns>Resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero - n2.numero;

            return resultado;
        }

        /// <summary>
        /// Sobrecarga de operador *
        /// </summary>
        /// <param name="n1">Priemer numero para la operacion</param>
        /// <param name="n2">Segundo numero para la operacion</param>
        /// <returns>Resultado de la multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;

            resultado = n1.numero * n2.numero;

            return resultado;
        }

        /// <summary>
        /// Sobrecarga de operador /
        /// </summary>
        /// <param name="n1">Priemer numero para la operacion</param>
        /// <param name="n2">Segundo numero para la operacion</param>
        /// <returns>Resultado de la division, en caso de ser 0 el segundo numero retorna MinValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;

            if(n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }

            return resultado;
        }

        /// <summary>
        /// Convierte un numero de binario como string a decimal como string
        /// </summary>
        /// <param name="binario">String del numero binario a ser convertido</param>
        /// <returns>Retorna el numero binario convertido a decimal en forma de string, caso contrario retorna valor invalido</returns>
        public string BinarioDecimal(string binario)
        {
            bool esBinario;

            esBinario = EsBinario(binario);

            if (esBinario)
            {
                char[] array = binario.ToCharArray();
                Array.Reverse(array);

                int suma = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        if (i == 0)
                        {
                            suma += 1;
                        }
                        else
                        {
                            suma += (int)Math.Pow(2, i);
                        }
                    }
                }
                return Convert.ToString(suma);

            }
            else
            {
                return "Valor invalido";
            }
        }

        /// <summary>
        /// Convierte un numero de decimal como double a binario como string
        /// </summary>
        /// <param name="numero">Double del numero decimal a ser convertido en binario</param>
        /// <returns>Retorna el numero decimal convertido a binario en forma de string, caso contrario retorna valor invalido</returns>
        public string DecimalBinario(double numero)
        {
            bool esNumero;
            string retorno = "";

            esNumero = int.TryParse(numero.ToString(), out int auxNumero);

            if (esNumero)
            {
                if (auxNumero > 0)
                {
                    int aux;
                    string auxString;

                    while (auxNumero > 0)
                    {
                        aux = auxNumero % 2;
                        auxString = Convert.ToString(aux);
                        retorno = auxString + retorno;
                        auxNumero /= 2;
                    }
                    return retorno;
                }
                else
                {
                    retorno = "0";
                }
            }
            else
            {
                retorno = "Valor invalido";
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un numero de decimal como string a binario como string
        /// </summary>
        /// <param name="numero">String del numero decimal a ser convertido en binario</param>
        /// <returns>Retorna el numero decimal convertido a binario en forma de string, caso contrario retorna valor invalido</returns>
        public string DecimalBinario(string numero)
        {
            bool esNumero;
            string retorno = "";

            esNumero = int.TryParse(numero.ToString(), out int auxNumero);

            if (esNumero)
            {
                if (auxNumero > 0)
                {
                    int aux;
                    string auxString;

                    while (auxNumero > 0)
                    {
                        aux = auxNumero % 2;
                        auxString = Convert.ToString(aux);
                        retorno = auxString + retorno;
                        auxNumero /= 2;
                    }
                    return retorno;
                }
                else
                {
                    retorno = "0";
                }
            }
            else
            {
                retorno = "Valor invalido";
            }

            return retorno;
        }

        /// <summary>
        /// Verifica si todos los elementos que componen el numero binario son '1' y '0'
        /// </summary>
        /// <param name="binario">String del numero binario a validar</param>
        /// <returns>Retorna falso si el numero ingresado contiene caracteres que no son '1' y '0'</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] == '0' || binario[i] == '1')
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el numero ingresado como string sea un numero
        /// </summary>
        /// <param name="strNumero">String a ser validado</param>
        /// <returns>Retorna el numero ingresado transformado en double en caso de ser posible</returns>
        public double ValidarNumero(string strNumero)
        {
            if (!double.TryParse(strNumero, out double NumeroAux))
            {
                NumeroAux = 0;
            }

            return NumeroAux;
        }

        /// <summary>
        /// Setea el numero en forma de string a numero en forma decimal
        /// </summary>
        public String SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

    }
}
