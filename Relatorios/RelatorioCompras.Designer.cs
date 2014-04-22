namespace Relatorios
{
    partial class RelatorioCompras
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frigorifico2DataSet = new Relatorios.frigorifico2DataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Relatorios.frigorifico2DataSetTableAdapters.compraTableAdapter();
            this.dataSetCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCompra = new Relatorios.DataSetCompra();
            this.dataSetPessoa = new Relatorios.DataSetPessoa();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Relatorios.DataSetPessoaTableAdapters.pessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frigorifico2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.pessoaBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "celular";
            series1.YValueMembers = "codigo";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(664, 458);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // frigorifico2DataSet
            // 
            this.frigorifico2DataSet.DataSetName = "frigorifico2DataSet";
            this.frigorifico2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.frigorifico2DataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetCompraBindingSource
            // 
            this.dataSetCompraBindingSource.DataSource = this.dataSetCompra;
            this.dataSetCompraBindingSource.Position = 0;
            // 
            // dataSetCompra
            // 
            this.dataSetCompra.DataSetName = "DataSetCompra";
            this.dataSetCompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetPessoa
            // 
            this.dataSetPessoa.DataSetName = "DataSetPessoa";
            this.dataSetPessoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "pessoa";
            this.pessoaBindingSource.DataSource = this.dataSetPessoa;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 464);
            this.Controls.Add(this.chart1);
            this.Name = "RelatorioCompras";
            this.Text = "RelatorioCompras";
            this.Load += new System.EventHandler(this.RelatorioCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frigorifico2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private frigorifico2DataSet frigorifico2DataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private frigorifico2DataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private System.Windows.Forms.BindingSource dataSetCompraBindingSource;
        private DataSetCompra dataSetCompra;
        private DataSetPessoa dataSetPessoa;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSetPessoaTableAdapters.pessoaTableAdapter pessoaTableAdapter;
    }
}