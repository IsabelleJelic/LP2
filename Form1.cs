using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{

    public partial class Form1 : Form
    {
        Double Numero1;
        Double Numero2;
        public static string nome;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

            txtNum1.Focus();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out Numero1
              ) && Double.TryParse(txtNum2.Text, out Numero2))
            {
                double resultado;
                resultado = Numero1 + Numero2;
                txtResultado.Text = resultado.ToString();
            }

            else
            {
                MessageBox.Show("Valor Inválido");
                txtNum1.Focus();
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out Numero1
               ) && Double.TryParse(txtNum2.Text, out Numero2))
            {
                double resultado;
                resultado = Numero1 - Numero2;
                txtResultado.Text = resultado.ToString();
            }

            else
            {
                MessageBox.Show("Valor Inválido");
                txtNum1.Focus();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out Numero1
    ) && Double.TryParse(txtNum2.Text, out Numero2))
            {
                double resultado;
                resultado = Numero1 *  Numero2;
                txtResultado.Text = resultado.ToString();
            }

            else
            {
                MessageBox.Show("Valor Inválido");
                txtNum1.Focus();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtNum1.Text, out Numero1
                 ) && Double.TryParse(txtNum2.Text, out Numero2))
            {
                if (Numero2 == 0)
                {
                    MessageBox.Show("Número 2 não pode ser igual a zero!");
                    txtNum2.Focus();
                }
                else
                {
                    double resultado;
                    resultado = Numero1 / Numero2;
                    txtResultado.Text = resultado.ToString();
                }
            }

            else
            {
                MessageBox.Show("Valor Inválido");
                txtNum1.Focus();
            }
        }

        private void txtNumero(object sender, EventArgs e)
        {
            if ((txtNum1.Text == "") && (txtNum2.Text == ""))
                this.Close();
            else if (!Double.TryParse(txtNum1.Text, out Numero1))
            {
                MessageBox.Show("Valor é inválido!");
                txtNum1.Focus();
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if ((txtNum1.Text == "") && (txtNum2.Text == ""))
                this.Close();
            else if (!Double.TryParse(txtNum1.Text, out Numero1))
            {
                MessageBox.Show("Valor é inválido!");
                txtNum2.Focus();
            }

        }
    }
}
