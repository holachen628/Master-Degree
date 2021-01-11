using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pressure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string A = " ";
        int start = 0;

        private void bt_connect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = tb_COM.Text;
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            A = serialPort1.ReadLine();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //richTextBox1.Text = richTextBox1.Text + A;
            richTextBox1.AppendText(A);
            richTextBox1.ScrollToCaret();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "DefaultOutputName.txt";
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                {
                    for (int i = 0; i < richTextBox1.Lines.Length; i++)
                    {
                        sw.WriteLine(richTextBox1.Lines[i]);
                    }
                }
            }
        }

        private void bt_timer_Click(object sender, EventArgs e)
        {
            timer2.Interval = int.Parse(tb_timer.Text) * 1000;
            timer2.Enabled = true;
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
