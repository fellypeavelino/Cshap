namespace Frigorifico
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
            this.logar = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_erro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logar
            // 
            this.logar.Location = new System.Drawing.Point(283, 143);
            this.logar.Name = "logar";
            this.logar.Size = new System.Drawing.Size(75, 23);
            this.logar.TabIndex = 1;
            this.logar.Text = "Logar";
            this.logar.UseVisualStyleBackColor = true;
            this.logar.Click += new System.EventHandler(this.logar_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(70, 55);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 2;
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(240, 55);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(118, 20);
            this.senha.TabIndex = 3;
            this.senha.UseSystemPasswordChar = true;
            this.senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senha_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label_erro
            // 
            this.label_erro.AutoSize = true;
            this.label_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_erro.ForeColor = System.Drawing.Color.Red;
            this.label_erro.Location = new System.Drawing.Point(12, 108);
            this.label_erro.Name = "label_erro";
            this.label_erro.Size = new System.Drawing.Size(0, 15);
            this.label_erro.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(412, 178);
            this.Controls.Add(this.label_erro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logar);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frigorifico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logar;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_erro;
    }
}

