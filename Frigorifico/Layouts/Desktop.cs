using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frigorifico.Layouts
{
    public partial class Desktop : Form
    {
        public Desktop(Form1 f)
        {
            InitializeComponent();
            f.Hide();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {

        }

        private void Desktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pessoaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Pessoa_Fisica capefi = new Cadastro_Pessoa_Fisica();
            capefi.Show();
        }

        private void pessoaJuridicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Pessoa_Juridica capeju = new Cadastro_Pessoa_Juridica();
            capeju.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Fornecedor caforn = new Cadastro_Fornecedor();
            caforn.Show();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Animal caan = new Cadastro_Animal();
            caan.Show();
        }
    }
}
