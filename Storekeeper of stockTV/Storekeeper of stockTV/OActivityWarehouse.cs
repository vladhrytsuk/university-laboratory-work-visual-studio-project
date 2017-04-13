using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storekeeper_of_stockTV
{
    public partial class OActivityWarehouse : Form
    {
        public OActivityWarehouse()
        {
            InitializeComponent();
        }

        private void OActivityWarehouse_Load(object sender, EventArgs e)
        {
            this.OActivityWarehouseTableAdapter.Fill(this.Storekeeper_of_stockTVDataSet.OActivityWarehouse);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OActivityWarehouseBindingSource.Filter = "CONVERT([Дата_операции], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OActivityWarehouseBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
