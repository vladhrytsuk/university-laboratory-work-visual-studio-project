namespace Storekeeper_of_stock
{
    partial class ActivityWarehouseMonth2
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
            this.ActivityWarehouseMonth2_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth2_1TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth2_1TableAdapter();
            this.ActivityWarehouseMonth2_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth2_2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth2_2TableAdapter();
            this.ActivityWarehouseMonth2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActivityWarehouseMonth2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth2_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth2_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ActivityWarehouseMonth2";
            reportDataSource1.Value = this.ActivityWarehouseMonth2_1BindingSource;
            reportDataSource2.Name = "ActivityWarehouseMonth2_1";
            reportDataSource2.Value = this.ActivityWarehouseMonth2_2BindingSource;
            reportDataSource3.Name = "ActivityWarehouseMonth2_2";
            reportDataSource3.Value = this.ActivityWarehouseMonth2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ActivityWarehouseMonth2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ActivityWarehouseMonth2_1BindingSource
            // 
            this.ActivityWarehouseMonth2_1BindingSource.DataMember = "ActivityWarehouseMonth2_1";
            this.ActivityWarehouseMonth2_1BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth2_1TableAdapter
            // 
            this.ActivityWarehouseMonth2_1TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth2_2BindingSource
            // 
            this.ActivityWarehouseMonth2_2BindingSource.DataMember = "ActivityWarehouseMonth2_2";
            this.ActivityWarehouseMonth2_2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth2_2TableAdapter
            // 
            this.ActivityWarehouseMonth2_2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth2BindingSource
            // 
            this.ActivityWarehouseMonth2BindingSource.DataMember = "ActivityWarehouseMonth2";
            this.ActivityWarehouseMonth2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ActivityWarehouseMonth2TableAdapter
            // 
            this.ActivityWarehouseMonth2TableAdapter.ClearBeforeFill = true;
            // 
            // ActivityWarehouseMonth2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 324);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ActivityWarehouseMonth2";
            this.Text = "Отчёт о деятельности склада за Февраль";
            this.Load += new System.EventHandler(this.ActivityWarehouseMonth2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth2_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth2_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWarehouseMonth2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth2_1BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth2_2BindingSource;
        private System.Windows.Forms.BindingSource ActivityWarehouseMonth2BindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth2_1TableAdapter ActivityWarehouseMonth2_1TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth2_2TableAdapter ActivityWarehouseMonth2_2TableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.ActivityWarehouseMonth2TableAdapter ActivityWarehouseMonth2TableAdapter;
    }
}