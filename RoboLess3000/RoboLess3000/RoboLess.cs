using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;

namespace RoboLess3000
{
    public partial class RoboLess : Form
    {
        static SerialPort _serialPort;


        // SERVER
        public int Port = 8080;

        private HttpListener _listener;
        public static string pageData =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>HttpListener Example</title>" +
            "  </head>" +
            "  <body>" +
            "    <p>Page Views: {0}</p>" +
            "    <p>OMDS: {1}</p>" +
            "    <form method=\"post\" action=\"shutdown\">" +
            "      <input type=\"submit\" value=\"Shutdown\" {1}>" +
            "    </form>" +
            "  </body>" +
            "</html>";

        //{0} sao args

        public void Stop()
        {
            _listener.Stop();
        }

        
        private async void start_listening()
        {
            bool runServer = true;
            while (runServer)
            {
                HttpListenerContext ctx = await _listener.GetContextAsync();

                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;


                // do something with the request
                Console.WriteLine($"{req.Url}");
                if(req.Url.ToString().Contains("favicon.ico"))
                {
                    continue;
                }

                byte[] data = File.ReadAllBytes("C:\\Users\\Gonçalo Marques\\Desktop\\small_site\\index.html");
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF32;
                resp.ContentLength64 = data.LongLength;
                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }

        private void start_server()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://*:" + Port.ToString() + "/");
            _listener.Start();
            start_listening();
        }
        //FIM SERVER


        //ARDUINO
        private void get_com_ports()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
        }

        private static void serial_write(char[] buffer, int offset, int count)
        {
            try
            {
                _serialPort.Open();
                _serialPort.Write(buffer, offset, count);
                Console.WriteLine(buffer);
                _serialPort.Close();
            }
            catch (TimeoutException) 
            {
                Console.WriteLine("Error writing message");
            }
        }

        private void connect_to_arduino(string port_name)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = port_name;
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = System.IO.Ports.Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = System.IO.Ports.StopBits.One;
            _serialPort.Handshake = System.IO.Ports.Handshake.None;
        }

        private void check_text_box()
        {
            while(true)
            {
                string data = text_to_send.Text;
                char[] chars = data .ToCharArray();
                serial_write(chars, 0, chars.Length);

                if (InvokeRequired)
                {
                    this.Invoke(new Action(() => text_to_send.Clear()));
                }
                
                Thread.Sleep(7000);
            }
        }

        public RoboLess()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_server();
            //get_com_ports();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//conectBTN
        {
            connect_to_arduino(comboBox1.Text);
            Console.WriteLine("Connecting " + comboBox1.Text);
        }

        private void write_test_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(check_text_box);
            t.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string data = text_to_send.Text;
            char[] chars = data.ToCharArray(); 
            serial_write(chars, 0, chars.Length);
            text_to_send.Clear();

            //for(int i = 0; i < 20; i++)
            //{
            //    string data = "sim";
            //    char[] chars = data.ToCharArray();
            //    serial_write(chars, 0, chars.Length);

            //    Thread.Sleep(3000);

            //    string data2 = "rei";
            //    char[] chars2 = data2.ToCharArray();
            //    serial_write(chars2, 0, chars2.Length);
            //    Thread.Sleep(3000);
            //}
            
        }
    }
}
