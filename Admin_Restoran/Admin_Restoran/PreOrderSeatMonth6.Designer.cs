namespace Admin_Restoran
{
    partial class PreOrderSeatMonth6
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
            this.Admin_RestoranDataSet1 = new Admin_Restoran.Admin_RestoranDataSet1();
            this.PreOrderSeatMonth6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PreOrderSeatMonth6TableAdapter = new Admin_Restoran.Admin_RestoranDataSet1TableAdapters.PreOrderSeatMonth6TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreOrderSeatMonth6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PreOrderSeatMonth6";
            reportDataSource1.Value = this.PreOrderSeatMonth6BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin_Restoran.PreOrderSeatMonth6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(449, 360);
            this.reportViewer1.TabIndex = 0;
            // 
            // Admin_RestoranDataSet1
            // 
            this.Admin_RestoranDataSet1.DataSetName = "Admin_RestoranDataSet1";
            this.Admin_RestoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PreOrderSeatMonth6BindingSource
            // 
            this.PreOrderSeatMonth6BindingSource.DataMember = "PreOrderSeatMonth6";
            this.PreOrderSeatMonth6BindingSource.DataSource = this.Admin_RestoranDataSet1;
            // 
            // PreOrderSeatMonth6TableAdapter
            // 
            this.PreOrderSeatMonth6TableAdapter.ClearBeforeFill = true;
            // 
            // PreOrderSeatMonth6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 360);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PreOrderSeatMonth6";
            this.Text = "Отчет по предварительным заказам мест за Июнь";
            this.Load += new System.EventHandler(this.PreOrderSeatMonth6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreOrderSeatMonth6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PreOrderSeatMonth6BindingSource;
        private Admin_RestoranDataSet1 Admin_RestoranDataSet1;
        private Admin_RestoranDataSet1TableAdapters.PreOrderSeatMonth6TableAdapter PreOrderSeatMonth6TableAdapter;
    }
}