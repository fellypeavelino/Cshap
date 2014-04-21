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
    public partial class Form1 : Form
    {
        public String login;

        public Form1()
        {
            InitializeComponent();
            menu.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Show();
        }

        private void but_logar_Click(object sender, EventArgs e)
        {
            try
            {
                WebServiceFrigorifico wsf = new WebServiceFrigorifico();
                Pessoa pessoa = new Pessoa();
                pessoa.mail = mail.Text;
                pessoa.Senha = senha.Text;
                if (wsf.login(pessoa))
                {
                    login = mail.Text;
                    menu.Enabled = true;
                    erro.Text = "";
                }
                else
                {
                    erro.Text = "Login ou senha invalidos";
                }
            }catch(Exception ex ){
                MessageBox.Show(ex.Message);
            }
        }

        private void visualizaçãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizacao_Produto vp = new Visualizacao_Produto();
            vp.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Compra ccompra = new Cadastro_Compra(this);
            ccompra.Show();
        }

        private void solicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
