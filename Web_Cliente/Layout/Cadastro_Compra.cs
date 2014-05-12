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
                Animal animal = new Animal();
                List<Tipo> tipo = animal.tipo.lista_nome_tipo();
                foreach (Tipo nome in tipo)
                {
                    compraTipo.Items.Add(nome.nome);
                }
                compraTipo.SelectedIndex = 0;
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
                carrinho.ColumnCount = 3;
                carrinho.Rows.Add(
                    produto.Codigo_produto_,
                    produto.nome_produto,
                    produto.preco
                );
                this.produtos.Add(produto);
                ////acumulando objeto
                //Item_Pedido ip = new Item_Pedido();
                //ip.qantidade = int.Parse(quantidade.Text);
                //Pessoa p = new Pessoa();
                //p.mail = nome_usuario.Text;
                //ip.Codigo_pessoa = ip.idPessoa(p);
                //ip.insert(produto, ip);
                //int id = ip.idItemPedido(produto, ip);
                //MessageBox.Show("" + id);
                //
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Item_Pedido ip = new Item_Pedido();
                //ip.qantidade = carrinho.RowCount;
                if (quantidade.Text != "")
                {
                    ip.qantidade = int.Parse(quantidade.Text);
                }
                else
                {
                    ip.qantidade = 1;
                }
                Pessoa p = new Pessoa();
                p.mail = nome_usuario.Text;
                ip.Codigo_pessoa = ip.idPessoa(p);
                //MessageBox.Show(ip.Codigo_pessoa+"");
                List<Produto> produtos = this.produtos;
                foreach (Produto pr in produtos)
                {
                    //MessageBox.Show(pr.Codigo_produto_ + "");
                    ip.insertCompra(pr, ip);
                }
                MessageBox.Show("Compra Efetuada");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }


    }
}
