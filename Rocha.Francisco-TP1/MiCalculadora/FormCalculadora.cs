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

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;

            resultado = Operar(Numero1.Text,Numero2.Text,Operador.Text);

            Resultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        { 
            if(Resultado.Text != null)
            {
                Numero binario = new Numero(Resultado.Text);

                Resultado.Text = binario.DecimalBinario(Resultado.Text);
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            Numero binario = new Numero(Resultado.Text);

            Resultado.Text = binario.BinarioDecimal(Resultado.Text);
        }

        private void Limpiar()
        {
            this.Numero1.Clear();
            this.Numero2.Clear();
            this.Operador.Text = "";
            this.Resultado.Text = null;
        }

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
