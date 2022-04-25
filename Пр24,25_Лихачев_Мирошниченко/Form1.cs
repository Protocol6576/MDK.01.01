using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр24_25_Лихачев_Мирошниченко
{
    public partial class Titul : Form
    {
        public Titul()
        {
            InitializeComponent();
        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }
    }
}
