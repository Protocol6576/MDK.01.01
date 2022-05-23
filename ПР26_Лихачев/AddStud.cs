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
    public partial class AddStud : Form
    {
        public AddStud()
        {
            InitializeComponent();
        }

        private void AddStud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.dekanatDataSet.студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dekanatDataSet.ГруппыСтудентов". При необходимости она может быть перемещена или удалена.
            this.группыСтудентовTableAdapter.Fill(this.dekanatDataSet.ГруппыСтудентов);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            studentsForm main = this.Owner as studentsForm;
            if(main != null)
            {
                DataRow nRow = main.dekanatDataSet1.Tables[2].NewRow();
                int rc = main.dataGridViewDekan.RowCount + 1;
                nRow[0] = textBoxIdStud.Text;
                nRow[1] = comboBoxGroup.SelectedValue.ToString();
                nRow[2] = textBoxSurName.Text;
                nRow[3] = textBoxName.Text;
                nRow[4] = textBoxPatr.Text;
                nRow[5] = comboBoxGend.Text;
                nRow[6] = dateTimePickerBD.Text;
                nRow[7] = textBoxTown.Text;

                main.dekanatDataSet1.Tables[2].Rows.Add(nRow);
                main.студентыTableAdapter.Update(main.dekanatDataSet1.студенты);
                main.dekanatDataSet1.Tables[2].AcceptChanges();
                main.dataGridViewDekan.Refresh();
            }
        }
    }
}
