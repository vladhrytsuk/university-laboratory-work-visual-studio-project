namespace Admin_Restoran
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникЗалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списковСтоловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оперативныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗанятыхСтоловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётныеДокументыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоПредварительнымЗаказамМестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоИспользованиюЗаловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОДеятельностиРесторанаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочныеДокументыToolStripMenuItem,
            this.оперативныеДокументыToolStripMenuItem,
            this.отчётныеДокументыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочныеДокументыToolStripMenuItem
            // 
            this.справочныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.справочникЗалыToolStripMenuItem,
            this.справочникToolStripMenuItem});
            this.справочныеДокументыToolStripMenuItem.Name = "справочныеДокументыToolStripMenuItem";
            this.справочныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.справочныеДокументыToolStripMenuItem.Text = "Справочные документы";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.клиентыToolStripMenuItem.Text = "Справочник «Клиенты»";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // справочникЗалыToolStripMenuItem
            // 
            this.справочникЗалыToolStripMenuItem.Name = "справочникЗалыToolStripMenuItem";
            this.справочникЗалыToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.справочникЗалыToolStripMenuItem.Text = "Справочник «Список залов ресторана»";
            this.справочникЗалыToolStripMenuItem.Click += new System.EventHandler(this.справочникЗалыToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списковСтоловToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.справочникToolStripMenuItem.Text = "Справочник «Список столов в зале»";
            this.справочникToolStripMenuItem.Click += new System.EventHandler(this.справочникToolStripMenuItem_Click);
            // 
            // списковСтоловToolStripMenuItem
            // 
            this.списковСтоловToolStripMenuItem.Name = "списковСтоловToolStripMenuItem";
            this.списковСтоловToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.списковСтоловToolStripMenuItem.Text = "№ Списков столов";
            this.списковСтоловToolStripMenuItem.Click += new System.EventHandler(this.списковСтоловToolStripMenuItem_Click);
            // 
            // оперативныеДокументыToolStripMenuItem
            // 
            this.оперативныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem,
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem,
            this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem});
            this.оперативныеДокументыToolStripMenuItem.Name = "оперативныеДокументыToolStripMenuItem";
            this.оперативныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.оперативныеДокументыToolStripMenuItem.Text = "Оперативные документы";
            // 
            // журналУчетаПредварительныхЗаказовМестToolStripMenuItem
            // 
            this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem.Name = "журналУчетаПредварительныхЗаказовМестToolStripMenuItem";
            this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem.Size = new System.Drawing.Size(354, 22);
            this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem.Text = "Журнал «Учета предварительных заказов мест»";
            this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem.Click += new System.EventHandler(this.журналУчетаПредварительныхЗаказовМестToolStripMenuItem_Click);
            // 
            // журналПланЗанятостиМестРесторанаToolStripMenuItem
            // 
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЗанятыхСтоловToolStripMenuItem});
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem.Name = "журналПланЗанятостиМестРесторанаToolStripMenuItem";
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem.Size = new System.Drawing.Size(354, 22);
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem.Text = "Журнал «План занятости мест ресторана»";
            this.журналПланЗанятостиМестРесторанаToolStripMenuItem.Click += new System.EventHandler(this.журналПланЗанятостиМестРесторанаToolStripMenuItem_Click);
            // 
            // списокЗанятыхСтоловToolStripMenuItem
            // 
            this.списокЗанятыхСтоловToolStripMenuItem.Name = "списокЗанятыхСтоловToolStripMenuItem";
            this.списокЗанятыхСтоловToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.списокЗанятыхСтоловToolStripMenuItem.Text = "Список занятых столов";
            this.списокЗанятыхСтоловToolStripMenuItem.Click += new System.EventHandler(this.списокЗанятыхСтоловToolStripMenuItem_Click);
            // 
            // журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem
            // 
            this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem.Name = "журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem";
            this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem.Size = new System.Drawing.Size(354, 22);
            this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem.Text = "Журнал «Учета посещений клиентами ресторана»";
            this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem.Click += new System.EventHandler(this.журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem_Click);
            // 
            // отчётныеДокументыToolStripMenuItem
            // 
            this.отчётныеДокументыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетПоПредварительнымЗаказамМестToolStripMenuItem,
            this.отчетПоИспользованиюЗаловToolStripMenuItem,
            this.отчетОДеятельностиРесторанаToolStripMenuItem});
            this.отчётныеДокументыToolStripMenuItem.Name = "отчётныеДокументыToolStripMenuItem";
            this.отчётныеДокументыToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.отчётныеДокументыToolStripMenuItem.Text = "Отчётные документы";
            // 
            // отчетПоПредварительнымЗаказамМестToolStripMenuItem
            // 
            this.отчетПоПредварительнымЗаказамМестToolStripMenuItem.Name = "отчетПоПредварительнымЗаказамМестToolStripMenuItem";
            this.отчетПоПредварительнымЗаказамМестToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.отчетПоПредварительнымЗаказамМестToolStripMenuItem.Text = "Отчет по предварительным заказам мест (за месяц)";
            this.отчетПоПредварительнымЗаказамМестToolStripMenuItem.Click += new System.EventHandler(this.отчетПоПредварительнымЗаказамМестToolStripMenuItem_Click);
            // 
            // отчетПоИспользованиюЗаловToolStripMenuItem
            // 
            this.отчетПоИспользованиюЗаловToolStripMenuItem.Name = "отчетПоИспользованиюЗаловToolStripMenuItem";
            this.отчетПоИспользованиюЗаловToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.отчетПоИспользованиюЗаловToolStripMenuItem.Text = "Отчет по использованию залов (за месяц) ";
            this.отчетПоИспользованиюЗаловToolStripMenuItem.Click += new System.EventHandler(this.отчетПоИспользованиюЗаловToolStripMenuItem_Click);
            // 
            // отчетОДеятельностиРесторанаToolStripMenuItem
            // 
            this.отчетОДеятельностиРесторанаToolStripMenuItem.Name = "отчетОДеятельностиРесторанаToolStripMenuItem";
            this.отчетОДеятельностиРесторанаToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.отчетОДеятельностиРесторанаToolStripMenuItem.Text = "Отчет о деятельности ресторана (за год) ";
            this.отчетОДеятельностиРесторанаToolStripMenuItem.Click += new System.EventHandler(this.отчетОДеятельностиРесторанаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "D:";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Администратор Ресторана \"Golden Plaza\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникЗалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списковСтоловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оперативныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналУчетаПредварительныхЗаказовМестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналПланЗанятостиМестРесторанаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗанятыхСтоловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётныеДокументыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоПредварительнымЗаказамМестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоИспользованиюЗаловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОДеятельностиРесторанаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

