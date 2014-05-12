namespace Web_Cliente.Layout
{
    partial class Solicitacao_Descricao
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
            this.descricao = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(12, 107);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(307, 91);
            this.descricao.TabIndex = 2;
            this.descricao.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(15, 224);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.Size = new System.Drawing.Size(382, 178);
            this.gridProdutos.TabIndex = 4;
            this.gridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellContentClick);
            // 
            // selected
            // 
            this.selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selected.Location = new System.Drawing.Point(397, 48);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(310, 150);
            this.selected.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ususario:";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(87, 13);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(35, 13);
            this.usuario.TabIndex = 7;
            this.usuario.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade:";
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(90, 45);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(60, 20);
            this.quantidade.TabIndex = 9;
            // 
            // Solicitacao_Descricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.gridProdutos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label1);
            this.Name = "Solicitacao_Descricao";
            this.Text = "Solicitacao_Descricao";
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.DataGridView selected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantidade;
    }
}