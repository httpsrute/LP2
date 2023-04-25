namespace PClasses
{
    partial class frmHorista
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
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.gbxHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.btnInstanciar = new System.Windows.Forms.Button();
            this.gbxHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(49, 32);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(49, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(49, 99);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(81, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário por hora";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(49, 133);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(88, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Número de horas";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(49, 164);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(142, 13);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Data de entrada na empresa";
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Location = new System.Drawing.Point(49, 195);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(71, 13);
            this.lblFaltas.TabIndex = 5;
            this.lblFaltas.Text = "Dias de faltas";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(221, 29);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(157, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(221, 67);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(221, 98);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(157, 20);
            this.txtSalario.TabIndex = 8;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(221, 130);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(157, 20);
            this.txtHoras.TabIndex = 9;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(221, 161);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(157, 20);
            this.txtData.TabIndex = 10;
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(221, 195);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(157, 20);
            this.txtFaltas.TabIndex = 11;
            // 
            // gbxHomeOffice
            // 
            this.gbxHomeOffice.Controls.Add(this.rbtnNao);
            this.gbxHomeOffice.Controls.Add(this.rbtnSim);
            this.gbxHomeOffice.Location = new System.Drawing.Point(416, 32);
            this.gbxHomeOffice.Name = "gbxHomeOffice";
            this.gbxHomeOffice.Size = new System.Drawing.Size(200, 100);
            this.gbxHomeOffice.TabIndex = 12;
            this.gbxHomeOffice.TabStop = false;
            this.gbxHomeOffice.Text = "Trabalha em Home Office?";
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(17, 36);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(44, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(17, 69);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(48, 17);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // btnInstanciar
            // 
            this.btnInstanciar.Location = new System.Drawing.Point(416, 162);
            this.btnInstanciar.Name = "btnInstanciar";
            this.btnInstanciar.Size = new System.Drawing.Size(184, 53);
            this.btnInstanciar.TabIndex = 13;
            this.btnInstanciar.Text = "Instanciar horista";
            this.btnInstanciar.UseVisualStyleBackColor = true;
            this.btnInstanciar.Click += new System.EventHandler(this.BtnInstanciar_Click);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 235);
            this.Controls.Add(this.btnInstanciar);
            this.Controls.Add(this.gbxHomeOffice);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gbxHomeOffice.ResumeLayout(false);
            this.gbxHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.GroupBox gbxHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanciar;
    }
}