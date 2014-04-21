using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Frigorifico.Classes
{
    public class Produto : Tipo
    {
        private int codigo_produto_;

        public int Codigo_produto_
        {
            get { return codigo_produto_; }
            set { codigo_produto_ = value; }
        }
        public double preco;
        public float peso;
        public String nome_produto;

        public Solicitacao Solicitacao
        {
            //get
            //{
                //throw new System.NotImplementedException();
            //}
            set
            {
            }
        }

        public Estque Estque
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void insert(Produto p) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into produto (nome, peso, preco, id_tipo) ";
            sql += " values ('"+p.nome_produto+"', "+p.peso+", "+p.preco+", "+p.codigo_tipo+")";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Produto> lista() {
            List<Produto> listas = new List<Produto>();
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select id_produto, nome, preco, peso from produto";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {
                Produto p = new Produto();
                p.Codigo_produto_ = int.Parse(read[0].ToString());
                p.nome_produto = read[1].ToString();
                p.peso = float.Parse(read[2].ToString());
                p.preco = double.Parse(read[3].ToString());
                listas.Add(p);
            }
            return listas;
        }

        public int id_tipo(Produto tipo) {
            int id = 0;
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select id_tipo from tipo where nome ='"+tipo.nome+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                id = int.Parse(read[0].ToString());
            }
            connection.Close();
            return id;
        }
    }
}
