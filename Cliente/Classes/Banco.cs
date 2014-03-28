using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Frigorifico.Classes
{
    public class Banco
    {
        public Banco() { 
        
        }

        /*mysql
        public MySqlConnection con()
        {
            MySqlConnection teste = new MySqlConnection("server=localhost;User Id=root;database=frigorifico2; password=");
            if (teste == null)
            {
                throw new Exception("Erro na Conexão com mysql");
            }
            //Console.WriteLine("ok");
            return teste;
        }

        /*sql erver*/
        public SqlConnection con2() {
            //"Data Source=MRIADOCARMO-PC\\SQLEXPRESS1;Initial Catalog=frigorifico2;User id=felipe2;Password=nirvana"
            //"Data Source=S1-C2-08;Initial Catalog=frigorifico2;User id=felipe;Password=nirvana"

            SqlConnection sql = new SqlConnection("Data Source=S1-A9-10;Initial Catalog=frigorifico2;User id=felipe2;Password=nirvana");
            
            return sql;
        }
    }
}
