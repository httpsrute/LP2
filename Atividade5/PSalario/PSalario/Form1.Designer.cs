namespace PSalario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFam = new System.Windows.Forms.Label();
            this.lblSalarioLiq = new System.Windows.Forms.Label();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.nudFilhos = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFam = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.pnlEstadoCivil = new System.Windows.Forms.Panel();
            this.ckbxEstadoCivil = new System.Windows.Forms.CheckBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.pnlEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(12, 39);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(12, 68);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(106, 13);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de Filhos(as)";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(18, 231);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(75, 13);
            this.lblAliquotaINSS.TabIndex = 3;
            this.lblAliquotaINSS.Text = "Alíquota INSS";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(19, 262);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblAliquotaIRPF.TabIndex = 4;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalarioFam
            // 
            this.lblSalarioFam.AutoSize = true;
            this.lblSalarioFam.Location = new System.Drawing.Point(17, 295);
            this.lblSalarioFam.Name = "lblSalarioFam";
            this.lblSalarioFam.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFam.TabIndex = 5;
            this.lblSalarioFam.Text = "Salário Família";
            // 
            // lblSalarioLiq
            // 
            this.lblSalarioLiq.AutoSize = true;
            this.lblSalarioLiq.Location = new System.Drawing.Point(15, 330);
            this.lblSalarioLiq.Name = "lblSalarioLiq";
            this.lblSalarioLiq.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiq.TabIndex = 6;
            this.lblSalarioLiq.Text = "Salário Líquido";
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(12, 362);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoINSS.TabIndex = 7;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(13, 392);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIRPF.TabIndex = 8;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(141, 175);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(151, 23);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verficar desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // nudFilhos
            // 
            this.nudFilhos.Location = new System.Drawing.Point(155, 68);
            this.nudFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFilhos.Name = "nudFilhos";
            this.nudFilhos.Size = new System.Drawing.Size(120, 20);
            this.nudFilhos.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(155, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress_1);
            this.txtNome.Validated += new System.EventHandler(this.TxtNome_Validated);
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(155, 231);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(120, 20);
            this.txtAliquotaINSS.TabIndex = 12;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(155, 262);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(120, 20);
            this.txtAliquotaIRPF.TabIndex = 13;
            // 
            // txtSalarioFam
            // 
            this.txtSalarioFam.Enabled = false;
            this.txtSalarioFam.Location = new System.Drawing.Point(155, 295);
            this.txtSalarioFam.Name = "txtSalarioFam";
            this.txtSalarioFam.Size = new System.Drawing.Size(120, 20);
            this.txtSalarioFam.TabIndex = 14;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(155, 327);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(120, 20);
            this.txtSalarioLiquido.TabIndex = 15;
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(155, 359);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(120, 20);
            this.txtDescontoINSS.TabIndex = 16;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(155, 392);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(120, 20);
            this.txtDescontoIRPF.TabIndex = 17;
            // 
            // gbxSexo
            // 
            this.gbxSexo.BackColor = System.Drawing.Color.CadetBlue;
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Location = new System.Drawing.Point(392, 9);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 4;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(22, 56);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "M";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(22, 28);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(31, 17);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "F";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // pnlEstadoCivil
            // 
            this.pnlEstadoCivil.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlEstadoCivil.Controls.Add(this.ckbxEstadoCivil);
            this.pnlEstadoCivil.Location = new System.Drawing.Point(392, 147);
            this.pnlEstadoCivil.Name = "pnlEstadoCivil";
            this.pnlEstadoCivil.Size = new System.Drawing.Size(200, 100);
            this.pnlEstadoCivil.TabIndex = 5;
            // 
            // ckbxEstadoCivil
            // 
            this.ckbxEstadoCivil.AutoSize = true;
            this.ckbxEstadoCivil.Location = new System.Drawing.Point(40, 62);
            this.ckbxEstadoCivil.Name = "ckbxEstadoCivil";
            this.ckbxEstadoCivil.Size = new System.Drawing.Size(74, 17);
            this.ckbxEstadoCivil.TabIndex = 0;
            this.ckbxEstadoCivil.Text = "Casado(a)";
            this.ckbxEstadoCivil.UseVisualStyleBackColor = true;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(14, 129);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(38, 13);
            this.lblDados.TabIndex = 21;
            this.lblDados.Text = "Dados";
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(155, 42);
            this.mskbxSalarioBruto.Mask = "99990.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(120, 20);
            this.mskbxSalarioBruto.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(392, 286);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 54);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(392, 372);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(200, 52);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.pnlEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFam);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nudFilhos);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.lblSalarioLiq);
            this.Controls.Add(this.lblSalarioFam);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlEstadoCivil.ResumeLayout(false);
            this.pnlEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFam;
        private System.Windows.Forms.Label lblSalarioLiq;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.NumericUpDown nudFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalarioFam;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Panel pnlEstadoCivil;
        private System.Windows.Forms.CheckBox ckbxEstadoCivil;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

