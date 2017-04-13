namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth1
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
            this.ActivityWarehouseMonth1_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth1_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth1_1TableAdapter();
            this.ActivityWarehouseMonth1_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth1_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth1_2TableAdapter();
            this.ActivityWarehouseMonth1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth1_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth1_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ActivityWarehouseMonth1";
            reportDataSource1.Value = this.ActivityWarehouseMonth1_1BindingSource;
            reportDataSource2.Name = "ActivityWarehouseMonth1_1";
            reportDataSource2.Value = this.ActivityWarehouseMonth1_2BindingSource;
            reportDataSource3.Name = "ActivityWarehouseMonth1_2";
            reportDataSource3.Value = this.ActivityWarehouseMonth1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(692, 346);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth1_1BindingSource
            // 
            this.ActivityWarehouseMonth1_1BindingSource.DataMember = "ActivityWarehouseMonth1_1";
            this.ActivityWarehouseMonth1_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth1_1TableAdapter
            // 
            this.ActivityWarehouseMonth1_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth1_2BindingSource
            // 
            this.ActivityWarehouseMonth1_2BindingSource.DataMember = "ActivityWarehouseMonth1_2";
            this.ActivityWarehouseMonth1_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth1_2TableAdapter
            // 
            this.ActivityWarehouseMonth1_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth1BindingSource
            // 
            this.ActivityWarehouseMonth1BindingSource.DataMember = "ActivityWarehouseMonth1";
            this.ActivityWarehouseMonth1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth1TableAdapter
            // 
            this.ActivityWarehouseMonth1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 346);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth1";
            this.Text = "Отчёт о деятельности склада за Январь";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth1_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth1_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth1_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth1_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth1BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth1_1TableAdapter ActivityWarehouseMonth1_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth1_2TableAdapter ActivityWarehouseMonth1_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth1TableAdapter ActivityWarehouseMonth1TableAdapter;
    }
}