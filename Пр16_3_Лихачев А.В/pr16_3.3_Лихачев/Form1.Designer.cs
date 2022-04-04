namespace pr16_3._3_Лихачев
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.незамкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однаКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Упругость сплайна";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.незамкнутаяЛоманаяToolStripMenuItem,
            this.замкнутаяЛоманаяToolStripMenuItem,
            this.незамкнутыйСплайнToolStripMenuItem,
            this.замкнутToolStripMenuItem,
            this.однаКриваяБезьеToolStripMenuItem,
            this.незамкнутаяКриваяБезьеToolStripMenuItem,
            this.замкнутаяКриваяБезьеToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripSplitButton1.Text = "Выбор кривой";
            // 
            // незамкнутаяЛоманаяToolStripMenuItem
            // 
            this.незамкнутаяЛоманаяToolStripMenuItem.Name = "незамкнутаяЛоманаяToolStripMenuItem";
            this.незамкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутаяЛоманаяToolStripMenuItem.Text = "Незамкнутая ломаная";
            this.незамкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.незамкнутаяЛоманаяToolStripMenuItem_Click);
            // 
            // замкнутаяЛоманаяToolStripMenuItem
            // 
            this.замкнутаяЛоманаяToolStripMenuItem.Name = "замкнутаяЛоманаяToolStripMenuItem";
            this.замкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутаяЛоманаяToolStripMenuItem.Text = "Замкнутая ломаная";
            this.замкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.замкнутаяЛоманаяToolStripMenuItem_Click);
            // 
            // незамкнутыйСплайнToolStripMenuItem
            // 
            this.незамкнутыйСплайнToolStripMenuItem.Name = "незамкнутыйСплайнToolStripMenuItem";
            this.незамкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутыйСплайнToolStripMenuItem.Text = "Незамкнутый сплайн";
            this.незамкнутыйСплайнToolStripMenuItem.Click += new System.EventHandler(this.незамкнутыйСплайнToolStripMenuItem_Click);
            // 
            // замкнутToolStripMenuItem
            // 
            this.замкнутToolStripMenuItem.Name = "замкнутToolStripMenuItem";
            this.замкнутToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутToolStripMenuItem.Text = "Замкнутый сплайн";
            this.замкнутToolStripMenuItem.Click += new System.EventHandler(this.замкнутToolStripMenuItem_Click);
            // 
            // однаКриваяБезьеToolStripMenuItem
            // 
            this.однаКриваяБезьеToolStripMenuItem.Name = "однаКриваяБезьеToolStripMenuItem";
            this.однаКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.однаКриваяБезьеToolStripMenuItem.Text = "Одна кривая Безье";
            this.однаКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.однаКриваяБезьеToolStripMenuItem_Click);
            // 
            // незамкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Name = "незамкнутаяКриваяБезьеToolStripMenuItem";
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Text = "Незамкнутая кривая Безье";
            this.незамкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.незамкнутаяКриваяБезьеToolStripMenuItem_Click);
            // 
            // замкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.замкнутаяКриваяБезьеToolStripMenuItem.Name = "замкнутаяКриваяБезьеToolStripMenuItem";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутаяКриваяБезьеToolStripMenuItem.Text = "Замкнутая кривая Безье";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.замкнутаяКриваяБезьеToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "Очистка экрана";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Task 3";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem незамкнутаяЛоманаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутаяЛоманаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутыйСплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однаКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутаяКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутаяКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

