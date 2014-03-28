namespace Web_Cliente.Layout
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.MaskedTextBox();
            this.senha = new System.Windows.Forms.MaskedTextBox();
            this.label_erro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(54, 30);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(226, 30);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(100, 20);
            this.senha.TabIndex = 3;
            // 
            // label_erro
            // 
            this.label_erro.AutoSize = true;
            this.label_erro.ForeColor = System.Drawing.Color.Red;
            this.label_erro.Location = new System.Drawing.Point(13, 78);
            this.label_erro.Name = "label_erro";
            this.label_erro.Size = new System.Drawing.Size(35, 13);
            this.label_erro.TabIndex = 4;
            this.label_erro.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 152);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_erro);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mail;
        private System.Windows.Forms.MaskedTextBox senha;
        private System.Windows.Forms.Label label_erro;
        private System.Windows.Forms.Button button1;
    }
}