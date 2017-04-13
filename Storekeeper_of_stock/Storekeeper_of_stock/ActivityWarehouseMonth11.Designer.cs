namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth11
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
            this.ActivityWarehouseMonth11_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth11_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth11_1TableAdapter();
            this.ActivityWarehouseMonth11_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth11_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth11_2TableAdapter();
            this.ActivityWarehouseMonth11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth11TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth11TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth11_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth11_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ActivityWarehouseMonth11_1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ActivityWarehouseMonth11_2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ActivityWarehouseMonth11BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth11.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth11_1BindingSource
            // 
            this.ActivityWarehouseMonth11_1BindingSource.DataMember = "ActivityWarehouseMonth11_1";
            this.ActivityWarehouseMonth11_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth11_1TableAdapter
            // 
            this.ActivityWarehouseMonth11_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth11_2BindingSource
            // 
            this.ActivityWarehouseMonth11_2BindingSource.DataMember = "ActivityWarehouseMonth11_2";
            this.ActivityWarehouseMonth11_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth11_2TableAdapter
            // 
            this.ActivityWarehouseMonth11_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth11BindingSource
            // 
            this.ActivityWarehouseMonth11BindingSource.DataMember = "ActivityWarehouseMonth11";
            this.ActivityWarehouseMonth11BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth11TableAdapter
            // 
            this.ActivityWarehouseMonth11TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 280);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth11";
            this.Text = "Отчёт о деятельности склада за Ноябрь";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth11_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth11_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth11_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth11_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth11BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth11_1TableAdapter ActivityWarehouseMonth11_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth11_2TableAdapter ActivityWarehouseMonth11_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth11TableAdapter ActivityWarehouseMonth11TableAdapter;
    }
}