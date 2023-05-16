using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace RoboLess3000
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;

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
                _serialPort.Write(buffer, offset, count);
                //Console.WriteLine(message);
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

        public Form1()
        {
            InitializeComponent();
        }
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //get_com_ports();

            //SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
            //recognizer.SetInputToDefaultAudioDevice();
            //Grammar grammar = new DictationGrammar();
            //recognizer.LoadGrammar(grammar);
            //recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
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
            char[] chars = { 'o', 'l', 'a' };
            serial_write(chars, 0, 3);
        }
    }
}
