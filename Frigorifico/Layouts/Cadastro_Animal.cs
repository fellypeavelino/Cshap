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
    public partial class Cadastro_Animal : Form
    {
        public Cadastro_Animal()
        {
            InitializeComponent();
            try {
                Animal animal = new Animal();
                SqlDataReader read = animal.nome_fantasia_fornecedor();
                while(read.Read()){
                    fornecedores_caan.Items.Add(read[0].ToString());
                }
                fornecedores_caan.SelectedIndex = 0;

                List<Tipo> tipo = animal.tipo.lista_nome_tipo();
                foreach(Tipo nome in tipo){
                    tipo_caan.Items.Add(nome.nome);
                }

                List<Animal> animais = animal.lista_animal();
                dataGridView_ani.Rows.Clear();
                dataGridView_ani.ColumnCount = 5;
                foreach(Animal array in animais){
                    dataGridView_ani.Rows.Add(
                        array.tipo.nome,
                        array.peso,
                        array.preco,
                        array.quantdade,
                        array.fornecedor.j.nome_fantasia
                    );
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void butcadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal();

                int id_fornecedor = animal.id_fornecedor(fornecedores_caan);
                animal.fornecedor.Codigo_fornecdor = id_fornecedor;

                animal.tipo.nome = tipo_caan.Text;
                if (!animal.tipo.verifica_duplicata(animal))
                {
                    animal.tipo.insert(animal);
                    tipo_caan.Items.Clear();
                    List<Tipo> tipo = animal.tipo.lista_nome_tipo();
                    foreach (Tipo nome in tipo)
                    {
                        tipo_caan.Items.Add(nome.nome);
                    }
                }

                int id_tipo = animal.tipo.id_tipo(animal);
                animal.tipo.codigo_tipo = id_tipo;
                //MessageBox.Show(id_tipo.ToString());
                animal.quantdade = int.Parse(quantidade_ani.Text);
                animal.preco = double.Parse(preco_ani.Text);
                animal.peso = float.Parse(peso_ani.Text);
                animal.recebimento = recebimento_ani.Text;
                animal.insert(animal);

                List<Animal> animais = animal.lista_animal();
                dataGridView_ani.Rows.Clear();
                dataGridView_ani.ColumnCount = 5;
                foreach (Animal array in animais)
                {
                    dataGridView_ani.Rows.Add(
                        array.tipo.nome,
                        array.peso,
                        array.preco,
                        array.quantdade,
                        array.fornecedor.j.nome_fantasia
                    );
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
