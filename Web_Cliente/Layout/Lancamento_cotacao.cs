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

        public Lancamento_cotacao()
        {
            InitializeComponent();
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
                byte[] sendbytes = Encoding.ASCII.GetBytes(mensagem);
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
                rtbconversa.Text = "servidor: " + mensagem + "\n";
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
                rtbconversa.Text = "Servidor: " + mensagem + "\n";
                String[] filtro1;
                Produto produtos = new Produto();
                lProdutoServidor.ColumnCount = 4;
                for (int i = 1; i < array.Length; i++ )
                {
                    filtro1 = array[i].Split('/');
                    produtos.Codigo_produto_ = int.Parse(filtro1[0]);
                    produtos.nome_produto = filtro1[1];
                    produtos.preco = float.Parse(filtro1[2]);
                    lProdutoServidor.Rows.Add(
                        produtos.Codigo_produto_,
                        produtos.nome_produto,
                        produtos.preco
                    );
                }
            }
        }

        private void rtbmensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (networkstream.CanWrite)
                {
                    String mensagem = rtbmensagem.Text;
                    enviarMsg(mensagem);
                    setMsg("eu: " + mensagem);
                }
                else
                {
                    setMsg("não é possivel enviar mensagem");
                    desconnect();
                }
            }
        }

        private void rtbmensagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //rtbmensagem.Clear();
            }
        }

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
                        String returnData = Encoding.ASCII.GetString(bytes);
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

    }
}
