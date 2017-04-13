namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth4
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
            this.ActivityWarehouseMonth4_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth4_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth4_1TableAdapter();
            this.ActivityWarehouseMonth4_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth4_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth4_2TableAdapter();
            this.ActivityWarehouseMonth4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth4TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth4_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth4_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ActivityWarehouseMonth4";
            reportDataSource1.Value = this.ActivityWarehouseMonth4_1BindingSource;
            reportDataSource2.Name = "ActivityWarehouseMonth4_1";
            reportDataSource2.Value = this.ActivityWarehouseMonth4_2BindingSource;
            reportDataSource3.Name = "ActivityWarehouseMonth4_2";
            reportDataSource3.Value = this.ActivityWarehouseMonth4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(699, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth4_1BindingSource
            // 
            this.ActivityWarehouseMonth4_1BindingSource.DataMember = "ActivityWarehouseMonth4_1";
            this.ActivityWarehouseMonth4_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth4_1TableAdapter
            // 
            this.ActivityWarehouseMonth4_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth4_2BindingSource
            // 
            this.ActivityWarehouseMonth4_2BindingSource.DataMember = "ActivityWarehouseMonth4_2";
            this.ActivityWarehouseMonth4_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth4_2TableAdapter
            // 
            this.ActivityWarehouseMonth4_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth4BindingSource
            // 
            this.ActivityWarehouseMonth4BindingSource.DataMember = "ActivityWarehouseMonth4";
            this.ActivityWarehouseMonth4BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth4TableAdapter
            // 
            this.ActivityWarehouseMonth4TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 330);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth4";
            this.Text = "Отчёт о деятельности склада за Апрель";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth4_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth4_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth4_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth4_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth4BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth4_1TableAdapter ActivityWarehouseMonth4_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth4_2TableAdapter ActivityWarehouseMonth4_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth4TableAdapter ActivityWarehouseMonth4TableAdapter;
    }
}