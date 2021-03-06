﻿using System;
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
        private int codigo_pessoa;

        public int Codigo_pessoa
        {
            get { return codigo_pessoa; }
            set { codigo_pessoa = value; }
        }

        public char status;

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

        public void insertPedido(Produto p, Item_Pedido ip)
        {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itenspedidos (quantidade, valor_unitario, id_produto, codigo_pessoa, statos, data) values ";
            sql += "(" + ip.qantidade + ", " + p.preco + ", " + p.Codigo_produto_ + ", "+ip.codigo_pessoa+",'S', getdate())";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public int idPessoa(Pessoa p) {
            int id = 0;
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select codigo from pessoa where email='"+p.mail+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                id = int.Parse(read[0].ToString());
            }
            return id;
        }

        public int idItemPedido(Produto p, Item_Pedido ipedido)
        {
            int id = 0;
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select top 1 id_itens from itenspedidos where quantidade=" + ipedido.qantidade + " and id_produto=" + p.Codigo_produto_ + " and codigo_pessoa="+ipedido.Codigo_pessoa;
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {
                id = int.Parse(read[0].ToString());
            }
            return id;
        }

        public void insertCompra(Produto p, Item_Pedido ip)
        {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itens_compra (quantidade, valor_unidade, id_produto, codigo_pessoa, data) values ";
            sql += "(" + ip.qantidade + ", " + p.preco + ", " + p.Codigo_produto_ + ", " + ip.codigo_pessoa + ", GETDATE())";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        internal void insertCompra(Web_Cliente.servidor.Produto produto, Item_Pedido ip)
        {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into itens_compra (quantidade, valor_unidade, id_produto, codigo_pessoa, data) values ";
            sql += "(" + ip.qantidade + ", " + produto.preco + ", " + produto.Codigo_produto_ + ", " + ip.codigo_pessoa + ", GETDATE())";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
