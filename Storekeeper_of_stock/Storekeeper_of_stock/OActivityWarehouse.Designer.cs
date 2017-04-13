namespace Storekeeper_of_stock
{
    partial class OActivityWarehouse
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Storekeeper_of_stockDataSet = new Storekeeper_of_stock.Storekeeper_of_stockDataSet();
            this.OActivityWarehouse1_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OActivityWarehouse1_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.OActivityWarehouse1_1TableAdapter();
            this.OActivityWarehouse1_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OActivityWarehouse1_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.OActivityWarehouse1_2TableAdapter();
            this.OActivityWarehouse1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OActivityWarehouse1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.OActivityWarehouse1TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouse1_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouse1_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouse1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.OActivityWarehouse1_1BindingSource;
            reportDataSource5.Name = "DataSet2";
            reportDataSource5.Value = this.OActivityWarehouse1_2BindingSource;
            reportDataSource6.Name = "DataSet3";
            reportDataSource6.Value = this.OActivityWarehouse1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouse.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(892, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OActivityWarehouse1_1BindingSource
            // 
            this.OActivityWarehouse1_1BindingSource.DataMember = "OActivityWarehouse1_1";
            this.OActivityWarehouse1_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // OActivityWarehouse1_1TableAdapter
            // 
            this.OActivityWarehouse1_1TableAdapter.ClearBeforeFill = true;
            // 
            // OActivityWarehouse1_2BindingSource
            // 
            this.OActivityWarehouse1_2BindingSource.DataMember = "OActivityWarehouse1_2";
            this.OActivityWarehouse1_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // OActivityWarehouse1_2TableAdapter
            // 
            this.OActivityWarehouse1_2TableAdapter.ClearBeforeFill = true;
            // 
            // OActivityWarehouse1BindingSource
            // 
            this.OActivityWarehouse1BindingSource.DataMember = "OActivityWarehouse1";
            this.OActivityWarehouse1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // OActivityWarehouse1TableAdapter
            // 
            this.OActivityWarehouse1TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сбросить фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(384, 352);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Месяц:";
            // 
            // OActivityWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OActivityWarehouse";
            this.Text = "Отчёт о деятельности склада";
            this.Load += new System.EventHandler(this.OActivityWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouse1_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouse1_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouse1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OActivityWarehouse1_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource OActivityWarehouse1_2BindingSource;
        private System.Windows.Forms.BindingSource OActivityWarehouse1BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.OActivityWarehouse1_1TableAdapter OActivityWarehouse1_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.OActivityWarehouse1_2TableAdapter OActivityWarehouse1_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.OActivityWarehouse1TableAdapter OActivityWarehouse1TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}