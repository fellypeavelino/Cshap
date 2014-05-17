using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frigorifico.Layouts
{
    public partial class Cadastro_Entregador : Form
    {
        public Cadastro_Entregador()
        {
            InitializeComponent();
            data_pef.Mask = "0000/00/00";
            data_pef.MaxLength = 11;
            cep_pef.Mask = "00000-000";
            cep_pef.MaxLength = 9;
            celular_pef.Mask = "(00)0000-0000";
            celular_pef.MaxLength = 13;
            telefone_pef.Mask = "(00)0000-0000";
            telefone_pef.MaxLength = 13;
            complemento_pef.MaxLength = 12;
        }
    }
}
