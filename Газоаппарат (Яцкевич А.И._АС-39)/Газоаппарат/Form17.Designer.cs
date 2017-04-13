namespace Газоаппарат
{
    partial class Form17
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
            this.КСУBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.КСУTableAdapter = new Газоаппарат.БрестГазDataSetTableAdapters.КСУTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.БрестГазDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.КСУBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Отчет_по_КСУ";
            reportDataSource1.Value = this.КСУBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Газоаппарат.Report5.rdlc";
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
            // КСУBindingSource
            // 
            this.КСУBindingSource.DataMember = "КСУ";
            this.КСУBindingSource.DataSource = this.БрестГазDataSet;
            // 
            // КСУTableAdapter
            // 
            this.КСУTableAdapter.ClearBeforeFill = true;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form17";
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.БрестГазDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.КСУBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource КСУBindingSource;
        private БрестГазDataSet БрестГазDataSet;
        private БрестГазDataSetTableAdapters.КСУTableAdapter КСУTableAdapter;
    }
}