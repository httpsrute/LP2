namespace PMenu
{
    partial class frmExercicio4
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
            this.rtbConteudo = new System.Windows.Forms.RichTextBox();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfa = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbConteudo.Location = new System.Drawing.Point(240, 44);
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(214, 129);
            this.rtbConteudo.TabIndex = 0;
            this.rtbConteudo.Text = "";
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNum.Location = new System.Drawing.Point(42, 235);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(151, 104);
            this.btnNum.TabIndex = 1;
            this.btnNum.Text = "Quantidade de caracteres númericos existentes";
            this.btnNum.UseVisualStyleBackColor = false;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBranco.Location = new System.Drawing.Point(273, 235);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(152, 104);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Primeiro caractere em branco";
            this.btnBranco.UseVisualStyleBackColor = false;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfa
            // 
            this.btnAlfa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlfa.Location = new System.Drawing.Point(508, 235);
            this.btnAlfa.Name = "btnAlfa";
            this.btnAlfa.Size = new System.Drawing.Size(160, 104);
            this.btnAlfa.TabIndex = 3;
            this.btnAlfa.Text = "Quantidade de caracteres alfabéticos existentes";
            this.btnAlfa.UseVisualStyleBackColor = false;
            this.btnAlfa.Click += new System.EventHandler(this.btnAlfa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.Location = new System.Drawing.Point(508, 92);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 387);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlfa);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.rtbConteudo);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfa;
        private System.Windows.Forms.Button btnLimpar;
    }
}