using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Biblioteca_Classe.Banco
{
    public class Connect
    {
        public Connect(){
    
        }

        public MySqlConnection con() {
            MySqlConnection teste = new MySqlConnection("server=localhost;User Id=root;database=frigorifico2; password=");
            if (teste == null)
            {
                throw new Exception("Erro na Conexão");
            }
            Console.WriteLine("ok");
            return teste;
        }
    }
}
