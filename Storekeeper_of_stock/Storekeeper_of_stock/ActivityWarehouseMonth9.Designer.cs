namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth9
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Storekeeper_of_stockDataSet = new Storekeeper_of_stock.Storekeeper_of_stockDataSet();
            this.ActivityWarehouseMonth9_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth9_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth9_1TableAdapter();
            this.ActivityWarehouseMonth9_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth9_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth9_2TableAdapter();
            this.ActivityWarehouseMonth9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth9TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth9TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth9_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth9_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ActivityWarehouseMonth9_1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ActivityWarehouseMonth9_2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ActivityWarehouseMonth9BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 312);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth9_1BindingSource
            // 
            this.ActivityWarehouseMonth9_1BindingSource.DataMember = "ActivityWarehouseMonth9_1";
            this.ActivityWarehouseMonth9_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth9_1TableAdapter
            // 
            this.ActivityWarehouseMonth9_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth9_2BindingSource
            // 
            this.ActivityWarehouseMonth9_2BindingSource.DataMember = "ActivityWarehouseMonth9_2";
            this.ActivityWarehouseMonth9_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth9_2TableAdapter
            // 
            this.ActivityWarehouseMonth9_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth9BindingSource
            // 
            this.ActivityWarehouseMonth9BindingSource.DataMember = "ActivityWarehouseMonth9";
            this.ActivityWarehouseMonth9BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth9TableAdapter
            // 
            this.ActivityWarehouseMonth9TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 312);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth9";
            this.Text = "Отчёт о деятельности склада за Сентябрь";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth9_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth9_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth9BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth9_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth9_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth9BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth9_1TableAdapter ActivityWarehouseMonth9_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth9_2TableAdapter ActivityWarehouseMonth9_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth9TableAdapter ActivityWarehouseMonth9TableAdapter;
    }
}