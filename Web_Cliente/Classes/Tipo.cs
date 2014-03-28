using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Frigorifico.Classes
{
    public class Tipo
    {
        public int codigo_tipo;
        public String nome;

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

        public void insert(Animal animal) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into tipo (nome) values ('"+animal.tipo.nome+"');";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Boolean verifica_duplicata(Animal animal)
        {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select * from tipo where nome = '"+animal.tipo.nome+"';";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            Boolean row = read.HasRows;
            connection.Close();
            return row;
        }

        public List<Tipo> lista_nome_tipo() {
            List<Tipo> nome = new List<Tipo>();
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select nome from tipo";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while(read.Read()){
                Tipo tipo = new Tipo();
                tipo.nome = read[0].ToString();
                nome.Add(tipo);
            }
            connection.Close();
            return nome;
        }

        public int id_tipo(Animal animal) {
            int id = 0;
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select id_tipo from tipo where nome = '"+animal.tipo.nome+"';";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while(read.Read()){
                id = int.Parse(read[0].ToString());
            }
            connection.Close();
            return id;
        }
    }
}
