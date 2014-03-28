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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WebServiceFrigorifico wsf = new WebServiceFrigorifico();
            Pessoa pessoa = new Pessoa();
            pessoa.mail = mail.Text;
            pessoa.Senha = senha.Text;
            if (wsf.login(pessoa))
            {
                MessageBox.Show("ok");
            }
            else {
                MessageBox.Show("não");
            }
        }

        
    }
}
