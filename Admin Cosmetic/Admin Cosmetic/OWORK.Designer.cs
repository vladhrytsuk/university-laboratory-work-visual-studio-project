namespace Admin_Cosmetic
{
    partial class OWORK
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OWORK_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Admin_CosmeticDataSet = new Admin_Cosmetic.Admin_CosmeticDataSet();
            this.OWORK_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OWORK_1TableAdapter = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.OWORK_1TableAdapter();
            this.OWORK_2TableAdapter = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.OWORK_2TableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OWORK_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_CosmeticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OWORK_2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(380, 263);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(326, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Месяц:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите Ф.И.О сотрудника:";
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "OWORK_1";
            reportDataSource3.Value = this.OWORK_1BindingSource;
            reportDataSource4.Name = "OWORK_2";
            reportDataSource4.Value = this.OWORK_2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin_Cosmetic.OWORK.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 246);
            this.reportViewer1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сбросить фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OWORK_1BindingSource
            // 
            this.OWORK_1BindingSource.DataMember = "OWORK_1";
            this.OWORK_1BindingSource.DataSource = this.Admin_CosmeticDataSet;
            // 
            // Admin_CosmeticDataSet
            // 
            this.Admin_CosmeticDataSet.DataSetName = "Admin_CosmeticDataSet";
            this.Admin_CosmeticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OWORK_2BindingSource
            // 
            this.OWORK_2BindingSource.DataMember = "OWORK_2";
            this.OWORK_2BindingSource.DataSource = this.Admin_CosmeticDataSet;
            // 
            // OWORK_1TableAdapter
            // 
            this.OWORK_1TableAdapter.ClearBeforeFill = true;
            // 
            // OWORK_2TableAdapter
            // 
            this.OWORK_2TableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Справочник \"Сотрудники\"";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OWORK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 322);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "OWORK";
            this.Text = "Отчёт по сотруднику";
            this.Load += new System.EventHandler(this.OWORK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OWORK_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_CosmeticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OWORK_2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OWORK_1BindingSource;
        private Admin_CosmeticDataSet Admin_CosmeticDataSet;
        private System.Windows.Forms.BindingSource OWORK_2BindingSource;
        private Admin_CosmeticDataSetTableAdapters.OWORK_1TableAdapter OWORK_1TableAdapter;
        private Admin_CosmeticDataSetTableAdapters.OWORK_2TableAdapter OWORK_2TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}