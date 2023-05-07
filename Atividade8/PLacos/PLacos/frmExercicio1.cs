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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnEspaco_Click(object sender, EventArgs e)
        {
            int temespaco = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                    temespaco++;
            }
            MessageBox.Show("O nº de espaços em branco é: " + temespaco.ToString());
        }

        private void BtnPares_Click(object sender, EventArgs e)
        {
            //char anterior = '\0';
            //int pares = 0;
            //for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            //{
            //    if (rchtxtFrase.Text[i] == anterior)
            //        pares += 1;

            //    anterior = rchtxtFrase.Text[i];
            //}
            //MessageBox.Show("Nº de pares de letras: " + pares.ToString());

            int pares = 0;
            
            for (var i = 0; i < rchtxtFrase.Text.Length-1; i++)
            {
                if (rchtxtFrase.Text[i] == rchtxtFrase.Text[i + 1])
                    pares += 1;
            }
            MessageBox.Show("Nº pares de letras: " + pares.ToString());
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            string texto;

            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                texto = rchtxtFrase.Text.ToLower();
                if (texto[i] == 'r')
                    quantidade++;
            }
            MessageBox.Show("O nº de letras R no texto é: " + quantidade.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rchtxtFrase.Clear();
        }
    }
}
