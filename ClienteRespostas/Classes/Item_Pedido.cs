using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frigorifico.Classes
{
    public class Item_Pedido
    {
        public int codigo;
        public int qantidade;
        public double valor_unitario;
        public string status;
        public String data;
        public Produto Produto;
        //public Produto Produto
        //{
            //get
            //{
              // throw new System.NotImplementedException();
            //}
            //set
            //{
            //}
        //}

        public Fisica fisca;
        public Juridica juridica;
    }
}
