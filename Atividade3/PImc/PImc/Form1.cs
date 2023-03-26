using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImc
{
    public partial class Form1 : Form
    {
        double altura, peso, IMC;

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido!");
                txtPeso.Focus();
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
                txtAltura.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtAltura.Text, out altura) &&
                 double.TryParse(txtPeso.Text, out peso)))

            {
                if ((peso <= 0) || (altura <= 0))
                    MessageBox.Show("Os valores devem ser maiores que ZERO (0)!");

                else
                {
                    peso = peso * 100;
                    IMC = (peso / Math.Pow(altura, 2)) / 100;
                    IMC = Math.Round(IMC, 1);
                    txtIMC.Text = IMC.ToString("N1");

                    if (IMC < 18.5)
                        MessageBox.Show("Classificação: magreza. \r\nGrau de obesidade: 0.");
                    else if (IMC <= 24.9)
                        MessageBox.Show("Classificação: normal. \r\nGrau de obesidade: 0.");
                    else if (IMC <= 29.9)
                        MessageBox.Show("Classificação: sobrepeso. \r\nGrau de obesidade: I.");
                    else if (IMC <= 39.9)
                        MessageBox.Show("Classificação: obesidade. \r\nGrau de obesidade: II.");
                    else
                        MessageBox.Show("Classificação: obesidade grave. \r\nGrau de obesidade: III.");
                }
            }
            else
                MessageBox.Show("Valores inválidos.");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtIMC.Clear();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
