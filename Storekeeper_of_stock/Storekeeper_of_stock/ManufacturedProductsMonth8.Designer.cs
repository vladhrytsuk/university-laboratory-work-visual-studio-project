namespace Storekeeper_of_stock
{
    partial class ManufacturedProductsMonth8
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Storekeeper_of_stockDataSet = new Storekeeper_of_stock.Storekeeper_of_stockDataSet();
            this.ManufacturedProductsMonth8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufacturedProductsMonth8TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ManufacturedProductsMonth8TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturedProductsMonth8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ManufacturedProductsMonth8BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ManufacturedProductsMonth8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(707, 301);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManufacturedProductsMonth8BindingSource
            // 
            this.ManufacturedProductsMonth8BindingSource.DataMember = "ManufacturedProductsMonth8";
            this.ManufacturedProductsMonth8BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ManufacturedProductsMonth8TableAdapter
            // 
            this.ManufacturedProductsMonth8TableAdapter.ClearBeforeFill = true;
            // 
            // ManufacturedProductsMonth8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 301);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ManufacturedProductsMonth8";
            this.Text = "Отчет по произведенной продукции за Август";
            this.Load += new System.EventHandler(this.ManufacturedProductsMonth8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturedProductsMonth8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ManufacturedProductsMonth8BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private Storekeeper_of_stockDataSetTableAdapters.ManufacturedProductsMonth8TableAdapter ManufacturedProductsMonth8TableAdapter;
    }
}