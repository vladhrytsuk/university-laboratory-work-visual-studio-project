namespace Admin_Restoran
{
    partial class UseRoomsMonth4
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
            this.UseRoomsMonth4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UseRoomsMonth4TableAdapter = new Admin_Restoran.Admin_RestoranDataSet1TableAdapters.UseRoomsMonth4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseRoomsMonth4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UseRoomsMonth4";
            reportDataSource1.Value = this.UseRoomsMonth4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin_Restoran.UseRoomsMonth4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(434, 347);
            this.reportViewer1.TabIndex = 0;
            // 
            // Admin_RestoranDataSet1
            // 
            this.Admin_RestoranDataSet1.DataSetName = "Admin_RestoranDataSet1";
            this.Admin_RestoranDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UseRoomsMonth4BindingSource
            // 
            this.UseRoomsMonth4BindingSource.DataMember = "UseRoomsMonth4";
            this.UseRoomsMonth4BindingSource.DataSource = this.Admin_RestoranDataSet1;
            // 
            // UseRoomsMonth4TableAdapter
            // 
            this.UseRoomsMonth4TableAdapter.ClearBeforeFill = true;
            // 
            // UseRoomsMonth4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 347);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UseRoomsMonth4";
            this.Text = "Отчет по использованию залов за Апрель";
            this.Load += new System.EventHandler(this.UseRoomsMonth4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UseRoomsMonth4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UseRoomsMonth4BindingSource;
        private Admin_RestoranDataSet1 Admin_RestoranDataSet1;
        private Admin_RestoranDataSet1TableAdapters.UseRoomsMonth4TableAdapter UseRoomsMonth4TableAdapter;
    }
}