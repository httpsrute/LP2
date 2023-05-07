using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto1 = txtPalindromo.Text.ToLower().Replace(" ", "");
            string texto2 = "";

            if (texto1.Length < 50)
            {
                for (int i = texto1.Length - 1; i >= 0; i--)
                    texto2 += texto1[i];
                if (texto1.Equals(texto2))
                    MessageBox.Show("O texto é um palíndromo!");
                else
                    MessageBox.Show("O texto não é um palíndromo!");
            }
            else
                MessageBox.Show("O texto deve ter no máximo 50 caracteres!");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPalindromo.Clear();
        }
    }
}
