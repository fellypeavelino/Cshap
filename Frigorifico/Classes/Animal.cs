using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Frigorifico.Classes
{
    public class Animal
    {

        public int codigo_animal;
        public Tipo tipo = new Tipo();
        public float peso;
        public int quantdade;
        public double preco;
        public Fornecedor fornecedor = new Fornecedor();
        public String recebimento;

        public SqlDataReader nome_fantasia_fornecedor() {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select nome_fantasia from fornecedor";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            //connection.Close();
            return read;
        }

        public int id_fornecedor(ComboBox fornecedor) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select id_fornecedor from fornecedor where nome_fantasia = '"+fornecedor.Text+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            int id = 0;
            while(read.Read()){
                id = int.Parse(read[0].ToString());
            }
            connection.Close();
            return id;
        }

        public void insert(Animal animal) {
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "insert into animal (peso, preco, quantidade, id_fornecedor, id_tipo, recebimento) ";
            sql += " values ("+animal.peso+", "+animal.preco+", "+animal.quantdade+", "+animal.fornecedor.Codigo_fornecdor+", "+animal.tipo.codigo_tipo+", '"+animal.recebimento+"');";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Animal> lista_animal() {
            List<Animal> animais = new List<Animal>();
            Banco b = new Banco();
            SqlConnection connection = b.con2();
            String sql = "select tipo.nome, peso, preco, quantidade, nome_fantasia from fornecedor, animal, tipo where tipo.id_tipo = animal.id_tipo and animal.id_fornecedor = fornecedor.id_fornecedor";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while(read.Read()){
                Animal animal = new Animal();
                animal.tipo.nome = read[0].ToString();
                animal.peso = float.Parse(read[1].ToString());
                animal.preco = double.Parse(read[2].ToString());
                animal.quantdade = int.Parse(read[3].ToString());
                animal.fornecedor.j.nome_fantasia = read[4].ToString();
                animais.Add(animal);
            }
            connection.Close();
            return animais;
        }

    }
}
