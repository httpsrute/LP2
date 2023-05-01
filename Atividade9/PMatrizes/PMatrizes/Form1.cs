using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";

            for (var i = 0; i < 20; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString(), "Entrada de dados");
                if (auxiliar == "")
                    break;
                if (!int.TryParse(auxiliar, out vetor[i]))
                {
                    MessageBox.Show("Número inválido");
                    i--;
                }
            }

            //Ordem inversa com for.
            //for (var i = 19; i > 0; i--)
            //{
            //    auxiliar += "\n" + vetor[i].ToString();
            //    MessageBox.Show(auxiliar);
            //}

            //Ordem inversa com reverse.
            Array.Reverse(vetor);
            auxiliar = "";

            foreach (var j in vetor)
            {
                auxiliar += "\n" + j.ToString();
                MessageBox.Show(auxiliar);
            }
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preco = new double[10];
            double faturamento = 0;
            string auxiliar = "";

            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade " + (i + 1).ToString(), "Entrada de quantidades");
                if (!double.TryParse(auxiliar, out quantidade[i]))
                {
                    MessageBox.Show("Quantidade inválida!");
                    i--;
                }
                else
                {
                    while (preco[i] <= 0)
                    {
                        auxiliar = "";
                        auxiliar = Interaction.InputBox("Digite o preço " + (i + 1).ToString(), "Entrada de preços");
                        if (double.TryParse(auxiliar, out preco[i]))
                        {
                            if (preco[i] <= 0)
                            {
                                MessageBox.Show("Preço inválido");
                                i--;
                            }
                            else
                                faturamento += quantidade[i] * preco[i];
                        }
                        else
                        {
                            MessageBox.Show("Preço inválido");
                            i--;
                        }
                    }
                }
            }

            string resultado = "";
            for (var i = 0; i < 10; i++)
            {
                resultado += "Mercadoria: " + (i + 1) + " | Quantidade: " + quantidade[i] +
                             " | Preço Unitário: " + preco[i].ToString("N2") + " reais.\n";
            }

            MessageBox.Show(resultado + "\nFaturamento total: " + faturamento.ToString("N2") + " reais.");
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            string[] alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, total = 0;
            Int32 N = alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                total += alunos[I].Length;
            }
            MessageBox.Show("\n" + total);
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string listaFormatada = "";
            ArrayList lista = new ArrayList() {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio",
                                               "Marcelo", "Pedro", "Thais"};

            while (lista.Contains("Otávio"))
            {
                lista.Remove("Otávio");
            }
            foreach (string nome in lista)
            {
                listaFormatada += nome + "\n";
            }
            MessageBox.Show(listaFormatada);
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            double[,] Notas = new double[20, 3];
            double[] Medias = new double[20];
            double media = 0;
            string auxiliar = "";

            for (int i = 0; i < 20; i++)
            {
                media = 0;
                for (int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (j + 1) + " do aluno " + (i + 1), "Entrada de notas");
                    if (double.TryParse(auxiliar, out Notas[i, j]))
                    {
                        if (Notas[i, j] < 0 || Notas[i, j] > 10)
                        {
                            MessageBox.Show("Valores inválidos!");
                            j--;
                        }
                        else
                            media += Notas[i, j];
                    }
                    else
                    {
                        MessageBox.Show("Valores inválidos!");
                        j--;
                    }
                }
                media /= 3;
                Medias[i] = media;
            }
            string mensagem = "";
            for (int i = 0; i < 20; i++)
            {
                mensagem += "Aluno " + (i + 1) + ": Média: " + Medias[i].ToString("N2") + "\n";
            }
            MessageBox.Show(mensagem, "Médias");
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            frmExercicio6 frm6 = new frmExercicio6();
            frm6.Show();
        }
    }
}
