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
            tcpclient = new TcpClient();
            setMsg("establecido a conexão....");
            tcpclient.Connect("127.0.0.1", 8000);
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
                String[] array = mensagem.Split('/');
                rtbconversa.Text = "Servidor: " + mensagem + "\n";
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
