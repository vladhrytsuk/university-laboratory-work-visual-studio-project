namespace Storekeeper_of_stockTV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Storekeeper_of_stockTVDataSet = new Storekeeper_of_stockTV.Storekeeper_of_stockTVDataSet();
            this.OActivityWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OActivityWarehouseTableAdapter = new Storekeeper_of_stockTV.Storekeeper_of_stockTVDataSetTableAdapters.OActivityWarehouseTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "OActivityWarehouse";
            reportDataSource2.Value = this.OActivityWarehouseBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stockTV.OActivityWarehouse.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(594, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockTVDataSet
            // 
            this.Storekeeper_of_stockTVDataSet.DataSetName = "Storekeeper_of_stockTVDataSet";
            this.Storekeeper_of_stockTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OActivityWarehouseBindingSource
            // 
            this.OActivityWarehouseBindingSource.DataMember = "OActivityWarehouse";
            this.OActivityWarehouseBindingSource.DataSource = this.Storekeeper_of_stockTVDataSet;
            // 
            // OActivityWarehouseTableAdapter
            // 
            this.OActivityWarehouseTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Сбросить фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(343, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Месяц:";
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
            this.comboBox1.Location = new System.Drawing.Point(403, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // OActivityWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OActivityWarehouse";
            this.Text = "Отчёт о деятельности склада";
            this.Load += new System.EventHandler(this.OActivityWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OActivityWarehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OActivityWarehouseBindingSource;
        private Storekeeper_of_stockTVDataSet Storekeeper_of_stockTVDataSet;
        private Storekeeper_of_stockTVDataSetTableAdapters.OActivityWarehouseTableAdapter OActivityWarehouseTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}