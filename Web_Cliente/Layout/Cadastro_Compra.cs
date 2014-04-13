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


    }
}
