namespace Frigorifico
{
    partial class Cadastro_Poduto
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
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.preco = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.animal = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProduto
            // 
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Location = new System.Drawing.Point(12, 271);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.Size = new System.Drawing.Size(482, 206);
            this.gridProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço por quilo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(120, 29);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(176, 20);
            this.nome.TabIndex = 10;
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(120, 72);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(100, 20);
            this.preco.TabIndex = 11;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(120, 131);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(100, 20);
            this.peso.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Animal:";
            // 
            // animal
            // 
            this.animal.FormattingEnabled = true;
            this.animal.Location = new System.Drawing.Point(373, 28);
            this.animal.Name = "animal";
            this.animal.Size = new System.Drawing.Size(121, 21);
            this.animal.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Alaterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Cadastro_Poduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 489);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.animal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProduto);
            this.Name = "Cadastro_Poduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Poduto";
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox animal;
        private System.Windows.Forms.Button button2;
    }
}