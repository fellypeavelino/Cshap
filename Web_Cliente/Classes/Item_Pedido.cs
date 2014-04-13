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

        public void insert(Produto p, Item_Pedido ip)
        {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itenspedidos (quantidade, valor_unitario, id_produto) values ";
            sql += "(" + ip.qantidade + ", " + p.preco + ", " + p.Codigo_produto_ + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public int idItemPedido(Produto p, Item_Pedido ipedido)
        {
            int id = 0;
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select top id_itens from itenspedidos where quantidade=" + ipedido.qantidade + ", id_produto=" + p.Codigo_produto_;
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {
                id = int.Parse(read[0].ToString());
            }
            return id;
        }
    }
}
