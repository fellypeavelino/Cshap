using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Produto
    {
        private int codigo_produto;
        public double preco;
        public float peso;
        public String nome;

        public Solicitacao Solicitacao
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Estque Estque
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
