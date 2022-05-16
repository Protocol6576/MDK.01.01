using System;
using System.Windows.Forms;

namespace pr19_7._1_Likhachev_Miroshnichenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.ConnectionString;
            connectionString = IfThisThing(connectionString);
            MessageBox.Show(connectionString);
        }

        private static string IfThisThing(string connectionString)
        {
            if (connectionString == null)
            {
                connectionString = "Строка соединения по умолчанию";
            }

            return connectionString;
        }
    }
}
