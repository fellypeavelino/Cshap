using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relatorios
{
    public partial class RelatorioCompras : Form
    {
        public RelatorioCompras()
        {
            InitializeComponent();
        }

        private void RelatorioCompras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPessoa.pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.dataSetPessoa.pessoa);
            // TODO: This line of code loads data into the 'frigorifico2DataSet.compra' table. You can move, or remove it, as needed.
            this.compraTableAdapter.Fill(this.frigorifico2DataSet.compra);

        }
    }
}
