using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Logon
    {
        Fisica fisica = new Fisica();
        Juridica juridica = new Juridica();

        private String id_usuario;

        public String Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
