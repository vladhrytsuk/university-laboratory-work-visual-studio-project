namespace Газоаппарат
{
    partial class Form14
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
            this.Отчет_оборудBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отчет_оборудTableAdapter = new Газоаппарат.БрестГазDataSetTableAdapters.Отчет_оборудTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.БрестГазDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_оборудBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Отчет_по_оборуд";
            reportDataSource1.Value = this.Отчет_оборудBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Газоаппарат.Report1.rdlc";
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
            // Отчет_оборудBindingSource
            // 
            this.Отчет_оборудBindingSource.DataMember = "Отчет_оборуд";
            this.Отчет_оборудBindingSource.DataSource = this.БрестГазDataSet;
            // 
            // Отчет_оборудTableAdapter
            // 
            this.Отчет_оборудTableAdapter.ClearBeforeFill = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.БрестГазDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Отчет_оборудBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Отчет_оборудBindingSource;
        private БрестГазDataSet БрестГазDataSet;
        private БрестГазDataSetTableAdapters.Отчет_оборудTableAdapter Отчет_оборудTableAdapter;
    }
}