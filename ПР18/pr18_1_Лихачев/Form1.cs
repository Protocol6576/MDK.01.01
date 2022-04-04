using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr18_1_Лихачев
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        int itemCount = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in panel1.Controls)
            {
                pictureBox.BackColor = Color.Transparent;
                label1.Text = "Вам необходимо найти предметы: " + itemCount.ToString() + " яблок!";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void nextLvl()
        {
            var messageNLvL = MessageBox.Show("Вы нашли все предметы", "Поздравляем! Следующий уровень...", MessageBoxButtons.OK);
            if (messageNLvL == DialogResult.OK)
            {
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
            }
            itemCount = 7;
            label1.Text = "Вам необходимо найти предметы: " + itemCount.ToString() + " фляг эстуса!";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            itemCount--;
            if (itemCount <= 0)
                nextLvl();
            else
                label1.Text = "Вам осталорсь найти " + itemCount.ToString() + " предмета";
        }
    }
}
