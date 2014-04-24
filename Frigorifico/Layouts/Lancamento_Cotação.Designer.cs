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
            this.rtbConversa = new System.Windows.Forms.RichTextBox();
            this.rbtConversa = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdutos
            // 
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Location = new System.Drawing.Point(12, 334);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.Size = new System.Drawing.Size(612, 92);
            this.gridProdutos.TabIndex = 0;
            // 
            // rtbConversa
            // 
            this.rtbConversa.Location = new System.Drawing.Point(12, 22);
            this.rtbConversa.Name = "rtbConversa";
            this.rtbConversa.Size = new System.Drawing.Size(612, 96);
            this.rtbConversa.TabIndex = 1;
            this.rtbConversa.Text = "";
            // 
            // rbtConversa
            // 
            this.rbtConversa.Location = new System.Drawing.Point(21, 174);
            this.rbtConversa.Name = "rbtConversa";
            this.rbtConversa.Size = new System.Drawing.Size(603, 96);
            this.rbtConversa.TabIndex = 2;
            this.rbtConversa.Text = "";
            this.rbtConversa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbtConversa_KeyDown);
            this.rbtConversa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rbtConversa_KeyUp);
            // 
            // Lancamento_Cotação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 438);
            this.Controls.Add(this.rbtConversa);
            this.Controls.Add(this.rtbConversa);
            this.Controls.Add(this.gridProdutos);
            this.Name = "Lancamento_Cotação";
            this.Text = "Lancamento_Cotação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lancamento_Cotação_FormClosing);
            this.Load += new System.EventHandler(this.Lancamento_Cotação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProdutos;
        private System.Windows.Forms.RichTextBox rtbConversa;
        private System.Windows.Forms.RichTextBox rbtConversa;
    }
}