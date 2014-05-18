using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Web_Cliente.Layout;
using Frigorifico.Classes;

namespace Web_Cliente.Layout
{
    public partial class Solicitacao_Descricao : Form
    {
        public Solicitacao_Descricao(Form1 frm1)
        {
            try
            {
                InitializeComponent();
                usuario.Text = frm1.login;
                this.carregagrid(gridProdutos);
                Web_Cliente.webservice3.WebServiceRespostas wsr = new Web_Cliente.webservice3.WebServiceRespostas();
                Web_Cliente.webservice3.Item_Pedido[] ips = wsr.solicitacaoListaRespostaFisica(usuario.Text);
                gridResposta.Rows.Clear();
                gridResposta.ColumnCount = 8;
                foreach( Web_Cliente.webservice3.Item_Pedido ip in ips){
                    double total = (ip.valor_unitario * ip.qantidade);
                    gridResposta.Rows.Add(
                        ip.codigo,
                        //ip.fisca.nome,
                        ip.Produto.nome,
                        ip.Produto.Codigo_produto_,
                        ip.valor_unitario,
                        ip.qantidade,
                        total,
                        ip.status,
                        ip.data
                    );
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        String text;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               Item_Pedido ip = new Item_Pedido();
               if (quantidade.Text != "")
               {
                   ip.qantidade = int.Parse(quantidade.Text);
               }
               else
               {
                   ip.qantidade = 1;
               }
               Pessoa p = new Pessoa();
               p.mail = usuario.Text;
               ip.Codigo_pessoa = ip.idPessoa(p);
               List<Produto> produtos = this.produtos;
               foreach (Produto pr in produtos)
               {
                   ip.insertPedido(pr, ip);
               }
               MessageBox.Show("Solicitação Efetuada");
            }catch(Exception ex)
            {
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
                selected.ColumnCount = 3;
                selected.Rows.Add(
                    produto.Codigo_produto_,
                    produto.nome_produto,
                    produto.preco
                );
                produtos.Add(produto);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        
       
    }
}
