namespace Admin_Restoran
{
    partial class PreOrderSeatMonth10
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
            this.PreOrderSeatMonth10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Admin_RestoranDataSet1 = new Admin_Restoran.Admin_RestoranDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PreOrderSeatMonth10TableAdapter = new Admin_Restoran.Admin_RestoranDataSet1TableAdapters.PreOrderSeatMonth10TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PreOrderSeatMonth10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PreOrderSeatMonth10BindingSource
            // 
            this.PreOrderSeatMonth10BindingSource.DataMember = "PreOrderSeatMonth10";
            this.PreOrderSeatMonth10BindingSource.DataSource = this.Admin_RestoranDataSet1;
            // 
            // Admin_RestoranDataSet1
            // 
            this.Admin_RestoranDataSet1.DataSetName = "Admin_RestoranDataSet1";
            this.Admin_RestoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PreOrderSeatMonth10";
            reportDataSource1.Value = this.PreOrderSeatMonth10BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin_Restoran.PreOrderSeatMonth10.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(415, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // PreOrderSeatMonth10TableAdapter
            // 
            this.PreOrderSeatMonth10TableAdapter.ClearBeforeFill = true;
            // 
            // PreOrderSeatMonth10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 348);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PreOrderSeatMonth10";
            this.Text = "Отчет по предварительным заказам мест за Октябрь";
            this.Load += new System.EventHandler(this.PreOrderSeatMonth10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreOrderSeatMonth10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PreOrderSeatMonth10BindingSource;
        private Admin_RestoranDataSet1 Admin_RestoranDataSet1;
        private Admin_RestoranDataSet1TableAdapters.PreOrderSeatMonth10TableAdapter PreOrderSeatMonth10TableAdapter;
    }
}