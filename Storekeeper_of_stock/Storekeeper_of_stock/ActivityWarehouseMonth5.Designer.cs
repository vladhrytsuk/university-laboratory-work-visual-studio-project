namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth5
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
            this.ActivityWarehouseMonth5_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth5_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth5_1TableAdapter();
            this.ActivityWarehouseMonth5_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth5_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth5_2TableAdapter();
            this.ActivityWarehouseMonth5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth5TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth5_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth5_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ActivityWarehouseMont5";
            reportDataSource1.Value = this.ActivityWarehouseMonth5_1BindingSource;
            reportDataSource2.Name = "ActivityWarehouseMont5_1";
            reportDataSource2.Value = this.ActivityWarehouseMonth5_2BindingSource;
            reportDataSource3.Name = "ActivityWarehouseMont5_2";
            reportDataSource3.Value = this.ActivityWarehouseMonth5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(712, 315);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth5_1BindingSource
            // 
            this.ActivityWarehouseMonth5_1BindingSource.DataMember = "ActivityWarehouseMonth5_1";
            this.ActivityWarehouseMonth5_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth5_1TableAdapter
            // 
            this.ActivityWarehouseMonth5_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth5_2BindingSource
            // 
            this.ActivityWarehouseMonth5_2BindingSource.DataMember = "ActivityWarehouseMonth5_2";
            this.ActivityWarehouseMonth5_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth5_2TableAdapter
            // 
            this.ActivityWarehouseMonth5_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth5BindingSource
            // 
            this.ActivityWarehouseMonth5BindingSource.DataMember = "ActivityWarehouseMonth5";
            this.ActivityWarehouseMonth5BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth5TableAdapter
            // 
            this.ActivityWarehouseMonth5TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 315);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth5";
            this.Text = "Отчёт о деятельности склада за Май";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth5_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth5_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth5_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth5_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth5BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth5_1TableAdapter ActivityWarehouseMonth5_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth5_2TableAdapter ActivityWarehouseMonth5_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth5TableAdapter ActivityWarehouseMonth5TableAdapter;
    }
}