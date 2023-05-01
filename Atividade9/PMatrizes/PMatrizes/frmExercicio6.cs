using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PMatrizes
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string valorN = Interaction.InputBox("Informe o valor de N:");
            int N;
            while (!int.TryParse(valorN, out N))
            {
                MessageBox.Show("O valor deve ser um número inteiro válido.");
                valorN = Interaction.InputBox("Informe o valor de N:");
            }

            string[] nomes = new string[N];
            int[] caracteres = new int[N];
            string nome = "";
            int result;

            for (int i = 0; i < N; i++)
            {
                nome = Interaction.InputBox($"Nome da {i + 1} pessoa: ", "Registro de Nomes");
                while (nome == string.Empty || int.TryParse(nome, out result))
                {
                    MessageBox.Show("O campo não pode estar vazio e não pode ser um número.");
                    nome = Interaction.InputBox($"Nome da {i + 1} pessoa: ", "Registro de Nomes");
                }

                int chars = 0;
                nomes[i] = nome;
                foreach (char letra in nome)
                {
                    if (!char.IsWhiteSpace(letra))
                    {
                        chars++;
                    }
                }
                caracteres[i] = chars;
            }
            for (int i = 0; i < N; i++)
            {
                lstbxExecutar.Items.Add($"O nome: {nomes[i]} tem {caracteres[i]} caracteres.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstbxExecutar.Items.Clear();
        }
    }
}
