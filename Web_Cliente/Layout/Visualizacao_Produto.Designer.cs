namespace Web_Cliente.Layout
{
    partial class Visualizacao_Produto
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
            this.nome = new System.Windows.Forms.Label();
            this.nome_vsualizar = new System.Windows.Forms.MaskedTextBox();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.tipo_visualizar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(16, 26);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome:";
            // 
            // nome_vsualizar
            // 
            this.nome_vsualizar.Location = new System.Drawing.Point(75, 23);
            this.nome_vsualizar.Name = "nome_vsualizar";
            this.nome_vsualizar.Size = new System.Drawing.Size(186, 20);
            this.nome_vsualizar.TabIndex = 1;
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(12, 141);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.Size = new System.Drawing.Size(612, 332);
            this.gridProdutos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(12, 82);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Pesquisar.TabIndex = 4;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // tipo_visualizar
            // 
            this.tipo_visualizar.FormattingEnabled = true;
            this.tipo_visualizar.Location = new System.Drawing.Point(319, 23);
            this.tipo_visualizar.Name = "tipo_visualizar";
            this.tipo_visualizar.Size = new System.Drawing.Size(121, 21);
            this.tipo_visualizar.TabIndex = 5;
            // 
            // Visualizacao_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 480);
            this.Controls.Add(this.tipo_visualizar);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.nome_vsualizar);
            this.Controls.Add(this.nome);
            this.MaximizeBox = false;
            this.Name = "Visualizacao_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualização de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.MaskedTextBox nome_vsualizar;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.ComboBox tipo_visualizar;
    }
}