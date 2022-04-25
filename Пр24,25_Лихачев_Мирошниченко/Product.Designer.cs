namespace Пр24_25_Лихачев_Мирошниченко
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idProductsLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label markLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.pK_shopDataSet = new Пр24_25_Лихачев_Мирошниченко.PK_shopDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Пр24_25_Лихачев_Мирошниченко.PK_shopDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Пр24_25_Лихачев_Мирошниченко.PK_shopDataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idProductsTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.buttonFoundProd = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.buttonDelProd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSaveProd = new System.Windows.Forms.Button();
            this.buttonTabularView = new System.Windows.Forms.Button();
            this.priceMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.markMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            idProductsLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            markLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pK_shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idProductsLabel
            // 
            idProductsLabel.AutoSize = true;
            idProductsLabel.Location = new System.Drawing.Point(28, 82);
            idProductsLabel.Name = "idProductsLabel";
            idProductsLabel.Size = new System.Drawing.Size(67, 13);
            idProductsLabel.TabIndex = 1;
            idProductsLabel.Text = "Код товара:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 108);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(86, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Наименование:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(59, 134);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Цена:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(26, 160);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(69, 13);
            countLabel.TabIndex = 7;
            countLabel.Text = "Количество:";
            // 
            // markLabel
            // 
            markLabel.AutoSize = true;
            markLabel.Location = new System.Drawing.Point(47, 186);
            markLabel.Name = "markLabel";
            markLabel.Size = new System.Drawing.Size(48, 13);
            markLabel.TabIndex = 9;
            markLabel.Text = "Оценка:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(35, 212);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Описание:";
            // 
            // pK_shopDataSet
            // 
            this.pK_shopDataSet.DataSetName = "PK_shopDataSet";
            this.pK_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.pK_shopDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Пр24_25_Лихачев_Мирошниченко.PK_shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // idProductsTextBox
            // 
            this.idProductsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "IdProducts", true));
            this.idProductsTextBox.Location = new System.Drawing.Point(101, 79);
            this.idProductsTextBox.Name = "idProductsTextBox";
            this.idProductsTextBox.Size = new System.Drawing.Size(276, 20);
            this.idProductsTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(101, 105);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(276, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(101, 157);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(276, 20);
            this.countTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(101, 209);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(276, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // buttonFoundProd
            // 
            this.buttonFoundProd.Location = new System.Drawing.Point(5, 263);
            this.buttonFoundProd.Name = "buttonFoundProd";
            this.buttonFoundProd.Size = new System.Drawing.Size(120, 25);
            this.buttonFoundProd.TabIndex = 13;
            this.buttonFoundProd.Text = "Найти по коду";
            this.buttonFoundProd.UseVisualStyleBackColor = true;
            this.buttonFoundProd.Click += new System.EventHandler(this.buttonFoundProd_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.Location = new System.Drawing.Point(131, 263);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(120, 25);
            this.buttonAddProd.TabIndex = 14;
            this.buttonAddProd.Text = "Добавить";
            this.buttonAddProd.UseVisualStyleBackColor = true;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // buttonDelProd
            // 
            this.buttonDelProd.Location = new System.Drawing.Point(257, 263);
            this.buttonDelProd.Name = "buttonDelProd";
            this.buttonDelProd.Size = new System.Drawing.Size(120, 25);
            this.buttonDelProd.TabIndex = 15;
            this.buttonDelProd.Text = "Удалить";
            this.buttonDelProd.UseVisualStyleBackColor = true;
            this.buttonDelProd.Click += new System.EventHandler(this.buttonDelProd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(5, 294);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(120, 25);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSaveProd
            // 
            this.buttonSaveProd.Location = new System.Drawing.Point(131, 294);
            this.buttonSaveProd.Name = "buttonSaveProd";
            this.buttonSaveProd.Size = new System.Drawing.Size(246, 25);
            this.buttonSaveProd.TabIndex = 17;
            this.buttonSaveProd.Text = "Сохранить запись";
            this.buttonSaveProd.UseVisualStyleBackColor = true;
            this.buttonSaveProd.Click += new System.EventHandler(this.buttonSaveProd_Click);
            // 
            // buttonTabularView
            // 
            this.buttonTabularView.Location = new System.Drawing.Point(65, 325);
            this.buttonTabularView.Name = "buttonTabularView";
            this.buttonTabularView.Size = new System.Drawing.Size(246, 25);
            this.buttonTabularView.TabIndex = 18;
            this.buttonTabularView.Text = "Табличный вид";
            this.buttonTabularView.UseVisualStyleBackColor = true;
            this.buttonTabularView.Click += new System.EventHandler(this.buttonTabularView_Click);
            // 
            // priceMaskedTextBox
            // 
            this.priceMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Price", true));
            this.priceMaskedTextBox.Location = new System.Drawing.Point(101, 131);
            this.priceMaskedTextBox.Mask = "00000.00";
            this.priceMaskedTextBox.Name = "priceMaskedTextBox";
            this.priceMaskedTextBox.Size = new System.Drawing.Size(276, 20);
            this.priceMaskedTextBox.TabIndex = 19;
            // 
            // markMaskedTextBox
            // 
            this.markMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Mark", true));
            this.markMaskedTextBox.Location = new System.Drawing.Point(101, 183);
            this.markMaskedTextBox.Mask = "0.0";
            this.markMaskedTextBox.Name = "markMaskedTextBox";
            this.markMaskedTextBox.Size = new System.Drawing.Size(276, 20);
            this.markMaskedTextBox.TabIndex = 20;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.markMaskedTextBox);
            this.Controls.Add(this.priceMaskedTextBox);
            this.Controls.Add(this.buttonTabularView);
            this.Controls.Add(this.buttonSaveProd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelProd);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.buttonFoundProd);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(markLabel);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(idProductsLabel);
            this.Controls.Add(this.idProductsTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "Product";
            this.Text = "Данные товара";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pK_shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PK_shopDataSet pK_shopDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private PK_shopDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private PK_shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idProductsTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button buttonFoundProd;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.Button buttonDelProd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSaveProd;
        private System.Windows.Forms.Button buttonTabularView;
        private System.Windows.Forms.MaskedTextBox priceMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox markMaskedTextBox;
    }
}