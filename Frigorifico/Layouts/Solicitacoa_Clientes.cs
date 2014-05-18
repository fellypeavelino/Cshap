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

        int idItem;
        private void gridSolicita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Frigorifico.Classes.Entrega entrega = new Frigorifico.Classes.Entrega();
                nomeCliente.Text = gridSolicita.CurrentRow.Cells[1].Value.ToString();
                this.idItem = int.Parse(gridSolicita.CurrentRow.Cells[8].Value.ToString());
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebService1 clientelista = new WebService1();
                Frigorifico.webservice2.Entrega entrega = new Frigorifico.webservice2.Entrega();
                Frigorifico.webservice2.Item_Pedido ip = new webservice2.Item_Pedido();
                entrega.nome = nomeCliente.Text;
                clientelista.updateStatu(idItem);
                entrega.data_entrega = hora.Text + ":" + minuto.Text;
                entrega.data_entrega = data.Text;
                ip.codigo = idItem;
                entrega.item_pedido = ip;
                clientelista.insertEntrega(entrega);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
