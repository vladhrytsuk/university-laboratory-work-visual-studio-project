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
    public partial class OTV : Form
    {
        public OTV()
        {
            InitializeComponent();
        }

        private void OTV_Load(object sender, EventArgs e)
        {
           this.OTVTableAdapter.Fill(this.Storekeeper_of_stockTVDataSet.OTV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OTVBindingSource.Filter = "CONVERT([Дата_оплаты], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OTVBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
