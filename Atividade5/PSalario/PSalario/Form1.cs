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

namespace PSalario
{
    public partial class Form1 : Form
    {
        double SalarioBruto = 0;
        double SalarioLiquido = 0;
        double SalarioFam = 0;
        double DescontoINSS = 0;
        double DescontoIRPF = 0;
        double NumFilhos = 0;
        string Sexo, EstadoCivil, Filhos;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar)))
            {
                MessageBox.Show("O nome deve conter apenas letras.");
                txtNome.Focus();
            }
        }

        private void TxtNome_Validated(object sender, EventArgs e)
        {

            if (txtNome.Text.Length < 10)
            {
                MessageBox.Show("Nome não pode ter menos que 10 caracteres!");
                txtNome.Focus();
            }
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            if ((!double.TryParse(mskbxSalarioBruto.Text, out SalarioBruto) ||
                 !double.TryParse(nudFilhos.Text, out NumFilhos)))

                MessageBox.Show("Salário bruto ou número de filhos inválidos!");
                
            else
            {
                if (SalarioBruto <= 0)
                    MessageBox.Show("Salário bruto deve ser maior que 0.");
                else
                {
                    if (SalarioBruto <= 800.47)
                    {
                        DescontoINSS = 0.0765 * SalarioBruto;
                        txtAliquotaINSS.Text = "7,65%";
                        txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                    }
                    else
                        if (SalarioBruto <= 1050)
                    {
                        DescontoINSS = 0.0865 * SalarioBruto;
                        txtAliquotaINSS.Text = "8,65%";
                        txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                    }
                    else
                        if (SalarioBruto <= 1400.77)
                    {
                        DescontoINSS = 0.09 * SalarioBruto;
                        txtAliquotaINSS.Text = "9%";
                        txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                    }
                    else
                        if (SalarioBruto <= 2801.56)
                    {
                        DescontoINSS = 0.11 * SalarioBruto;
                        txtAliquotaINSS.Text = "11%";
                        txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                    }
                    else
                    {
                        DescontoINSS = 308.17;
                        txtAliquotaINSS.Text = "Teto";
                        txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                    }

                    if (SalarioBruto <= 1257.12)
                    {
                        txtAliquotaIRPF.Text = "Isento.";
                        txtDescontoIRPF.Text = DescontoIRPF.ToString("N2");
                    }
                    else
                        if (SalarioBruto <= 2512.08)
                    {
                        DescontoIRPF = 0.15 * SalarioBruto;
                        txtAliquotaIRPF.Text = "15%";
                        txtDescontoIRPF.Text = DescontoIRPF.ToString("N2");
                    }
                    else
                    {
                        DescontoIRPF = 0.275 * SalarioBruto;
                        txtAliquotaIRPF.Text = "27,5%";
                        txtDescontoIRPF.Text = DescontoIRPF.ToString("N2");
                    }

                    if (SalarioBruto <= 435.52)
                    {
                        SalarioFam = 22.33 * NumFilhos;
                        txtSalarioFam.Text = SalarioFam.ToString("N2");
                    }
                    else
                        if (SalarioBruto <= 654.61)
                    {
                        SalarioFam = 15.74 * NumFilhos;
                        txtSalarioFam.Text = SalarioFam.ToString("N2");
                    }
                    else
                    {
                        txtSalarioFam.Text = SalarioFam.ToString("N2");
                    }

                    SalarioLiquido = ((SalarioBruto - DescontoINSS) - DescontoIRPF) + SalarioFam;
                    txtSalarioLiquido.Text = SalarioLiquido.ToString("N2");

                    if (!rbtnFeminino.Checked && !rbtnMasculino.Checked)
                    {
                        MessageBox.Show("É necessário definir um gênero.");
                        gbxSexo.Focus();
                    }

                    else
                    if (rbtnFeminino.Checked)
                        Sexo = "da Sra. ";
                    else
                        Sexo = "do Sr. ";

                    if (ckbxEstadoCivil.Checked && rbtnFeminino.Checked)
                        EstadoCivil = "casada";
                    else
                        if ((!ckbxEstadoCivil.Checked) && rbtnFeminino.Checked)
                        EstadoCivil = "solteira";
                    else
                        if (ckbxEstadoCivil.Checked && rbtnMasculino.Checked)
                        EstadoCivil = "casado";
                    else
                        if ((!ckbxEstadoCivil.Checked) && rbtnMasculino.Checked)
                        EstadoCivil = "solteiro";

                    if (NumFilhos == 0)
                        Filhos = "não possui filhos(as), ";
                    else
                        if (NumFilhos == 1)
                        Filhos = "tem 1 filho(a), ";
                    else
                        Filhos = "tem " + NumFilhos + " filhos(as), ";

                    lblDados.Text = "Os descontos do salário " + Sexo + txtNome.Text + ", que é "
                                    + EstadoCivil + ", e que " + Filhos + "são:";

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskbxSalarioBruto.Clear();
            rbtnFeminino.Checked = false;
            rbtnMasculino.Checked = false;
            ckbxEstadoCivil.Checked = false;
            nudFilhos.Value = 0;
            txtAliquotaINSS.Clear();
            txtAliquotaIRPF.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtSalarioFam.Clear();
            txtSalarioLiquido.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
