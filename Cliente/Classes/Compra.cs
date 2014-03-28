using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Compra
    {
        private int codigo_compra;
        public Cliente c;
        public double valor_total;

        public Item_Pedido Item_Pedido
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
