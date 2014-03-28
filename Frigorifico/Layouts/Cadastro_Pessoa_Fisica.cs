using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Frigorifico.Classes;
using System.Data.Common;
using System.Data.SqlClient;

namespace Frigorifico.Layouts
{
    public partial class Cadastro_Pessoa_Fisica : Form
    {
        public Cadastro_Pessoa_Fisica()
        {
            InitializeComponent();
            sexo_pef.SelectedItem = "Masculino";
            estado_pef.SelectedItem = "Pernambuco";
            button2.Enabled = false;
            button4.Enabled = false;
            try
            {
                Fisica fisica = new Fisica();
                SqlDataReader read = fisica.dadoslistados2(dataGridView_cadpefi);
                while (read.Read())
                {
                    dataGridView_cadpefi.Rows.Add(
                        read[0].ToString(),
                        read[1].ToString(),
                        read[2].ToString(),
                        read[3].ToString(),
                        read[4].ToString(),
                        read[5].ToString(),
                        read[6].ToString(),
                        read[7].ToString()
                    );
                }
                 
            }
            catch (Exception ex) { 
            
            }
        }

        private void senha_capefi_KeyPress(object sender, KeyPressEventArgs e)
        {
            senha_pef.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                Fisica f = new Fisica();

                f.Cpf = cpf_pef.Text;
                f.nome = nome_pef.Text;


                p.telefone = telefone_pef.Text;
                p.celular = celular_pef.Text;
                p.mail = mail_pef.Text;
                p.estado = estado_pef.Text;
                p.cep = cep_pef.Text;
                p.municipio = municipio_pef.Text;
                p.complemento = complemento_pef.Text;
                p.numero = int.Parse(numero_pef.Text);
                p.Senha = senha_pef.Text;

                f.Cpf = cpf_pef.Text;

                if (!p.verifica_duplicata2(p))
                {
                    if(!f.verifica_duplicata2(f)){
                        p.insert2(p);
                        Pessoa codigo = p.lista_cod2(p);
                        f.Codigo_pessoa = codigo.Codigo_pessoa;
                        f.nome = nome_pef.Text;
                        f.sexo = sexo_pef.Text;
                        f.nascimento = data_pef.Text;
                   
                        f.insert2(f);

                        SqlDataReader read = f.dadoslistados2(dataGridView_cadpefi);
                        while (read.Read())
                        {
                            dataGridView_cadpefi.Rows.Add(
                                read[0].ToString(),
                                read[1].ToString(),
                                read[2].ToString(),
                                read[3].ToString(),
                                read[4].ToString(),
                                read[5].ToString(),
                                read[6].ToString(),
                                read[7].ToString()
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show("cpf selecionados já constam no banco");
                    }
                }
                else {
                    MessageBox.Show("dados selecionados já constam no banco");
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

        private void Cadastro_Pessoa_Fisica_Load(object sender, EventArgs e)
        {

            data_pef.Mask = "0000/00/00";
            data_pef.MaxLength = 11;
            cpf_pef.Mask = "000.000.000-00";
            cpf_pef.MaxLength = 14;
            cep_pef.Mask = "00000-000";
            cep_pef.MaxLength = 9;
            celular_pef.Mask = "(00)0000-0000";
            celular_pef.MaxLength = 13;
            telefone_pef.Mask = "(00)0000-0000";
            telefone_pef.MaxLength = 13;
            complemento_pef.MaxLength = 12;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                Fisica f = new Fisica();
                f.Cpf = cpf_pef.Text;
                f.nome = nome_pef.Text;
                f.sexo = sexo_pef.Text;
                f.nascimento = data_pef.Text;
                f.telefone = telefone_pef.Text;
                f.celular = celular_pef.Text;
                f.mail = mail_pef.Text;
                f.estado = estado_pef.Text;
                f.cep = cep_pef.Text;
                f.municipio = municipio_pef.Text;
                f.complemento = complemento_pef.Text;
                f.numero = int.Parse(numero_pef.Text);
                f.Senha = senha_pef.Text;
                Pessoa codigo = f.lista_cod2(f);
                f.Codigo_pessoa = codigo.Codigo_pessoa;
                f.autualizar(f);
                button1.Enabled = true;

                SqlDataReader read = f.dadoslistados2(dataGridView_cadpefi);
                while (read.Read())
                {
                    dataGridView_cadpefi.Rows.Add(
                        read[0].ToString(),
                        read[1].ToString(),
                        read[2].ToString(),
                        read[3].ToString(),
                        read[4].ToString(),
                        read[5].ToString(),
                        read[6].ToString(),
                        read[7].ToString()
                    );
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            try
            {
                button1.Enabled = false;
                Fisica fisica = new Fisica();
                fisica.Cpf = cpf_pef.Text;
                if (fisica.verifica_duplicata2(fisica))
                {
                    if (!fisica.Cpf.Equals(""))
                    {
                        Fisica pessoa = fisica.lista_codigo_pessoa(fisica);
                        telefone_pef.Text = pessoa.telefone;
                        celular_pef.Text = pessoa.celular;
                        mail_pef.Text = pessoa.mail;
                        estado_pef.Text = pessoa.estado;
                        cep_pef.Text = pessoa.cep;
                        municipio_pef.Text = pessoa.municipio;
                        complemento_pef.Text = pessoa.complemento;
                        numero_pef.Text = pessoa.numero.ToString();
                        senha_pef.Text = pessoa.Senha;
                        nome_pef.Text = pessoa.nome;
                        sexo_pef.Text = pessoa.sexo;
                        data_pef.Text = pessoa.nascimento;
                        button2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo CPF");
                        button1.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("CPF não cosnta no banco");
                    button1.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try {
                Fisica fisica = new Fisica();
                fisica.Cpf = cpf_pef.Text;
                fisica.deletar(fisica);

                SqlDataReader read = fisica.dadoslistados2(dataGridView_cadpefi);
                while (read.Read())
                {
                    dataGridView_cadpefi.Rows.Add(
                        read[0].ToString(),
                        read[1].ToString(),
                        read[2].ToString(),
                        read[3].ToString(),
                        read[4].ToString(),
                        read[5].ToString(),
                        read[6].ToString(),
                        read[7].ToString()
                    );
                }
            }
            catch (Exception ex) { }
        }
    }
}
