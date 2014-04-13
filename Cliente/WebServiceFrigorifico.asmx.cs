using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Frigorifico.Classes;
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

    }
}
