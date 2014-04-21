using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Web_Cliente.servidor;

namespace Web_Cliente.Layout
{
    public partial class Visualizacao_Produto : Form
    {
        public Visualizacao_Produto()
        {
            InitializeComponent();
            try {
                WebServiceFrigorifico wsf = new WebServiceFrigorifico();
                
                Tipo[] nomes = wsf.nome_tipo();
                foreach (Tipo nome in nomes) {
                    tipo_visualizar.Items.Add(nome.nome);
                }
                tipo_visualizar.SelectedIndex = 0;
                
                this.carregagrid(gridProdutos);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        

        public void carregagrid(DataGridView grid)
        {
            WebServiceFrigorifico wsf = new WebServiceFrigorifico();
            Produto[] p = wsf.listaProdutoWeb();
            grid.Rows.Clear();
            grid.ColumnCount = 4;
            foreach (Produto pro in p)
            {
                grid.Rows.Add(
                    pro.Codigo_produto_,
                    pro.nome_produto,
                    pro.peso,
                    pro.preco
                );
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto.nome = tipo_visualizar.Text;
                produto.nome_produto = nome_vsualizar.Text;
                WebServiceFrigorifico wsf = new WebServiceFrigorifico();
                Produto[] p = wsf.pesquisarProdutos(produto);
                gridProdutos.Rows.Clear();
                gridProdutos.ColumnCount = 4;
                foreach (Produto pro in p)
                {
                    gridProdutos.Rows.Add(
                        pro.Codigo_produto_,
                        pro.nome_produto,
                        pro.peso,
                        pro.preco
                    );
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
