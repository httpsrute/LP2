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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;
                string matricula = txtMatricula.Text;
                double producao = 0;
                double salario = 0;
                double gratificacao = 0;

                double b = 0;
                double c = 0;
                double d = 0;
                double salariobruto = 0;
                double salarioinicial = 0;

                if (txtNome.Text == "" || txtCargo.Text == "" || txtMatricula.Text == "" ||
                    !double.TryParse(txtProducao.Text, out producao) || producao < 0 ||
                    !double.TryParse(txtSalario.Text, out salario) || salario < 0 ||
                    !double.TryParse(txtGratificacao.Text, out gratificacao) || gratificacao < 0)
                {
                    MessageBox.Show("Valor(es) inválido(s)!\n" +
                                    "Preenche todos os campos.\n" +
                                    "Insira apenas valores numéricos positivos nos campos 'Produção', 'Salário' e 'Gratificação'.");
                    return;
                }
                else
                {
                    if (producao >= 100)
                        b = 1;
                    if (producao >= 120)
                        c = 1;
                    if (producao >= 150)
                        d = 1;
                }

                salarioinicial = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d);
                salariobruto = salarioinicial + gratificacao;

                if (salariobruto > 7000 && gratificacao == 0 && producao < 150)
                    MessageBox.Show("Salário bruto excede o limite máximo de 7000,00 para funcionários sem produção >= 150 ou sem gratificação.");
                else
                    MessageBox.Show($"Nome: {nome}\nCargo: {cargo}\nMatrícula: {matricula}\nSalário bruto: {salariobruto.ToString("N2")}");
            }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCargo.Clear();
            txtMatricula.Clear();
            txtProducao.Clear();
            txtSalario.Clear();
            txtGratificacao.Clear();
        }
    }
}
