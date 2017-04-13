using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storekeeper_of_stock
{
    public partial class OActivityWarehouse : Form
    {
        public OActivityWarehouse()
        {
            InitializeComponent();
        }

        private void OActivityWarehouse_Load(object sender, EventArgs e)
        {
            this.OActivityWarehouse1_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.OActivityWarehouse1_1);
            this.OActivityWarehouse1_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.OActivityWarehouse1_2);
            this.OActivityWarehouse1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.OActivityWarehouse1);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OActivityWarehouse1BindingSource.Filter = "CONVERT([Дата_заключения], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.OActivityWarehouse1_1BindingSource.Filter = "CONVERT([Дата_заключения], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.OActivityWarehouse1_2BindingSource.Filter = "CONVERT([Дата_заключения], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OActivityWarehouse1BindingSource.Filter = "";
            this.OActivityWarehouse1_1BindingSource.Filter = "";
            this.OActivityWarehouse1_2BindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
