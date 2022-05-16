using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;

            Excel.Workbook wBook;
            Excel.Worksheet xlSheet;
            wBook = xlApp.Workbooks.Add();
            xlApp.Columns.ColumnWidth = 15;
            xlSheet = (Excel.Worksheet)wBook.Sheets[1];
            xlSheet.Name = "Оценки";


            xlApp.Cells[1, 1] = "Номер сутд. билета";
            xlApp.Cells[1, 2] = "Группа";
            xlApp.Cells[1, 3] = "Фамилия";
            xlApp.Cells[1, 4] = "Имя";
            xlApp.Cells[1, 5] = "Отчество";
            xlApp.Cells[1, 6] = "Пол";
            xlApp.Cells[1, 7] = "Дата рождения";
            xlApp.Cells[1, 8] = "Место рождения";
            for (int i = 0; i < dataGridViewDekan.Rows.Count - 1; i++)
            {
                for(int j = 0; j < dataGridViewDekan.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dataGridViewDekan.Rows[i].Cells[j].Value.ToString();

                    xlSheet.Cells.HorizontalAlignment = 3;
                    xlApp.Visible = true;
                }
            }
        }
    }
}
