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

        public void insert(Produto p, Item_Pedido ip) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itenspedidos (quantidade, valor_unitario, id_produto) values ";
            sql += "("+ip.qantidade+", "+p.preco+", "+p.Codigo_produto_+")";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
