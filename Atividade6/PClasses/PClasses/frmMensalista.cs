using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstanciar1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                            "Nome: " + objMensalista.NomeEmpregado + "\n" +
                            "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo de Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" +
                            objMensalista.VerificaHome());
        }

        private void BtnInstanciar2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                       Convert.ToInt32(txtMatricula.Text), txtNome.Text,
                       Convert.ToDateTime(txtData.Text),
                       Convert.ToDouble(txtSalario.Text));

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                            "Nome: " + objMensalista.NomeEmpregado + "\n" +
                            "Data de Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                            "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo de Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" +
                            objMensalista.VerificaHome());
        }
    }
}
