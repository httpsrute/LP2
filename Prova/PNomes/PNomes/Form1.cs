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

namespace PNomes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNomes_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            string[] guardar = new string[10];
            string auxiliar = "";

            for (int i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite o nome " + (i + 1).ToString(), "Entrada de dados");

                if (string.IsNullOrWhiteSpace(auxiliar) || auxiliar.Length < 2)
                {
                    MessageBox.Show("Nome inválido");
                    i--;
                }
                else
                {
                    nomes[i] = auxiliar;
                    guardar[i] = auxiliar.Replace(" ", "");
                }
            }

            for (int i = 0; i < 10; i++)
                lstbxNomes.Items.Add("O nome: " + nomes[i] + " tem " + guardar[i].Length + " caracteres.");
        }
    }


}