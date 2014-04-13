using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.Classes;

namespace Frigorifico
{
    public partial class Cadastro_Poduto : Form
    {
        public Cadastro_Poduto()
        {
            InitializeComponent();
            try
            {
                Tipo tipo = new Tipo();
                List<Tipo> tipos = tipo.lista_nome_tipo();
                foreach (Tipo t in tipos)
                {
                    animal.Items.Add(t.nome);
                }
                animal.SelectedIndex = 0;

                this.carregagrid(gridProduto);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void carregagrid(DataGridView grid) {
            Produto produto = new Produto();
            List<Produto> p = produto.lista();
            grid.Rows.Clear();
            grid.ColumnCount = 4;
            foreach(Produto pro in p){
                grid.Rows.Add(
                    pro.Codigo_produto_,
                    pro.nome_produto,
                    pro.peso,
                    pro.preco
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                Produto produto = new Produto();
                produto.nome_produto = nome.Text;
                produto.preco = double.Parse(preco.Text);
                produto.peso = float.Parse(peso.Text);
                produto.nome = animal.Text;
                int id_tipo = produto.id_tipo(produto);
                if (id_tipo != 0) { 
                    produto.codigo_tipo = id_tipo;
                    //MessageBox.Show(produto.codigo_tipo+"");
                }
                produto.insert(produto);
                this.carregagrid(gridProduto);
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
