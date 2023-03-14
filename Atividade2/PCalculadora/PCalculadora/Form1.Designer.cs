namespace PCalculadora
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(12, 12);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(50, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(12, 53);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(50, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Numero2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(98, 12);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(226, 20);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.Validated += new System.EventHandler(this.TxtNum1_Validated);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(98, 53);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(226, 20);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.Validated += new System.EventHandler(this.TxtNum2_Validated);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(98, 94);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(226, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 94);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(12, 149);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(96, 63);
            this.btnMais.TabIndex = 6;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.BtnMais_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(138, 149);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(97, 63);
            this.btnMenos.TabIndex = 7;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.BtnMenos_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(271, 149);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(95, 63);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(402, 149);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(97, 63);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(363, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(136, 54);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(363, 85);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 30);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 235);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

