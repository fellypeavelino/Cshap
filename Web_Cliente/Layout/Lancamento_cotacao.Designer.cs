namespace Web_Cliente.Layout
{
    partial class Lancamento_cotacao
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
            this.rtbconversa = new System.Windows.Forms.RichTextBox();
            this.rtbmensagem = new System.Windows.Forms.RichTextBox();
            this.lProdutoServidor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lProdutoServidor)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbconversa
            // 
            this.rtbconversa.Location = new System.Drawing.Point(12, 12);
            this.rtbconversa.Name = "rtbconversa";
            this.rtbconversa.Size = new System.Drawing.Size(373, 167);
            this.rtbconversa.TabIndex = 0;
            this.rtbconversa.Text = "";
            // 
            // rtbmensagem
            // 
            this.rtbmensagem.Location = new System.Drawing.Point(12, 194);
            this.rtbmensagem.Name = "rtbmensagem";
            this.rtbmensagem.Size = new System.Drawing.Size(373, 96);
            this.rtbmensagem.TabIndex = 1;
            this.rtbmensagem.Text = "";
            this.rtbmensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbmensagem_KeyDown);
            this.rtbmensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbmensagem_KeyUp);
            // 
            // lProdutoServidor
            // 
            this.lProdutoServidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lProdutoServidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.lProdutoServidor.Location = new System.Drawing.Point(12, 311);
            this.lProdutoServidor.Name = "lProdutoServidor";
            this.lProdutoServidor.Size = new System.Drawing.Size(445, 150);
            this.lProdutoServidor.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Peso";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Preco";
            this.Column4.Name = "Column4";
            // 
            // Lancamento_cotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 473);
            this.Controls.Add(this.lProdutoServidor);
            this.Controls.Add(this.rtbmensagem);
            this.Controls.Add(this.rtbconversa);
            this.Name = "Lancamento_cotacao";
            this.Text = "Lancamento_cotacao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lancamento_cotacao_FormClosing);
            this.Load += new System.EventHandler(this.Lancamento_cotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lProdutoServidor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbconversa;
        private System.Windows.Forms.RichTextBox rtbmensagem;
        private System.Windows.Forms.DataGridView lProdutoServidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}