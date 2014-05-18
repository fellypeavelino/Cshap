using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Frigorifico.Classes;
using System.Data.SqlClient;

namespace ClienteRespostas
{
    /// <summary>
    /// Summary description for WebServiceRespostas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceRespostas : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Item_Pedido> solicitacaoListaRespostaFisica(String email) {
            int idfisica;
            idfisica = this.idPessoaFisica(email);
            List<Item_Pedido> ips = new List<Item_Pedido>();
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "select distinct id_itens, fisica.nome, produto.nome, produto.id_produto, itenspedidos.valor_unitario, ";
            sql += " itenspedidos.quantidade, itenspedidos.statos, entregas.data, entregas.horario ";
            sql += " from fisica, produto, itenspedidos, entregas where ";
            sql += " itenspedidos.id_produto = produto.id_produto and ";
            sql += " itenspedidos.codigo_pessoa = fisica.codigo and ";
            sql += " itenspedidos.statos ='E' and fisica.codigo = " + idfisica+" ";
            sql += " and entregas.id_item = itenspedidos.id_itens ";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                Item_Pedido ip = new Item_Pedido();
                Fisica f = new Fisica();
                Produto p = new Produto();
                ip.codigo = int.Parse(read[0].ToString());
                f.nome = read[1].ToString();
                ip.fisca = f;
                p.nome = read[2].ToString();
                p.Codigo_produto_ = int.Parse(read[3].ToString());
                ip.Produto = p;
                ip.valor_unitario = double.Parse(read[4].ToString());
                ip.qantidade = int.Parse(read[5].ToString());
                ip.status = read[6].ToString();
                ip.data = read[7].ToString() + " " + read[8].ToString();
                ips.Add(ip);
            }
            connection.Close();
            return ips;
        }

        public int idPessoaFisica(String email) { 
            int id = 0;
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "select fisica.codigo from fisica,pessoa where pessoa.email ='" + email + "' ";
            sql += " and fisica.codigo = pessoa.codigo;";
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
