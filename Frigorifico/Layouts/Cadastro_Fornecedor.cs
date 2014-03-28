using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.Classes.Controle;
using Frigorifico.Classes;
using System.Data.SqlClient;

namespace Frigorifico.Layouts
{
    public partial class Cadastro_Fornecedor : Form
    {
        public void carregar_grid() {
            Fornecedor fornecedor = new Fornecedor();
            SqlDataReader read = fornecedor.dadoslistados2(dataGridView_forn_ju);
            while (read.Read())
            {
                dataGridView_forn_ju.Rows.Add(
                    read[0].ToString(),
                    read[1].ToString(),
                    read[2].ToString(),
                    read[3].ToString(),
                    read[4].ToString(),
                    read[5].ToString(),
                    read[6].ToString(),
                    read[7].ToString(),
                    read[8].ToString(),
                    read[9].ToString(),
                    read[10].ToString(),
                    read[11].ToString()
                );
            }
        }

        public Cadastro_Fornecedor()
        {
            InitializeComponent();
            cpf_forn.Mask = "000.000.000-00";
            cpf_forn.MaxLength = 14;
            cep_forn.Mask = "00000-000";
            cep_forn.MaxLength = 9;
            telefone_forn.Mask = "(00)0000-0000";
            telefone_forn.MaxLength = 13;
            celular_forn.Mask = "(00)0000-0000";
            celular_forn.MaxLength = 13;

            ////////////////////////////////////

            cnpj_forn.Mask = "000.000.000/0000-00";
            cnpj_forn.MaxLength = 19;
            cep_ju_forn.Mask = "00000-000";
            cep_ju_forn.MaxLength = 9;
            telefone_ju_forn.Mask = "(00)0000-0000";
            telefone_ju_forn.MaxLength = 13;
            celular_ju_forn.Mask = "(00)0000-0000";
            celular_ju_forn.MaxLength = 13;
            complemento_forn.MaxLength = 10;
            /////////////////////////////////////////

            est_forn.SelectedItem = "Pernambuco";
            carregar_grid();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {

                Pessoa pessoa = new Pessoa();
                Fornecedor fornecedor = new Fornecedor();

                pessoa.telefone = telefone_ju_forn.Text;
                pessoa.celular = celular_ju_forn.Text;
                pessoa.mail = mail_ju_forn.Text;
                pessoa.estado = est_forn.Text;
                pessoa.cep = cep_ju_forn.Text;
                pessoa.municipio = municipio_ju_forn.Text;
                pessoa.complemento = complemento_ju_forn.Text;
                pessoa.numero = int.Parse(numero_ju_forn.Text);
                pessoa.Senha = senha_ju_forn.Text;

                fornecedor.j.Cnpj = cnpj_forn.Text; //juridica.Cnpj;

                if (!pessoa.verifica_duplicata2(pessoa))
                {

                    if (!fornecedor.verifica_duplicata_fornecedor(fornecedor))
                    {
                        //alterar tamanho de cnpj no banco
                        pessoa.insert2(pessoa);
                        Pessoa codigo = pessoa.lista_cod2(pessoa);
                        fornecedor.Codigo_pessoa = codigo.Codigo_pessoa;
                        fornecedor.j.responsavel = responsavel_ju_forn.Text;
                        fornecedor.j.razao_social = razao_forn.Text;
                        fornecedor.j.nome_fantasia = nome_fantasia_forn.Text;
                        fornecedor.j.Senha = senha_ju_forn.Text;
                        fornecedor.insert(fornecedor);
                        carregar_grid();
                    }
                    else {
                        MessageBox.Show("CNPJ já consta no banco");
                    }
                }
                else {
                    MessageBox.Show("Dados já existem no banco de dados");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
