using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Cosmetic
{
    public partial class OUSLUG : Form
    {
        public OUSLUG()
        {
            InitializeComponent();
        }

        private void OUSLUG_Load(object sender, EventArgs e)
        {
            this.OUSLUGTableAdapter.Fill(this.Admin_CosmeticDataSet.OUSLUG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OUSLUGBindingSource.Filter = "CONVERT([Дата_заказа], 'System.String') LIKE '*." + comboBox1.Text + ".*'" + "and [Название_услуги] LIKE '" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OUSLUGBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cotalog f1 = new Cotalog();
            f1.Show();
        }

    }
}
