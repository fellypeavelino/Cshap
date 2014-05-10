using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Frigorifico.Classes
{
    public class Item_Pedido
    {
        public int qantidade;
        public double valor_unitario;

        public Produto Produto
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void insertPedidos(Produto p, Item_Pedido ip, Pessoa pe) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itenspedidos (quantidade, valor_unitario, id_produto, codigo_pessoa) values ";
            sql += "("+ip.qantidade+", "+p.preco+", "+p.Codigo_produto_+", "+pe.Codigo_pessoa+")";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void insertCompra(Produto p, Item_Pedido ip, Pessoa pe) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itens_compra (quantidade, valor_unidade, id_compra, codigo_pessoa) values ";
            sql += "(" + ip.qantidade + ", " + p.preco + ", " + p.Codigo_produto_ + ", " + pe.Codigo_pessoa + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
