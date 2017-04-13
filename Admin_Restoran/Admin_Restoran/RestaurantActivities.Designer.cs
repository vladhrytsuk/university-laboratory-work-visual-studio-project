namespace Admin_Restoran
{
    partial class RestaurantActivities
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Admin_RestoranDataSet2 = new Admin_Restoran.Admin_RestoranDataSet2();
            this.RestaurantActivitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RestaurantActivitiesTableAdapter = new Admin_Restoran.Admin_RestoranDataSet2TableAdapters.RestaurantActivitiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantActivitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "RestaurantActivities";
            reportDataSource2.Value = this.RestaurantActivitiesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin_Restoran.RestaurantActivities.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(695, 299);
            this.reportViewer1.TabIndex = 0;
            // 
            // Admin_RestoranDataSet2
            // 
            this.Admin_RestoranDataSet2.DataSetName = "Admin_RestoranDataSet2";
            this.Admin_RestoranDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RestaurantActivitiesBindingSource
            // 
            this.RestaurantActivitiesBindingSource.DataMember = "RestaurantActivities";
            this.RestaurantActivitiesBindingSource.DataSource = this.Admin_RestoranDataSet2;
            // 
            // RestaurantActivitiesTableAdapter
            // 
            this.RestaurantActivitiesTableAdapter.ClearBeforeFill = true;
            // 
            // RestaurantActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 299);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RestaurantActivities";
            this.Text = "Отчет о деятельности ресторана (за год)";
            this.Load += new System.EventHandler(this.RestaurantActivities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_RestoranDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantActivitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RestaurantActivitiesBindingSource;
        private Admin_RestoranDataSet2 Admin_RestoranDataSet2;
        private Admin_RestoranDataSet2TableAdapters.RestaurantActivitiesTableAdapter RestaurantActivitiesTableAdapter;
    }
}