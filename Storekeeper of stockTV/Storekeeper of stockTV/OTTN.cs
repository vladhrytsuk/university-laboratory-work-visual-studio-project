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
    public partial class OTTN : Form
    {
        public OTTN()
        {
            InitializeComponent();
        }

        private void OTTN_Load(object sender, EventArgs e)
        {
            this.OTTNTableAdapter.Fill(this.Storekeeper_of_stockTVDataSet.OTTN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OTTNBindingSource.Filter = "CONVERT([Дата_заключения], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OTTNBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
