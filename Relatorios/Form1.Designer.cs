namespace Relatorios
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatorioComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeSolicitaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDeCotaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioComprasToolStripMenuItem,
            this.relatorioDeSolicitaçõesToolStripMenuItem,
            this.relatorioDeCotaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatorioComprasToolStripMenuItem
            // 
            this.relatorioComprasToolStripMenuItem.Name = "relatorioComprasToolStripMenuItem";
            this.relatorioComprasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.relatorioComprasToolStripMenuItem.Text = "Relatorio Compras";
            // 
            // relatorioDeSolicitaçõesToolStripMenuItem
            // 
            this.relatorioDeSolicitaçõesToolStripMenuItem.Name = "relatorioDeSolicitaçõesToolStripMenuItem";
            this.relatorioDeSolicitaçõesToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.relatorioDeSolicitaçõesToolStripMenuItem.Text = "Relatorio de Solicitações";
            // 
            // relatorioDeCotaçãoToolStripMenuItem
            // 
            this.relatorioDeCotaçãoToolStripMenuItem.Name = "relatorioDeCotaçãoToolStripMenuItem";
            this.relatorioDeCotaçãoToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.relatorioDeCotaçãoToolStripMenuItem.Text = "Relatorio de cotação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 384);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatorioComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeSolicitaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeCotaçãoToolStripMenuItem;
    }
}

