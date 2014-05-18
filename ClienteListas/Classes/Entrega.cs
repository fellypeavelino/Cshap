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
        public String data_entrega;
        public String horario_entrega;
        public Item_Pedido item_pedido;
    }
}
