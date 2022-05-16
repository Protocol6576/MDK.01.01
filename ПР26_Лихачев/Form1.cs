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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet1.студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.dekanatDataSet1.студенты);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.студентыTableAdapter.Update(this.dekanatDataSet1);
        }

        private void dataGridViewDekan_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStud af = new AddStud();
            af.Owner = this;
            af.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm af = new SearchForm();
            af.Owner = this;
            af.Show();
        }

        private void buttonShowRating_Click(object sender, EventArgs e)
        {
            StudRating af = new StudRating();
            af.Owner = this;
            af.Show();
        }
    }
}
