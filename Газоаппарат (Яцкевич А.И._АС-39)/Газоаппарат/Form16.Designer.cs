namespace Газоаппарат
{
    partial class Form16
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
            this.БрестГазDataSet = new Газоаппарат.БрестГазDataSet();
            this.НЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.НЗTableAdapter = new Газоаппарат.БрестГазDataSetTableAdapters.НЗTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.БрестГазDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.НЗBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Отчет_по_нз";
            reportDataSource1.Value = this.НЗBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Газоаппарат.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // БрестГазDataSet
            // 
            this.БрестГазDataSet.DataSetName = "БрестГазDataSet";
            this.БрестГазDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // НЗBindingSource
            // 
            this.НЗBindingSource.DataMember = "НЗ";
            this.НЗBindingSource.DataSource = this.БрестГазDataSet;
            // 
            // НЗTableAdapter
            // 
            this.НЗTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form16";
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.БрестГазDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.НЗBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource НЗBindingSource;
        private БрестГазDataSet БрестГазDataSet;
        private БрестГазDataSetTableAdapters.НЗTableAdapter НЗTableAdapter;
    }
}