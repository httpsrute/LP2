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

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoA.Text, out ladoA))
            {
                MessageBox.Show("Valores inválidos.");
                txtLadoA.Focus();
            }
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoB.Text, out ladoB))
            {
                MessageBox.Show("Valores inválidos.");
                txtLadoB.Focus();
            }
        }

        private void txtLadoC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Valores inválidos.");
                txtLadoC.Focus();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtLadoA.Text, out ladoA)) &&
               (double.TryParse(txtLadoB.Text, out ladoB)) &&
               (double.TryParse(txtLadoC.Text, out ladoC)))

            {
                if ((ladoA <= 0) || (ladoB <= 0) || (ladoC <= 0))
                    MessageBox.Show("Os valores precisam ser maiores que ZERO (0)!");

                else
                {
                    if ((ladoA < (ladoB + ladoC)) &&
                       (ladoA > Math.Abs(ladoB - ladoC)) &&
                       (ladoB < (ladoA + ladoC)) &&
                       (ladoB > Math.Abs(ladoA - ladoC)) &&
                       (ladoC < (ladoA + ladoB)) &&
                       (ladoC > Math.Abs(ladoA - ladoB)))
                    {
                        if ((ladoA == ladoB) && (ladoB == ladoC))
                            MessageBox.Show("Triângulo equilátero.");
                        else
                            if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                            MessageBox.Show("Triângulo isósceles.");
                        else
                            MessageBox.Show("Triângulo escaleno");
                    }
                    else
                        MessageBox.Show("Os valores inseridos não formam um triângulo.");
                }
            }
            else
                MessageBox.Show("Valores inválidos.");
                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
