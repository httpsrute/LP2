﻿namespace PLacos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xercício3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercício2ToolStripMenuItem,
            this.xercício3ToolStripMenuItem,
            this.exercício4ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício1ToolStripMenuItem.Text = "Exercício 1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.Exercício1ToolStripMenuItem_Click);
            // 
            // exercício2ToolStripMenuItem
            // 
            this.exercício2ToolStripMenuItem.Name = "exercício2ToolStripMenuItem";
            this.exercício2ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício2ToolStripMenuItem.Text = "Exercício 2";
            this.exercício2ToolStripMenuItem.Click += new System.EventHandler(this.Exercício2ToolStripMenuItem_Click);
            // 
            // xercício3ToolStripMenuItem
            // 
            this.xercício3ToolStripMenuItem.Name = "xercício3ToolStripMenuItem";
            this.xercício3ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.xercício3ToolStripMenuItem.Text = "Exercício 3";
            this.xercício3ToolStripMenuItem.Click += new System.EventHandler(this.Xercício3ToolStripMenuItem_Click);
            // 
            // exercício4ToolStripMenuItem
            // 
            this.exercício4ToolStripMenuItem.Name = "exercício4ToolStripMenuItem";
            this.exercício4ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício4ToolStripMenuItem.Text = "Exercício 4";
            this.exercício4ToolStripMenuItem.Click += new System.EventHandler(this.Exercício4ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xercício3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

