using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Entregador : Pessoa
    {
        private int matricula;
        public char habilitacao;
        public String Nome;
        public String tipoHabiliatacao;

        public Veiculo Veiculo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

    }
}
