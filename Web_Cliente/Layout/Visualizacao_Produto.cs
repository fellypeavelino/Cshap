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
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
