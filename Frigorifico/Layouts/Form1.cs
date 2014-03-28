using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.Classes;
using Frigorifico.Layouts;
using System.Diagnostics;

namespace Frigorifico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Banco b = new Banco();
            b.con2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "C:/wamp/wampmanager.exe";
            //p.Start();
        }

        private void logar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();

                p.Codigo_pessoa = int.Parse(login.Text);
                p.Senha = senha.Text;

                if (p.login2(p))
                {
                    Desktop d = new Desktop(this);
                    d.Show();
                }
                else {
                    MessageBox.Show("dados não cosntam no banco");
                }
            }
            catch (Exception ex) {
                label_erro.Text ="Necessario preenchimento da matricula com valor numerico";
            }
            
        }

        private void senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            //senha.PasswordChar = '*';
        }
    }
}
