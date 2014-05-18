using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Frigorifico.Classes;
using System.Data.SqlClient;

namespace ClienteListas
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Item_Pedido> solicitacaoListaFisica(){
                List<Item_Pedido> ips = new List<Item_Pedido>();
                Banco banco = new Banco();
                SqlConnection connection = banco.con2();
                String sql = "select id_itens, fisica.nome, produto.nome, produto.id_produto, itenspedidos.valor_unitario, ";
                sql += " itenspedidos.quantidade, itenspedidos.statos, itenspedidos.data ";
                sql += " from fisica, produto, itenspedidos where ";
                sql += " itenspedidos.id_produto = produto.id_produto and ";
                sql += " itenspedidos.codigo_pessoa = fisica.codigo ";
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
                    ip.data = read[7].ToString();
                    ips.Add(ip);
                }
                connection.Close();
                return ips;
        }

        [WebMethod]
        public void updateStatu(int iditen) {
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "update itenspedidos set statos ='E' where id_itens = " + iditen;
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        [WebMethod]
        public void insertEntrega(Entrega ent) {
            Banco banco = new Banco();
            SqlConnection connection = banco.con2();
            String sql = "insert into entregas (cliente, data, horario, id_item) ";
            sql += "values ('" + ent.nome + "', '"+ ent.data_entrega +"', '"+ent.horario_entrega+"', "+ent.item_pedido.codigo+");";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
