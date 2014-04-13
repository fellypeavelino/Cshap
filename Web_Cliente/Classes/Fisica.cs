using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frigorifico.Classes
{
    public class Fisica : Pessoa
    {
        private String cpf;

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public String nome;
        public String sexo;
        public String nascimento;
        //private String senha;
        /*
        public void insert(Fisica f) {
            Banco banco = new Banco();
            MySqlConnection myConnection = banco.con();
            String sql = "insert into fisica (cpf, nome, codigo, sexo, nascimento) values ('" + f.Cpf + "', '" + f.nome + "', " +f.Codigo_pessoa+ " ,'" + f.sexo + "', " + f.nascimento + ")";
            MySqlCommand Commando = new MySqlCommand(sql, myConnection);
            myConnection.Open();
            Commando.ExecuteNonQuery();
            myConnection.Close();
        }

        /*sql server*/

        public void insert2(Fisica f)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "insert into fisica (cpf, nome, codigo, sexo, nascimento) values ('" + f.Cpf + "', '" + f.nome + "', " + f.Codigo_pessoa + " ,'" + f.sexo + "', '" + f.nascimento + "')";
            SqlCommand Commando = new SqlCommand(sql, Connection);
            Connection.Open();
            Commando.ExecuteNonQuery();
            Connection.Close();
        }

        public SqlDataReader dadoslistados2(DataGridView dgv)
        {
            Banco b = new Banco();
            SqlConnection con = b.con2();
            dgv.Rows.Clear();
            dgv.ColumnCount = 8;
            var sql = "select cpf, nome, sexo, nascimento ,telefone, celular, email, estado, cep, municipio, complemento, numero from pessoa, fisica where pessoa.codigo = fisica.codigo";
            SqlCommand comand = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader read = comand.ExecuteReader();
            return read;
        }

        public Boolean verifica_duplicata2(Fisica f)
        {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            Boolean conta;
            String sql = "select * from fisica where cpf='" +f.Cpf+ "'";
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader read = Command.ExecuteReader();
            conta = read.HasRows;
            Connection.Close();
            return conta;
        }

        public Fisica lista_codigo_pessoa(Fisica f) {
            Fisica pessoa = new Fisica();
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "select * from pessoa, fisica where fisica.cpf='" + f.Cpf + "' and fisica.codigo = pessoa.codigo";
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader read2 = Command.ExecuteReader();
            while(read2.Read()){
                pessoa.telefone = read2[1].ToString();
                pessoa.celular = read2[2].ToString();
                pessoa.mail = read2[3].ToString();
                pessoa.estado = read2[4].ToString();
                pessoa.cep = read2[5].ToString();
                pessoa.municipio = read2[6].ToString();
                pessoa.complemento = read2[7].ToString();
                pessoa.numero = int.Parse(read2[8].ToString());
                pessoa.Senha = read2[9].ToString();
                pessoa.nome = read2[11].ToString();
                pessoa.sexo = read2[13].ToString();
                pessoa.nascimento = read2[14].ToString();
            }
            Connection.Close();
            return pessoa;
        }


        public void autualizar(Fisica f) { 
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "update pessoa set telefone='" + f.telefone + "', celular='" + f.celular + "', email='" + f.mail + "' ";
            sql += " , estado='" + f.estado + "', cep='" + f.cep + "', municipio='" + f.municipio + "', complemento='" + f.complemento + "'";
            sql += " , numero=" + f.numero + ", senha='" + f.Senha + "' where codigo ="+f.Codigo_pessoa;
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
            //ageitar , nascimento='" + f.nascimento + "'
            String sql2 = "update fisica set nome='" + f.nome + "', sexo='" + f.sexo + "' where cpf='" + f.Cpf + "'";
            SqlCommand Command2 = new SqlCommand(sql2, Connection);
            Connection.Open();
            Command2.ExecuteNonQuery();
            Connection.Close();
        }

        public void deletar(Fisica f) { 
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            //String sql = "delete from fisica where cpf='" + f.Cpf + "'";
            String sql = "select codigo from fisica where cpf='" + f.Cpf + "'";
            SqlCommand Command = new SqlCommand(sql, Connection);
            Connection.Open();
            SqlDataReader read = Command.ExecuteReader();
            int codigo = 0;
            while(read.Read()){
                codigo = (Int32)read.GetValue(read.GetOrdinal("codigo"));
            }
            Connection.Close();

            if(codigo != 0){
                String sql2 = "delete from fisica where codigo=" + codigo;
                String sql3 = "delete from pessoa where codigo=" + codigo;
                SqlCommand Command2 = new SqlCommand(sql2, Connection);
                SqlCommand Command3 = new SqlCommand(sql3, Connection);
                Connection.Open();
                Command2.ExecuteNonQuery();
                Command3.ExecuteNonQuery();
                Connection.Close();
            }
        }

    }
}
