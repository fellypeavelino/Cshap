using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Solicitacao
    {
        private int codigo_solicitacao;
        public String descricao;
        public Cliente c;
        public Produto p;

        public Entrega Entrega
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
