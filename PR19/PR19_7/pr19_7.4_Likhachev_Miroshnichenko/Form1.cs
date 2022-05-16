using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr19_7._4_Likhachev_Miroshnichenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len, count;
            CalcSpace(str, out len, out count);
            label3.Text = (index + 1).ToString();
            label5.Text = len.ToString();
            label7.Text = count.ToString();
            int simv = CalcSymbol(str, len);
            label10.Text = simv.ToString();
        }

        private int CalcSymbol(string str, int len)
        {
            char input = Convert.ToChar(textBox1.Text);
            int simv = 0;
            for (int j = 0; j < len; j++)
                if (input == str[j])
                    simv++;
            return simv;
        }

        private static void CalcSpace(string str, out int len, out int count)
        {
            len = str.Length;
            count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
        }
    }
}
