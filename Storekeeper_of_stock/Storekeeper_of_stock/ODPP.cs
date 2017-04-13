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
    public partial class ODPP : Form
    {
        public ODPP()
        {
            InitializeComponent();
        }

        private void ODPP_Load(object sender, EventArgs e)
        {
            this.ODPPTableAdapter.Fill(this.Storekeeper_of_stockDataSet.ODPP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ODPPBindingSource.Filter = "CONVERT([Дата_заключения], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ODPPBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
