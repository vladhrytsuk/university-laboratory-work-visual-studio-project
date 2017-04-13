namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth6
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
            this.ActivityWarehouseMonth6_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth6_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth6_1TableAdapter();
            this.ActivityWarehouseMonth6_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth6_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth6_2TableAdapter();
            this.ActivityWarehouseMonth6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth6TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth6_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth6_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "ActivityWarehouseMonth6";
            reportDataSource4.Value = this.ActivityWarehouseMonth6_1BindingSource;
            reportDataSource5.Name = "ActivityWarehouseMonth6_1";
            reportDataSource5.Value = this.ActivityWarehouseMonth6_2BindingSource;
            reportDataSource6.Name = "ActivityWarehouseMonth6_2";
            reportDataSource6.Value = this.ActivityWarehouseMonth6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth6_1BindingSource
            // 
            this.ActivityWarehouseMonth6_1BindingSource.DataMember = "ActivityWarehouseMonth6_1";
            this.ActivityWarehouseMonth6_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth6_1TableAdapter
            // 
            this.ActivityWarehouseMonth6_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth6_2BindingSource
            // 
            this.ActivityWarehouseMonth6_2BindingSource.DataMember = "ActivityWarehouseMonth6_2";
            this.ActivityWarehouseMonth6_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth6_2TableAdapter
            // 
            this.ActivityWarehouseMonth6_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth6BindingSource
            // 
            this.ActivityWarehouseMonth6BindingSource.DataMember = "ActivityWarehouseMonth6";
            this.ActivityWarehouseMonth6BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth6TableAdapter
            // 
            this.ActivityWarehouseMonth6TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 317);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth6";
            this.Text = "Отчёт о деятельности склада за Июнь";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth6_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth6_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth6_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth6_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth6BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth6_1TableAdapter ActivityWarehouseMonth6_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth6_2TableAdapter ActivityWarehouseMonth6_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth6TableAdapter ActivityWarehouseMonth6TableAdapter;
    }
}