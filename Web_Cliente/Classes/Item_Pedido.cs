using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Item_Pedido
    {
        public int qantidade;
        public double valor_unitario;

        public Produto Produto
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
