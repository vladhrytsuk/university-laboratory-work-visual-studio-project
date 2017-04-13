namespace Storekeeper_of_stock
{
    partial class ManufacturedProductsMonth2
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
            this.ManufacturedProductsMonth2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufacturedProductsMonth2TableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.ManufacturedProductsMonth2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturedProductsMonth2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ManufacturedProductsMonth2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storekeeper_of_stock.ManufacturedProductsMonth2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(693, 305);
            this.reportViewer1.TabIndex = 0;
            // 
            // Storekeeper_of_stockDataSet
            // 
            this.Storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.Storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManufacturedProductsMonth2BindingSource
            // 
            this.ManufacturedProductsMonth2BindingSource.DataMember = "ManufacturedProductsMonth2";
            this.ManufacturedProductsMonth2BindingSource.DataSource = this.Storekeeper_of_stockDataSet;
            // 
            // ManufacturedProductsMonth2TableAdapter
            // 
            this.ManufacturedProductsMonth2TableAdapter.ClearBeforeFill = true;
            // 
            // ManufacturedProductsMonth2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 305);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ManufacturedProductsMonth2";
            this.Text = "Отчет по произведенной продукции за Февраль";
            this.Load += new System.EventHandler(this.ManufacturedProductsMonth2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufacturedProductsMonth2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ManufacturedProductsMonth2BindingSource;
        private Storekeeper_of_stockDataSet Storekeeper_of_stockDataSet;
        private Storekeeper_of_stockDataSetTableAdapters.ManufacturedProductsMonth2TableAdapter ManufacturedProductsMonth2TableAdapter;
    }
}