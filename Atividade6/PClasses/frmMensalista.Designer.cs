namespace PClasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(33, 60);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(33, 170);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(76, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário Mensal";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(33, 226);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(144, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data de Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(228, 60);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(210, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(228, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(228, 167);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(210, 20);
            this.txtSalario.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(228, 226);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(210, 20);
            this.txtData.TabIndex = 7;
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.Controls.Add(this.rbtnNao);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Location = new System.Drawing.Point(520, 60);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Size = new System.Drawing.Size(200, 100);
            this.gbxHomeOffice.TabIndex = 8;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office?";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(27, 72);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(48, 17);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(27, 41);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(44, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(27, 280);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(205, 59);
            this.btnInstanciar1.TabIndex = 9;
            this.btnInstanciar1.Text = "Instanciar Mensalista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            this.btnInstanciar1.Click += new System.EventHandler(this.BtnInstanciar1_Click);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(261, 280);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(216, 59);
            this.btnInstanciar2.TabIndex = 10;
            this.btnInstanciar2.Text = "Instanciar Mensalista (Passando parâmetro)";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            this.btnInstanciar2.Click += new System.EventHandler(this.BtnInstanciar2_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar1);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanciar1;
        private System.Windows.Forms.Button btnInstanciar2;
    }
}