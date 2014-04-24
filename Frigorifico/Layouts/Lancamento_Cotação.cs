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
using System.Net;

namespace Frigorifico.Layouts
{
    public partial class Lancamento_Cotação : Form
    {
        int numeroporta = 8000;
        TcpListener tcplistener;
        TcpClient tcpclient;
        NetworkStream networkstream;
        Thread thinteraction;

        public Lancamento_Cotação()
        {
            InitializeComponent();
        }

        public bool connection()
        {
            bool retorno = false;
            try
            {
                tcplistener = new TcpListener(IPAddress.Any, numeroporta);
                tcplistener.Start();
                return true;
            }
            catch (Exception ex) { }
            return retorno;
        }

        public void desconect()
        {
            if (thinteraction != null)
            {
                if (thinteraction.ThreadState == ThreadState.Running)
                {
                    thinteraction.Abort();
                }
            }

            if (tcpclient != null)
            {
                tcpclient.Client.Disconnect(true);
            }
            tcplistener.Stop();
            setMsg("conexão perdida...", true);

        }

        public void acceptconnection()
        {
            try
            {
                tcpclient = tcplistener.AcceptTcpClient();

            }
            catch (Exception ex)
            {

            }
        }

        private void enviarmsg(String mensagem)
        {
            if (podeescrever())
            {

                byte[] sendbyte = Encoding.ASCII.GetBytes(mensagem);
                networkstream.Write(sendbyte, 0, sendbyte.Length);
            }

        }
        public bool podeescrever()
        {
            if (networkstream == null)
            {
                return false;
            }

            if (networkstream.CanRead && tcpclient != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        delegate void delSetMsg(String text, bool bular);

        private void setMsg(String text, bool bular)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delSetMsg(setMsg), text, bular);
                //http://www.youtube.com/watch?v=opQHn2t-0dA
            }
            else
            {
                if (bular == true || podeescrever() == true)
                {
                    ///mudar
                    rtbConversa.Text += "eu " + text + "\n";
                }
            }
        }


        delegate void delGetMsg(String text);
        private void getMsg(String text)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delGetMsg(getMsg), text);
                //http://www.youtube.com/watch?v=opQHn2t-0dA
            }
            else
            {
                if (podeescrever() == true)
                {
                    rtbConversa.Text += "cliente " + text + "\n";
                }
            }
        }

        private void start()
        {
            if (connection())
            {
                setMsg("aquardand uma conexão...", true);
                thinteraction = new Thread(new ThreadStart(interation));
                thinteraction.IsBackground = true;
                thinteraction.Priority = ThreadPriority.Highest;
                thinteraction.Name = "thinteraction";
                thinteraction.Start();
            }
        }


        private void interation()
        {
            try
            {
                acceptconnection();
                setMsg("conexão aceita...", true);
                do
                {
                    networkstream = tcpclient.GetStream();
                    if (networkstream.CanRead)
                    {
                        byte[] bytes = new byte[tcpclient.ReceiveBufferSize];
                        networkstream.Read(bytes, 0, Convert.ToInt32(tcpclient.ReceiveBufferSize));

                        String clientedata = Encoding.ASCII.GetString(bytes);
                        if (clientedata.Replace("\0", "").Trim() != "")
                        {
                            getMsg(clientedata);
                        }
                        else
                        {
                            tcpclient = null;
                        }
                    }
                } while (tcpclient != null);

                desconect();
                start();
            }
            catch (Exception ex)
            {
            }
        }

        private void Lancamento_Cotação_Load(object sender, EventArgs e)
        {
            start();
        }

        private void Lancamento_Cotação_FormClosing(object sender, FormClosingEventArgs e)
        {
            setMsg("inserando conexão com o servidor...", true);
            desconect();
        }

        private void rbtConversa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string mesagem = rtbConversa.Text;
                enviarmsg(mesagem);
                setMsg(mesagem, false);
            }
        }

        private void rbtConversa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbConversa.Clear();
            }
        }


    }
}
