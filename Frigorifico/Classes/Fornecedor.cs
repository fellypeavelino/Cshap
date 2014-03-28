using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frigorifico.Classes
{
    public class Fornecedor : Pessoa
    {
        private int codigo_fornecdor;

        public int Codigo_fornecdor
        {
            get { return codigo_fornecdor; }
            set { codigo_fornecdor = value; }
        }
        public Juridica j = new Juridica();

        public Animal Animal
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /*sqlserver*/
        public void insert(Fornecedor f) {
            Banco b = new Banco();
            SqlConnection Connection = b.con2();
            String sql = "insert into fornecedor (nome, cnpj, nome_fantasia, razao_social, senha, id_pessoa) ";
            sql+= " values ('" + f.j.responsavel + "', '" + f.j.Cnpj + "', '" + f.j.nome_fantasia + "', '" + f.j.razao_social + "', '" + f.j.Senha + "', " + f.Codigo_pessoa + ")";
            SqlCommand Commando = new SqlCommand(sql, Connection);
            Connection.Open();
            Commando.ExecuteNonQuery();
            Connection.Close();
        }

        public Boolean verifica_duplicata_fornecedor(Fornecedor f) {
            Banco banco = new Banco();
            SqlConnection Connection = banco.con2();
            String sql = "select id_fornecedor from fornecedor where cnpj='"+f.j.Cnpj+"'";
            SqlCommand Commando = new SqlCommand(sql, Connection);
            Boolean conta;
            Connection.Open();
            SqlDataReader read = Commando.ExecuteReader();
            conta = read.HasRows;
            Connection.Close();
            return conta;
        }

        public SqlDataReader dadoslistados2(DataGridView dgv)
        {
            Banco b = new Banco();
            SqlConnection con = b.con2();
            dgv.Rows.Clear();
            dgv.ColumnCount = 12;
            var sql = "select nome, cnpj, nome_fantasia, razao_social, telefone, celular, email, estado, cep, municipio, complemento, numero from pessoa, fornecedor where fornecedor.id_pessoa = pessoa.codigo ";
            SqlCommand comand = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader read = comand.ExecuteReader();
            return read;
        }
    }
}
