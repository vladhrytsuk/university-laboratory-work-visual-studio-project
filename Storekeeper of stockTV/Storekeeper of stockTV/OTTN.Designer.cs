namespace Storekeeper_of_stockTV
{
    partial class OTTN
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OTTNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Storekeeper_of_stockTVDataSet = new Storekeeper_of_stockTV.Storekeeper_of_stockTVDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OTTNTableAdapter = new Storekeeper_of_stockTV.Storekeeper_of_stockTVDataSetTableAdapters.OTTNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OTTNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockTVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OTTNBindingSource
            // 
            this.OTTNBindingSource.DataMember = "OTTN";
            this.OTTNBindingSource.DataSource = this.Storekeeper_of_stockTVDataSet;
            // 
            // Storekeeper_of_stockTVDataSet
            // 
            this.Storekeeper_of_stockTVDataSet.DataSetName = "Storekeeper_of_stockTVDataSet";
            this.Storekeeper_of_stockTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.comboBox1.Location = new System.Drawing.Point(487, 283);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Месяц:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сбросить фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "OTTN";
            reportDataSource2.Value = this.OTTNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stockTV.OTTN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(687, 265);
            this.reportViewer1.TabIndex = 4;
            // 
            // OTTNTableAdapter
            // 
            this.OTTNTableAdapter.ClearBeforeFill = true;
            // 
            // OTTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "OTTN";
            this.Text = "Отчёт о ТТН (за месяц)";
            this.Load += new System.EventHandler(this.OTTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OTTNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockTVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OTTNBindingSource;
        private Storekeeper_of_stockTVDataSet Storekeeper_of_stockTVDataSet;
        private Storekeeper_of_stockTVDataSetTableAdapters.OTTNTableAdapter OTTNTableAdapter;
    }
}