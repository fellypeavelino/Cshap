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
            this.SuspendLayout();
            // 
            // rtbconversa
            // 
            this.rtbconversa.Location = new System.Drawing.Point(12, 12);
            this.rtbconversa.Name = "rtbconversa";
            this.rtbconversa.Size = new System.Drawing.Size(459, 167);
            this.rtbconversa.TabIndex = 0;
            this.rtbconversa.Text = "";
            // 
            // rtbmensagem
            // 
            this.rtbmensagem.Location = new System.Drawing.Point(51, 197);
            this.rtbmensagem.Name = "rtbmensagem";
            this.rtbmensagem.Size = new System.Drawing.Size(373, 96);
            this.rtbmensagem.TabIndex = 1;
            this.rtbmensagem.Text = "";
            this.rtbmensagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbmensagem_KeyDown);
            this.rtbmensagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbmensagem_KeyUp);
            // 
            // Lancamento_cotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 405);
            this.Controls.Add(this.rtbmensagem);
            this.Controls.Add(this.rtbconversa);
            this.Name = "Lancamento_cotacao";
            this.Text = "Lancamento_cotacao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lancamento_cotacao_FormClosing);
            this.Load += new System.EventHandler(this.Lancamento_cotacao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbconversa;
        private System.Windows.Forms.RichTextBox rtbmensagem;
    }
}