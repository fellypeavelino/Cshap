namespace Frigorifico.Layouts
{
    partial class Lancamento_Cotação
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
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.produtoselecionado = new System.Windows.Forms.DataGridView();
            this.rtEnviar = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoselecionado)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(12, 190);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.Size = new System.Drawing.Size(450, 236);
            this.gridProdutos.TabIndex = 0;
            this.gridProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellContentClick);
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(12, 12);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(367, 40);
            this.rtbMensagem.TabIndex = 1;
            this.rtbMensagem.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // produtoselecionado
            // 
            this.produtoselecionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoselecionado.Location = new System.Drawing.Point(468, 33);
            this.produtoselecionado.Name = "produtoselecionado";
            this.produtoselecionado.Size = new System.Drawing.Size(268, 150);
            this.produtoselecionado.TabIndex = 5;
            // 
            // rtEnviar
            // 
            this.rtEnviar.Location = new System.Drawing.Point(12, 58);
            this.rtEnviar.Name = "rtEnviar";
            this.rtEnviar.Size = new System.Drawing.Size(367, 96);
            this.rtEnviar.TabIndex = 6;
            this.rtEnviar.Text = "";
            // 
            // Lancamento_Cotação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 438);
            this.Controls.Add(this.rtEnviar);
            this.Controls.Add(this.produtoselecionado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.gridProdutos);
            this.Name = "Lancamento_Cotação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor Cotação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lancamento_Cotação_FormClosing);
            this.Load += new System.EventHandler(this.Lancamento_Cotação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoselecionado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView produtoselecionado;
        private System.Windows.Forms.RichTextBox rtEnviar;
    }
}