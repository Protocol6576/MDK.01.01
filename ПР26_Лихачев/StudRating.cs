using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ПР26_Лихачев
{
    public partial class StudRating : Form
    {
        public string CmdText = 
          "SELECT " +
            "[ГруппыСтудентов].[Название]," +
            "[студенты].[Фамилия]" +
            ",[студенты].[Имя]," +
            "[Дисциплины].[Название]," +
            "[Успеваемость].[Оценка]," +
            "[Успеваемость].[Вид контроля] " +
          "FROM " +
            "[студенты]," +
            "[ГруппыСтудентов]," +
            "[Дисциплины]," +
            "[Успеваемость] " +
          "WHERE " +
            "([Успеваемость].[кодСтудента] = [студенты].[КодСтудента]) AND " +
            "([студенты].[кодГруппы] = [ГруппыСтудентов].[КодГруппы]) AND " +
            "([Успеваемость].[КодДисциплины] = [Дисциплины].[КодДисциплины])";
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\dekanat.mdb";
        public OleDbConnection myConnection;

        public StudRating()
        {
            InitializeComponent();
        }

        private void StudRating_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(ConnString);
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(CmdText, myConnection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}
