using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using Web_Cliente.servidor;

namespace Web_Cliente.Layout
{
    public partial class Lancamento_cotacao : Form
    {
        TcpClient tcpclient;
        NetworkStream networkstream;
        Thread thInteraction;
        String email;
        int idUsuario;
        public Lancamento_cotacao(Form1 frm1)
        {
            try
            {
                InitializeComponent();
                this.email = frm1.login;
                Web_Cliente.webservice3.WebServiceRespostas wsr = new Web_Cliente.webservice3.WebServiceRespostas();
                this.idUsuario = wsr.idPessoaFisica(this.email);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }

        private void connect()
        {
            try
            {
                tcpclient = new TcpClient();
                setMsg("establecido a conexão....");
                tcpclient.Connect("127.0.0.1", 8000);
            }
            catch (Exception ex) {
                MessageBox.Show("Servidor não conectado");
                this.Dispose();
            }
        }

        private void desconnect()
        {
            if (thInteraction != null)
            {
                if (thInteraction.ThreadState == ThreadState.Running)
                {
                    thInteraction.Abort();
                }

                tcpclient.Close();
            }
        }

        private void enviarMsg(String mensagem)
        {
            if (networkstream.CanWrite)
            {
                byte[] sendbytes = Encoding.UTF8.GetBytes(mensagem);
                networkstream.Write(sendbytes, 0, sendbytes.Length);
            }
        }

        delegate void delsetMsg(String mensagem);
        private void setMsg(String mensagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delsetMsg(setMsg), mensagem);
            }
            else
            {
                rtbconversa.Text = "servidor: "; //+ mensagem + "\n";
            }
        }


        delegate void delgetMsg(String mensagem);
        private void getMsg(String mensagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delgetMsg(getMsg), mensagem);
            }
            else
            {
                String[] array = mensagem.Split('-');
                //MessageBox.Show(array.Length+"");
                //rtbconversa.Text = "Servidor: " + mensagem + "\n";
                String[] filtro1;
                Produto produtos = new Produto();
                lProdutoServidor.ColumnCount = 4;
                for (int i = 1; i < array.Length; i++ )
                {
                    filtro1 = array[i].Split('/');
                    produtos.Codigo_produto_ = int.Parse(filtro1[0]);
                    produtos.nome_produto = filtro1[1];
                    produtos.peso = float.Parse(filtro1[2]);
                    produtos.preco = float.Parse(filtro1[3]);
                    lProdutoServidor.Rows.Add(
                        produtos.Codigo_produto_,
                        produtos.nome_produto,
                        produtos.peso,
                        produtos.preco
                    );
                }
            }
        }

        /// <summary>
        /// em memoria
        /// 
        /// </summary>
        private void interaction()
        {
            try
            {
                do
                {
                    networkstream = tcpclient.GetStream();
                    if (networkstream.CanRead)
                    {
                        byte[] bytes = new byte[tcpclient.ReceiveBufferSize];
                        networkstream.Read(bytes, 0, Convert.ToInt32(tcpclient.ReceiveBufferSize));
                        String returnData = Encoding.UTF8.GetString(bytes);
                        getMsg(returnData);
                    }
                    else
                    {
                        setMsg("não é possivel ler os dados");
                        desconnect();
                    }
                } while (tcpclient.Connected);
            }
            catch (Exception ex) { }
        }

        private void Lancamento_cotacao_Load(object sender, EventArgs e)
        {
            connect();
            thInteraction = new Thread(new ThreadStart(interaction));
            thInteraction.IsBackground = true;
            thInteraction.Priority = ThreadPriority.Highest;
            thInteraction.Name = "interaction";
            thInteraction.Start();
        }

        private void Lancamento_cotacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            desconnect();
        }

        List<Produto> Produtos = new List<Produto>();
        private void lProdutoServidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Produto produto = new Produto();
            produto.Codigo_produto_ = int.Parse(lProdutoServidor.CurrentRow.Cells[0].Value.ToString());
            produto.nome_produto = lProdutoServidor.CurrentRow.Cells[1].Value.ToString();
            produto.preco = float.Parse( lProdutoServidor.CurrentRow.Cells[3].Value.ToString());
            gridCompra.Rows.Clear();
            gridCompra.ColumnCount = 2;
            gridCompra.Rows.Add(
                produto.Codigo_produto_,
                produto.nome_produto
            );
            this.Produtos.Add(produto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Frigorifico.Classes.Item_Pedido ip = new Frigorifico.Classes.Item_Pedido();
                if (quantidade.Text != "")
                {
                    ip.qantidade = int.Parse(quantidade.Text);
                }
                else
                {
                    ip.qantidade = 1;
                }
                ip.Codigo_pessoa = idUsuario;
                foreach (Produto produto in Produtos)
                {
                    enviarMsg("Cliente escolheu " + produto.nome_produto + " de Codigo " + produto.Codigo_produto_ + " \n");
                    ip.insertCompra(produto, ip);//possivel erroe
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
