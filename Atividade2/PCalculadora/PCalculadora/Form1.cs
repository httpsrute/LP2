using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double Numero1, Numero2, Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtNum1_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(txtNum1.Text, out Numero1))
                MessageBox.Show("Número inválido!");
        }

        private void TxtNum2_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(txtNum2.Text, out Numero2))
                MessageBox.Show("Número inválido!");
        }

        private void BtnMais_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out Numero1)) &&
               (double.TryParse(txtNum2.Text, out Numero2)))
            {
                Resultado = Numero1 + Numero2;
                txtResultado.Text = Resultado.ToString();
            }
            else
                MessageBox.Show("Número inválido!");
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out Numero1)) &&
              (double.TryParse(txtNum2.Text, out Numero2)))
            {
                Resultado = Numero1 - Numero2;
                txtResultado.Text = Resultado.ToString();
            }
            else
                MessageBox.Show("Número inválido!");
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out Numero1)) &&
              (double.TryParse(txtNum2.Text, out Numero2)))
            {
                Resultado = Numero1 * Numero2;
                txtResultado.Text = Resultado.ToString();
            }
            else
                MessageBox.Show("Número inválido!");
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out Numero1)) &&
              (double.TryParse(txtNum2.Text, out Numero2)))

            {
                if (Numero2 == 0)
                    MessageBox.Show("Não pode ser dividido por 0.");
                else
                {
                    Resultado = Numero1 / Numero2;
                    txtResultado.Text = Resultado.ToString();
                }
            }

            else
                MessageBox.Show("Número inválido!");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
