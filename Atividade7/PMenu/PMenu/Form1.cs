﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Ctrl+C.");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Ctrl+V.");
        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Normal;
            objFrm2.Show();
        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Normal;
            objFrm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 objFrm4 = new frmExercicio4();
            objFrm4.MdiParent = this;
            objFrm4.WindowState = FormWindowState.Normal;
            objFrm4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 objFrm5 = new frmExercicio5();
            objFrm5.MdiParent = this;
            objFrm5.WindowState = FormWindowState.Normal;
            objFrm5.Show();
        }
    }
}
