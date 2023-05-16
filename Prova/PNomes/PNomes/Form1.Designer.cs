namespace PNomes
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
            this.btnNomes = new System.Windows.Forms.Button();
            this.lstbxNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNomes
            // 
            this.btnNomes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNomes.Location = new System.Drawing.Point(85, 346);
            this.btnNomes.Name = "btnNomes";
            this.btnNomes.Size = new System.Drawing.Size(397, 60);
            this.btnNomes.TabIndex = 0;
            this.btnNomes.Text = "Executar";
            this.btnNomes.UseVisualStyleBackColor = false;
            this.btnNomes.Click += new System.EventHandler(this.BtnNomes_Click);
            // 
            // lstbxNomes
            // 
            this.lstbxNomes.FormattingEnabled = true;
            this.lstbxNomes.Location = new System.Drawing.Point(85, 67);
            this.lstbxNomes.Name = "lstbxNomes";
            this.lstbxNomes.Size = new System.Drawing.Size(397, 238);
            this.lstbxNomes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.lstbxNomes);
            this.Controls.Add(this.btnNomes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNomes;
        private System.Windows.Forms.ListBox lstbxNomes;
    }
}

