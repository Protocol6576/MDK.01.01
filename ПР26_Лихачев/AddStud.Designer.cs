namespace ПР26_Лихачев
{
    partial class AddStud
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdStud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxGend = new System.Windows.Forms.ComboBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatr = new System.Windows.Forms.TextBox();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.dekanatDataSet = new ПР26_Лихачев.dekanatDataSet();
            this.группыСтудентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыСтудентовTableAdapter = new ПР26_Лихачев.dekanatDataSetTableAdapters.ГруппыСтудентовTableAdapter();
            this.студентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new ПР26_Лихачев.dekanatDataSetTableAdapters.студентыTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыСтудентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер студ. билета";
            // 
            // textBoxIdStud
            // 
            this.textBoxIdStud.Location = new System.Drawing.Point(157, 12);
            this.textBoxIdStud.Name = "textBoxIdStud";
            this.textBoxIdStud.Size = new System.Drawing.Size(109, 20);
            this.textBoxIdStud.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(26, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(26, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Отчество";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Пол";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(26, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Место рождения";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.студентыBindingSource, "кодГруппы", true));
            this.comboBoxGroup.DataSource = this.группыСтудентовBindingSource;
            this.comboBoxGroup.DisplayMember = "название";
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(157, 38);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(109, 21);
            this.comboBoxGroup.TabIndex = 9;
            this.comboBoxGroup.ValueMember = "кодГруппы";
            // 
            // comboBoxGend
            // 
            this.comboBoxGend.FormattingEnabled = true;
            this.comboBoxGend.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.comboBoxGend.Location = new System.Drawing.Point(157, 143);
            this.comboBoxGend.Name = "comboBoxGend";
            this.comboBoxGend.Size = new System.Drawing.Size(109, 21);
            this.comboBoxGend.TabIndex = 10;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(157, 65);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(109, 20);
            this.textBoxSurName.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(157, 91);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(109, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxPatr
            // 
            this.textBoxPatr.Location = new System.Drawing.Point(157, 117);
            this.textBoxPatr.Name = "textBoxPatr";
            this.textBoxPatr.Size = new System.Drawing.Size(109, 20);
            this.textBoxPatr.TabIndex = 13;
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Location = new System.Drawing.Point(157, 170);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerBD.TabIndex = 14;
            // 
            // textBoxTown
            // 
            this.textBoxTown.Location = new System.Drawing.Point(157, 196);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(109, 20);
            this.textBoxTown.TabIndex = 15;
            // 
            // dekanatDataSet
            // 
            this.dekanatDataSet.DataSetName = "dekanatDataSet";
            this.dekanatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыСтудентовBindingSource
            // 
            this.группыСтудентовBindingSource.DataMember = "ГруппыСтудентов";
            this.группыСтудентовBindingSource.DataSource = this.dekanatDataSet;
            // 
            // группыСтудентовTableAdapter
            // 
            this.группыСтудентовTableAdapter.ClearBeforeFill = true;
            // 
            // студентыBindingSource
            // 
            this.студентыBindingSource.DataMember = "студенты";
            this.студентыBindingSource.DataSource = this.dekanatDataSet;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(29, 305);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(157, 305);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AddStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTown);
            this.Controls.Add(this.dateTimePickerBD);
            this.Controls.Add(this.textBoxPatr);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.comboBoxGend);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdStud);
            this.Controls.Add(this.label1);
            this.Name = "AddStud";
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.AddStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыСтудентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdStud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxGend;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatr;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.TextBox textBoxTown;
        private dekanatDataSet dekanatDataSet;
        private System.Windows.Forms.BindingSource группыСтудентовBindingSource;
        private dekanatDataSetTableAdapters.ГруппыСтудентовTableAdapter группыСтудентовTableAdapter;
        private System.Windows.Forms.BindingSource студентыBindingSource;
        private dekanatDataSetTableAdapters.студентыTableAdapter студентыTableAdapter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
    }
}