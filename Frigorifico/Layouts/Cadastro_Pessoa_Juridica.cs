using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.Classes;
using System.Data.SqlClient;

namespace Frigorifico.Layouts
{
    public partial class Cadastro_Pessoa_Juridica : Form
    {
        public Cadastro_Pessoa_Juridica()
        {
            InitializeComponent();
            cnpj_ju.Mask = "000.000.000/0000-00";
            cnpj_ju.MaxLength = 19;
            cep_ju.Mask = "00000-000";
            cep_ju.MaxLength = 9;
            celular_ju.Mask = "(00)0000-0000";
            celular_ju.MaxLength = 13;
            telefone_ju.Mask = "(00)0000-0000";
            telefone_ju.MaxLength = 13;
            estado_ju.SelectedItem = "Pernambuco";
            try { 
                //dataGridView_cadju
                Juridica juridica = new Juridica();
                SqlDataReader read = juridica.dadoslistados2(dataGridView_cadju);
                while (read.Read())
                {
                    dataGridView_cadju.Rows.Add(
                        read[0].ToString(),
                        read[1].ToString(),
                        read[2].ToString(),
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
            }catch(Exception ex){}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.telefone = telefone_ju.Text;
                pessoa.celular = celular_ju.Text;
                pessoa.mail = mail_ju.Text;
                pessoa.estado = estado_ju.Text;
                pessoa.cep = cep_ju.Text;
                pessoa.municipio = municipio_ju.Text;
                pessoa.complemento = complemento_ju.Text;
                pessoa.numero = int.Parse(numero_ju.Text);
                pessoa.Senha = senha_ju.Text;

                Juridica juridica = new Juridica();
                Pessoa p = new Pessoa();
                juridica.Cnpj = cnpj_ju.Text;
                

                if (!pessoa.verifica_duplicata2(pessoa))
                {
                    if (!juridica.verifica_duplicata2(juridica))
                    {
                        pessoa.insert2(pessoa);
                        p = pessoa.lista_cod2(pessoa);
                        juridica.Codigo_pessoa = p.Codigo_pessoa;
                        juridica.nome_fantasia = nome_ju.Text;
                        juridica.razao_social = razao_ju.Text;
                        juridica.responsavel = responsavel_ju.Text;
                        juridica.insert2(juridica);

                        SqlDataReader read = juridica.dadoslistados2(dataGridView_cadju);
                        while (read.Read())
                        {
                            dataGridView_cadju.Rows.Add(
                                read[0].ToString(),
                                read[1].ToString(),
                                read[2].ToString(),
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
                    else {
                        MessageBox.Show("cnpj selecionados já constam no banco");
                    }
                }
                else {
                    //telefone_ju.BackColor = 'black';
                    MessageBox.Show("dados selecionados já constam no banco");
                }

            }catch(Exception ex){

                MessageBox.Show(ex.Message);
            }

        }

    }
}
