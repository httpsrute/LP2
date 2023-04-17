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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            int posicao = 0;
            int cont = 0;

            for (cont = 0; cont < rtbConteudo.Text.Length; cont++)
            {
                if (char.IsNumber(rtbConteudo.Text[cont]))
                    posicao++;
            }
            MessageBox.Show("A quantidade de números existentes no componente é:\n " + posicao);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            if (!string.IsNullOrEmpty(rtbConteudo.Text))
                while (!char.IsWhiteSpace(rtbConteudo.Text[posicao]))
                {
                    if (posicao == rtbConteudo.TextLength - 1)
                    {
                        posicao = 0;
                        break;
                    }
                    posicao++;
                }
            MessageBox.Show("A posição do primeiro caractere em branco é:\n " + (posicao + 1));
        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {
            string stringona = rtbConteudo.Text.Trim();
            int totalalfa = 0;

            foreach (char alfa in stringona)
            {
                if (char.IsLetter(alfa))
                {
                    rtbConteudo.Text.ToLower();
                    totalalfa++;
                }
            }
            MessageBox.Show("A quantidade de caracteres alfabéticos existentes é:\n " + totalalfa);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbConteudo.Clear();
        }
    }
}
