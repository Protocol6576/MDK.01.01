using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПР26_Лихачев
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStud af = new AddStud();
            af.Owner = this;
            af.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsForm af = new studentsForm();
            af.Owner = this;
            af.Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsForm af = new studentsForm();
            af.Owner = this;
            af.Show();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudRating af = new StudRating();
            af.Owner = this;
            af.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox af = new AboutBox();
            af.Owner = this;
            af.Show();
        }

        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reference af = new Reference();
            af.Owner = this;
            af.Show();
        }
    }
}
