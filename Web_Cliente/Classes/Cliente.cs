using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Cliente : Pessoa
    {
        private int codigo_client;

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

        public Compra Compra
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
