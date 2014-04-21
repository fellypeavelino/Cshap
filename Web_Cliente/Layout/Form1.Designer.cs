namespace Web_Cliente.Layout
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaçãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_logar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.MaskedTextBox();
            this.senha = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_lgin = new System.Windows.Forms.GroupBox();
            this.erro = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.groupBox_lgin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.solicitaçãoToolStripMenuItem,
            this.visualizaçãoDeProdutosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(550, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // solicitaçãoToolStripMenuItem
            // 
            this.solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            this.solicitaçãoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitaçãoToolStripMenuItem.Text = "Solicitação";
            this.solicitaçãoToolStripMenuItem.Click += new System.EventHandler(this.solicitaçãoToolStripMenuItem_Click);
            // 
            // visualizaçãoDeProdutosToolStripMenuItem
            // 
            this.visualizaçãoDeProdutosToolStripMenuItem.Name = "visualizaçãoDeProdutosToolStripMenuItem";
            this.visualizaçãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.visualizaçãoDeProdutosToolStripMenuItem.Text = "Visualização de Produtos";
            this.visualizaçãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.visualizaçãoDeProdutosToolStripMenuItem_Click);
            // 
            // but_logar
            // 
            this.but_logar.Location = new System.Drawing.Point(184, 64);
            this.but_logar.Name = "but_logar";
            this.but_logar.Size = new System.Drawing.Size(75, 23);
            this.but_logar.TabIndex = 1;
            this.but_logar.Text = "Logar";
            this.but_logar.UseVisualStyleBackColor = true;
            this.but_logar.Click += new System.EventHandler(this.but_logar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(56, 30);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(150, 20);
            this.mail.TabIndex = 4;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(56, 67);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(100, 20);
            this.senha.TabIndex = 5;
            this.senha.UseSystemPasswordChar = true;
            // 
            // groupBox_lgin
            // 
            this.groupBox_lgin.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_lgin.Controls.Add(this.erro);
            this.groupBox_lgin.Controls.Add(this.but_logar);
            this.groupBox_lgin.Controls.Add(this.senha);
            this.groupBox_lgin.Controls.Add(this.label1);
            this.groupBox_lgin.Controls.Add(this.mail);
            this.groupBox_lgin.Controls.Add(this.label2);
            this.groupBox_lgin.Location = new System.Drawing.Point(12, 40);
            this.groupBox_lgin.Name = "groupBox_lgin";
            this.groupBox_lgin.Size = new System.Drawing.Size(269, 136);
            this.groupBox_lgin.TabIndex = 6;
            this.groupBox_lgin.TabStop = false;
            this.groupBox_lgin.Text = "Login";
            // 
            // erro
            // 
            this.erro.AutoSize = true;
            this.erro.BackColor = System.Drawing.Color.Transparent;
            this.erro.ForeColor = System.Drawing.Color.Red;
            this.erro.Location = new System.Drawing.Point(14, 110);
            this.erro.Name = "erro";
            this.erro.Size = new System.Drawing.Size(0, 13);
            this.erro.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(550, 410);
            this.Controls.Add(this.groupBox_lgin);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Friorifico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox_lgin.ResumeLayout(false);
            this.groupBox_lgin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaçãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.Button but_logar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mail;
        private System.Windows.Forms.MaskedTextBox senha;
        private System.Windows.Forms.GroupBox groupBox_lgin;
        private System.Windows.Forms.Label erro;
    }
}