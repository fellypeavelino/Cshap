using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Frigorifico.Classes
{
    public class Pessoa
    {
        private int codigo_pessoa;

        public int Codigo_pessoa
        {
            get { return codigo_pessoa; }
            set { codigo_pessoa = value; }
        }
        public String telefone;
        public String celular;
        public String mail;
        public String endereco;
        private String senha;
        public String estado, cep, municipio, logradouro, complemento;
        public int numero;
        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        /*
        public Boolean login(Pessoa p) {
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            String sql = "select codigo, senha from pessoa where codigo="+p.codigo_pessoa+" and senha='"+p.senha+"'";
            MySqlCommand Commando = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            MySqlDataReader dados = Commando.ExecuteReader();
            return dados.HasRows;
        }

        public void insert(Pessoa p)
        {
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            String sql = "insert into pessoa (telefone, celular, email, estado, cep, municipio, complemento, numero, senha) values ";
            sql += "('"+p.telefone+"','"+p.celular+"', '"+p.mail+"', '"+p.estado+"', '"+p.cep+"', '"+p.municipio+"', '"+p.complemento+"', "+p.numero+", '"+p.senha+"')";
            MySqlCommand Commando = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            Commando.ExecuteNonQuery();
            myConnection.Close();
        }

        public Pessoa lista_cod(Pessoa p)
        {
            //List<Pessoa> codigo = new List<Pessoa>();
            Pessoa codigo = new Pessoa();
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            //String sql = "select codigo from pessoa where telefone='11111111' and celular='1111111111' and email='111111111111111'";
            String sql = "select codigo from pessoa where telefone='"+p.telefone+"' and celular='"+p.celular+"' and email='"+p.mail+"'";
            MySqlCommand Command = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            MySqlDataReader read = Command.ExecuteReader();
            while(read.Read()){
                codigo.Codigo_pessoa = (Int32)read.GetValue(read.GetOrdinal("codigo"));
            }
            myConnection.Close();
            return codigo;
        }

        public Boolean verifica_duplicata(Pessoa p) {
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            String sql = "select codigo from pessoa where telefone='" + p.telefone + "' and celular='" + p.celular + "' and email='" + p.mail + "'";
            Boolean conta;
            MySqlCommand Command = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            MySqlDataReader read = Command.ExecuteReader();
            conta = read.HasRows;
            myConnection.Close();
            return conta; 
        }

        /*sql server */

        public Boolean login2(Pessoa p)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            Connection.Open();
            String sql = "select codigo, senha from pessoa where codigo=" + p.codigo_pessoa + " and senha='" + p.senha + "'";
            SqlCommand Commando = new SqlCommand(sql, Connection);
            SqlDataReader dados = Commando.ExecuteReader();
            return dados.HasRows;
        }

        public void insert2(Pessoa p)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "insert into pessoa (telefone, celular, email, estado, cep, municipio, complemento, numero, senha) values ";
            sql += "('" + p.telefone + "','" + p.celular + "', '" + p.mail + "', '" + p.estado + "', '" + p.cep + "', '" + p.municipio + "', '" + p.complemento + "', " + p.numero + ", '" + p.senha + "')";
            SqlCommand Commando = new SqlCommand(sql, Connection);
            Connection.Open();
            Commando.ExecuteNonQuery();
            Connection.Close();
        }

        public Pessoa lista_cod2(Pessoa p)
        {
            
            Pessoa codigo = new Pessoa();
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "select codigo from pessoa where telefone='" + p.telefone + "' and celular='" + p.celular + "' and email='" + p.mail + "'";
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader read = Command.ExecuteReader();
            while (read.Read())
            {
                codigo.Codigo_pessoa = (Int32)read.GetValue(read.GetOrdinal("codigo"));
            }
            Connection.Close();
            return codigo;
        }

        public Boolean verifica_duplicata2(Pessoa p)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "select codigo from pessoa where telefone='" + p.telefone + "' and celular='" + p.celular + "' and email='" + p.mail + "'";
            Boolean conta;
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader read = Command.ExecuteReader();
            conta = read.HasRows;
            Connection.Close();
            return conta;
        }
    }
}
