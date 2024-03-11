using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente_s4
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);

            server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);
                this.BackColor = Color.Green;

                string nombre = textBox1.Text;
                float grados = Convert.ToInt32(textBox2.Text);

                if (Palindromo.Checked)
                {
                    string mensaje = "1/" + nombre;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(mensaje);

                    byte[] msg2 = new byte[80],
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    if (msg2 = 'SI')
                        MessageBox.Show("El nombre es un palindromo");
                    else
                        MessageBox.Show("El nombre NO es un palindromo");
                }
                else if (Mayusculas.Checked)
                {
                    string mensaje = "2/" + nombre;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(mensaje);

                    byte[] msg2 = new byte[80],
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show(msg2);
                }
                else if (Grados.Checked)
                {
                    string mensaje = "3/" + grados;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(mensaje);

                    byte[] msg2 = new byte[80],
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show(msg2);
                }
            }
            this.BackColor= Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
