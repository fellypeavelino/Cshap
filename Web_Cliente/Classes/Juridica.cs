using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frigorifico.Classes
{
    public class Juridica : Pessoa
    {
        private String cnpj;

        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public String nome_fantasia;
        public String razao_social;
        public String responsavel;
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        /*
        public void insert(Juridica j) { 
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            String sql = "insert into juridica (cnpj, nome_fantasia, razao_social, codigo, responsavel) values ('"+j.Cnpj+"', '"+j.nome_fantasia+"', '"+j.razao_social+"', "+j.Codigo_pessoa+", '"+j.responsavel+"');";
            MySqlCommand Command = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            Command.ExecuteNonQuery();
            myConnection.Close();
        }

        public Boolean verifica_duplicata(Juridica j) {
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            Boolean conta;
            String sql = "select * from juridica where cnpj='"+j.Cnpj+"'";
            MySqlCommand Command = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            MySqlDataReader read = Command.ExecuteReader();
            conta = read.HasRows;
            myConnection.Close();
            return conta;
        }

        /*Sqlserver*/

        public void insert2(Juridica j)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "insert into juridica (cnpj, nome_fantasia, razao_social, codigo, responsavel) values ('" + j.Cnpj + "', '" + j.nome_fantasia + "', '" + j.razao_social + "', " + j.Codigo_pessoa + ", '" + j.responsavel + "');";
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        public Boolean verifica_duplicata2(Juridica j)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            Boolean conta;
            String sql = "select * from juridica where cnpj='" + j.Cnpj + "'";
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader read = Command.ExecuteReader();
            conta = read.HasRows;
            Connection.Close();
            return conta;
        }
        /*
        public SqlDataReader dadoslistados2(DataGridView dgv)
        {
            Banco b = new Banco();
            SqlConnection con = b.con2();
            dgv.Rows.Clear();
            dgv.ColumnCount = 12;
            var sql = "select cnpj, nome_fantasia, razao_social,responsavel, telefone, celular, email, estado, cep, municipio, complemento, numero from juridica, pessoa where pessoa.codigo = juridica.codigo";
            SqlCommand comand = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader read = comand.ExecuteReader();
            return read;
        }
        */
    }
}
