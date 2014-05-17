using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.webservice2;
using Frigorifico.Classes;

namespace Frigorifico.Layouts
{
    public partial class Solicitacoa_Clientes : Form
    {
        public Solicitacoa_Clientes()
        {
            try
            {
                InitializeComponent();
                WebService1 clientelista = new WebService1();
                this.carregagrid(gridSolicita);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void carregagrid(DataGridView grid)
        {
            WebService1 clientelista = new WebService1();
            Frigorifico.webservice2.Item_Pedido[] ips = clientelista.solicitacaoListaFisica();
            grid.Rows.Clear();
            grid.ColumnCount = 9;
            foreach (Frigorifico.webservice2.Item_Pedido ip in ips)
            { 
                double total = (ip.qantidade * ip.valor_unitario);
                grid.Rows.Add(
                    ip.Produto.nome,
                    ip.fisca.nome,
                    ip.Produto.Codigo_produto_,
                    ip.valor_unitario,
                    ip.qantidade,
                    total,
                    ip.status,
                    ip.data,
                    ip.codigo
                );
            }
        }

        private void gridSolicita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Entrega entrega = new Entrega();
            nomeCliente.Text = gridSolicita.CurrentRow.Cells[1].Value.ToString();
            entrega.Codigo_entrega = int.Parse(gridSolicita.CurrentRow.Cells[8].Value.ToString());
        }
    }
}
