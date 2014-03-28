using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frigorifico.Classes.Controle
{
    class Mascara
    {
        
        public String CPF(String variavel) {
            if (variavel.Length == 9)
            {
              variavel += "-";
            }
            return variavel;
        }

        public String CEP(String variavel)
        {
            if (variavel.Length == 5)
            {
                variavel += "-";
            }
            return variavel;
        }

        public String fone(String variavel) {
            switch (variavel.Length)
            {
                case 1:
                    variavel = "(" + variavel;
                    break;
                case 3:
                    variavel += ")";
                    break;
                case 8:
                    variavel += "-";
                    break;
            }
            return variavel;
        }
    }
}
