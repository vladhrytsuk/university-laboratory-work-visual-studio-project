namespace Storekeeper_of_stock
{
    partial class ManufacturedProductsMonth10
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
            this.ManufacturedProductsMonth10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufacturedProductsMonth10TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ManufacturedProductsMonth10TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturedProductsMonth10BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ManufacturedProductsMonth10BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ManufacturedProductsMonth10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 296);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManufacturedProductsMonth10BindingSource
            // 
            this.ManufacturedProductsMonth10BindingSource.DataMember = "ManufacturedProductsMonth10";
            this.ManufacturedProductsMonth10BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ManufacturedProductsMonth10TableAdapter
            // 
            this.ManufacturedProductsMonth10TableAdapter.ClearBeforeFill = true;
            // 
            // ManufacturedProductsMonth10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 296);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ManufacturedProductsMonth10";
            this.Text = "Отчет по произведенной продукции за Октябрь";
            this.Load += new System.EventHandler(this.ManufacturedProductsMonth10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturedProductsMonth10BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ManufacturedProductsMonth10BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private Storekeeper_of_stockDataSetTableAdapters.ManufacturedProductsMonth10TableAdapter ManufacturedProductsMonth10TableAdapter;
    }
}