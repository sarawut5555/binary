using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ConvertDecToBin(int inputDec)
        {
            if (inputDec == 0)
            {
                return "0"; // ถ้าค่าเป็น 0 ให้คืน "0"
            }

            int temp = inputDec;
            string binary = "";
            while (temp > 0)
            {
                if (temp >= 2)
                {
                    binary = (temp % 2) + binary;
                }
                else
                {
                    binary = temp + binary;
                }
                temp = temp / 2;
            }
            return binary;
        }

        public string ConvertDecToOct(int inputDec)
        {
            if (inputDec == 0)
            {
                return "0"; // ถ้าค่าเป็น 0 ให้คืน "0"
            }

            int temp = inputDec;
            string octal = "";
            while (temp > 0)
            {
                octal = (temp % 8) +octal;
                temp = temp / 8;
            }
            return octal;
        }

        public string ConvertDecToHex(int inputDec)
        {
            return inputDec.ToString("X");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                textBox2.Text = ConvertDecToBin(value);
                textBox3.Text = ConvertDecToOct(value);
                textBox4.Text = ConvertDecToHex(value);
            }
            else
            {
                MessageBox.Show("โปรดป้อนเลขฐานสิบที่ถูกต้องใน TextBox 1");
            }
        }
    }
}
