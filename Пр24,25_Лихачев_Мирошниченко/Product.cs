using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Пр24_25_Лихачев_Мирошниченко
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pK_shopDataSet);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pK_shopDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.pK_shopDataSet.Products);

        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void buttonDelProd_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }

        private void buttonSaveProd_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pK_shopDataSet);
        }

        private void buttonFoundProd_Click(object sender, EventArgs e)
        {
            string sql = String.Concat("SELECT * FROM Products WHERE IdProducts=", idProductsTextBox.Text);

            string connectionString;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDb;AttachDbFilename=|DataDirectory|\PK_shop.mdf;Integrated Sequrity=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();

            nameTextBox.Text = "";
            priceMaskedTextBox.Text = "";
            countTextBox.Text = "";
            markMaskedTextBox.Text = "";
            descriptionTextBox.Text = "";

            while (dataReader.Read())
            {
                nameTextBox.Text += dataReader[""];
                priceMaskedTextBox.Text += dataReader[""];
                countTextBox.Text += dataReader[""];
                markMaskedTextBox.Text += dataReader[""];
                descriptionTextBox.Text += dataReader[""];
            }

            dataReader.Close();
            connection.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            priceMaskedTextBox.Text = "";
            countTextBox.Text = "";
            markMaskedTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private Products TablProducts;

        private void buttonTabularView_Click(object sender, EventArgs e)
        {
            TablProducts = new Products();
            TablProducts.Visible = true;
        }
    }
}
