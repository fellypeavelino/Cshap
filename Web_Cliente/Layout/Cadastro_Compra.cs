using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Cliente.Layout
{
    public partial class Cadastro_Compra : Form
    {
        public Cadastro_Compra(Form1 frm1)
        {
            InitializeComponent();
            nome_usuario.Text = frm1.login;
        }
    }
}
