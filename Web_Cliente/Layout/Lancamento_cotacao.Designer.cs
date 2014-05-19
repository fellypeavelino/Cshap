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
            this.lProdutoServidor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCompra = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lProdutoServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbconversa
            // 
            this.rtbconversa.Location = new System.Drawing.Point(12, 12);
            this.rtbconversa.Name = "rtbconversa";
            this.rtbconversa.Size = new System.Drawing.Size(373, 51);
            this.rtbconversa.TabIndex = 0;
            this.rtbconversa.Text = "";
            // 
            // lProdutoServidor
            // 
            this.lProdutoServidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lProdutoServidor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.lProdutoServidor.Location = new System.Drawing.Point(12, 109);
            this.lProdutoServidor.Name = "lProdutoServidor";
            this.lProdutoServidor.Size = new System.Drawing.Size(439, 150);
            this.lProdutoServidor.TabIndex = 2;
            this.lProdutoServidor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lProdutoServidor_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produtos para Cotação:";
            // 
            // gridCompra
            // 
            this.gridCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.gridCompra.Location = new System.Drawing.Point(467, 45);
            this.gridCompra.Name = "gridCompra";
            this.gridCompra.Size = new System.Drawing.Size(240, 150);
            this.gridCompra.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Codigo";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nome";
            this.Column6.Name = "Column6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produtos a Comprar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade:";
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(232, 76);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(71, 20);
            this.quantidade.TabIndex = 8;
            // 
            // Lancamento_cotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 431);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lProdutoServidor);
            this.Controls.Add(this.rtbconversa);
            this.Name = "Lancamento_cotacao";
            this.Text = "Lancamento_cotacao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lancamento_cotacao_FormClosing);
            this.Load += new System.EventHandler(this.Lancamento_cotacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lProdutoServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbconversa;
        private System.Windows.Forms.DataGridView lProdutoServidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox quantidade;
    }
}