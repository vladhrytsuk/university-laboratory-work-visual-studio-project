namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth10
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
            this.ActivityWarehouseMonth10_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth10_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth10_1TableAdapter();
            this.ActivityWarehouseMonth10_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth10_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth10_2TableAdapter();
            this.ActivityWarehouseMonth10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth10TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth10TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth10_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth10_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth10BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ActivityWarehouseMonth10_1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ActivityWarehouseMonth10_2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ActivityWarehouseMonth10BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(696, 316);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth10_1BindingSource
            // 
            this.ActivityWarehouseMonth10_1BindingSource.DataMember = "ActivityWarehouseMonth10_1";
            this.ActivityWarehouseMonth10_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth10_1TableAdapter
            // 
            this.ActivityWarehouseMonth10_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth10_2BindingSource
            // 
            this.ActivityWarehouseMonth10_2BindingSource.DataMember = "ActivityWarehouseMonth10_2";
            this.ActivityWarehouseMonth10_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth10_2TableAdapter
            // 
            this.ActivityWarehouseMonth10_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth10BindingSource
            // 
            this.ActivityWarehouseMonth10BindingSource.DataMember = "ActivityWarehouseMonth10";
            this.ActivityWarehouseMonth10BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth10TableAdapter
            // 
            this.ActivityWarehouseMonth10TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 316);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth10";
            this.Text = "Отчёт о деятельности склада за Октябрь";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth10_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth10_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth10BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth10_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth10_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth10BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth10_1TableAdapter ActivityWarehouseMonth10_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth10_2TableAdapter ActivityWarehouseMonth10_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth10TableAdapter ActivityWarehouseMonth10TableAdapter;
    }
}