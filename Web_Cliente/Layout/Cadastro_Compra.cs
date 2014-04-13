using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.Classes;


namespace Web_Cliente.Layout
{
    public partial class Cadastro_Compra : Form
    {
        public Cadastro_Compra(Form1 frm1)
        {
            InitializeComponent();
            try
            {
                nome_usuario.Text = frm1.login;
                this.carregagrid(gridProdutos);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void carregagrid(DataGridView grid)
        {
            Produto produto = new Produto();
            List<Produto> p = produto.lista();
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

        List<Produto> produtos = new List<Produto>();

        private void gridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto.Codigo_produto_ = int.Parse(gridProdutos.CurrentRow.Cells[0].Value.ToString());
                produto.nome_produto = gridProdutos.CurrentRow.Cells[1].Value.ToString();
                produto.preco = double.Parse(gridProdutos.CurrentRow.Cells[3].Value.ToString());
                this.produtos.Add(produto);
                Item_Pedido ip = new Item_Pedido();
                ip.qantidade = int.Parse(quantidade.Text);
                Pessoa p = new Pessoa();
                p.mail = nome_usuario.Text;
                ip.Codigo_pessoa = ip.idPessoa(p);
                ip.insert(produto, ip);
                int id = ip.idItemPedido(produto, ip);
                MessageBox.Show("" + id);
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


    }
}
