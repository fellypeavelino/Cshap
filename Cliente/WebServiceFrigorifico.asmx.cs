using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Frigorifico.Classes;
using Cliente.Account;
using System.Data.SqlClient;

namespace Cliente
{
    /// <summary>
    /// Summary description for WebServiceFrigorifico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceFrigorifico : System.Web.Services.WebService
    {
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Boolean login(Pessoa p) {
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "select * from pessoa where email='"+p.mail+"' and senha='"+ p.Senha+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            Boolean conta = read.HasRows;
            connection.Close();
            return conta;
        }

        [WebMethod]
        public List<Tipo> nome_tipo() {
            List<Tipo> nomes = new List<Tipo>();
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "select nome from tipo";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while(read.Read()){
                Tipo nome = new Tipo();
                nome.nome = read[0].ToString();
                nomes.Add(nome);
            }
            connection.Close();
            return nomes;
        }


        [WebMethod]
        public List<Produto> listaProdutoWeb()
        {
            Produto produto = new Produto();
            List<Produto> p = produto.lista();
            return p;
        }

        [WebMethod]
        public int id_tipo(Produto p) {
            int id = 0;
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "select id_tipo from tipo where nome='"+p.nome+"'";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {
                id = int.Parse(read[0].ToString());
            }
            return id;
        } 

        [WebMethod]
        public List<Produto> pesquisarProdutos(Produto produto)
        {
            List<Produto> produtos = new List<Produto>();
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            int id = this.id_tipo(produto);
            String sql = "";
            if (produto.nome_produto != "" && id != 0)
            {
                sql = "select id_produto, nome, preco, peso from produto where nome='" + produto.nome_produto + "' and id_tipo=" + id;
            }
            else if (produto.nome_produto != "")
            {
                sql = "select id_produto, nome, preco, peso from produto where nome='" + produto.nome_produto + "'";
            }
            else if (id != 0)
            {
                sql = "select id_produto, nome, preco, peso from produto where id_tipo=" + id;
            }
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                Produto p = new Produto();
                p.Codigo_produto_ = int.Parse(read[0].ToString());
                p.nome_produto = read[1].ToString();
                p.peso = float.Parse(read[2].ToString());
                p.preco = double.Parse(read[3].ToString());
                produtos.Add(p);
            }
            return produtos;
        }

    }
}
