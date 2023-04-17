namespace PMenu
{
    partial class frmExercicio3
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.Location = new System.Drawing.Point(34, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 80);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove o primeiro do segundo";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReplace.Location = new System.Drawing.Point(257, 206);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(129, 80);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "Remove o primeiro do segundo (Replace)";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInverte.Location = new System.Drawing.Point(311, 69);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(75, 46);
            this.btnInverte.TabIndex = 2;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = false;
            this.btnInverte.Click += new System.EventHandler(this.BtnInverte_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(31, 53);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 3;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(31, 120);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(49, 13);
            this.lblPalavra2.TabIndex = 4;
            this.lblPalavra2.Text = "Palavra2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPalavra1.Location = new System.Drawing.Point(129, 50);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(146, 20);
            this.txtPalavra1.TabIndex = 5;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPalavra2.Location = new System.Drawing.Point(129, 113);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(146, 20);
            this.txtPalavra2.TabIndex = 6;
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 320);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnRemove);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
    }
}