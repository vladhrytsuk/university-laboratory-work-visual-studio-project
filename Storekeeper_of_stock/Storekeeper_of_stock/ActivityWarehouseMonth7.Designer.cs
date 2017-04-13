namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth7
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
            this.ActivityWarehouseMonth7_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth7_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth7_1TableAdapter();
            this.ActivityWarehouseMonth7_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth7_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth7_2TableAdapter();
            this.ActivityWarehouseMonth7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth7TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth7TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth7_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth7_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ActivityWarehouseMonth7";
            reportDataSource1.Value = this.ActivityWarehouseMonth7_1BindingSource;
            reportDataSource2.Name = "ActivityWarehouseMonth7_1";
            reportDataSource2.Value = this.ActivityWarehouseMonth7_2BindingSource;
            reportDataSource3.Name = "ActivityWarehouseMonth7_2";
            reportDataSource3.Value = this.ActivityWarehouseMonth7BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(687, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth7_1BindingSource
            // 
            this.ActivityWarehouseMonth7_1BindingSource.DataMember = "ActivityWarehouseMonth7_1";
            this.ActivityWarehouseMonth7_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth7_1TableAdapter
            // 
            this.ActivityWarehouseMonth7_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth7_2BindingSource
            // 
            this.ActivityWarehouseMonth7_2BindingSource.DataMember = "ActivityWarehouseMonth7_2";
            this.ActivityWarehouseMonth7_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth7_2TableAdapter
            // 
            this.ActivityWarehouseMonth7_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth7BindingSource
            // 
            this.ActivityWarehouseMonth7BindingSource.DataMember = "ActivityWarehouseMonth7";
            this.ActivityWarehouseMonth7BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth7TableAdapter
            // 
            this.ActivityWarehouseMonth7TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 313);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth7";
            this.Text = "Отчёт о деятельности склада за Июль";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth7_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth7_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth7BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth7_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth7_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth7BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth7_1TableAdapter ActivityWarehouseMonth7_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth7_2TableAdapter ActivityWarehouseMonth7_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth7TableAdapter ActivityWarehouseMonth7TableAdapter;
    }
}