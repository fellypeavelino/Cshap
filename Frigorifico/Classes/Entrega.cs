using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Entrega
    {
        private int codigo_entrega;

        public int Codigo_entrega
        {
            get { return codigo_entrega; }
            set { codigo_entrega = value; }
        }
        public String nome;
        public DateTime data_entrega;
        public DateTime horario_entrega;

    }
}
