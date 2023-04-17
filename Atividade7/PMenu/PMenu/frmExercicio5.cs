using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio5 : Form
    {
        int num1, num2;

        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("O sorteio só pode ser realizado entre números!");
            else if (num1 > num2)
                MessageBox.Show("O número 1 deve ser menor ou igual ao número 2, corrija.");
            else
            {
                Random aleatorio = new Random();
                double sorteio;
                sorteio = aleatorio.Next(num1, num2 + 1);
                MessageBox.Show("O número sorteado entre " + txtNum1.Text + " e " + txtNum2.Text + " é: \n" + sorteio);
            }
                 
        }

        private void txtNum2_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum2.Text, out num2))
                MessageBox.Show("O sorteio só pode ser realizado entre números!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void txtNum1_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out num1))
                MessageBox.Show("O sorteio só pode ser realizado entre números!");
        }
    }
}
