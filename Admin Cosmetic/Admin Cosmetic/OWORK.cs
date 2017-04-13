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
    public partial class OWORK : Form
    {
        public OWORK()
        {
            InitializeComponent();
        }

        private void OWORK_Load(object sender, EventArgs e)
        {
            this.OWORK_1TableAdapter.Fill(this.Admin_CosmeticDataSet.OWORK_1);
            this.OWORK_2TableAdapter.Fill(this.Admin_CosmeticDataSet.OWORK_2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OWORK_1BindingSource.Filter = "CONVERT([Дата_заказа], 'System.String') LIKE '*." + comboBox1.Text + ".*'" + "and [ФИО_специалиста] LIKE '" + textBox1.Text + "'";
            this.OWORK_2BindingSource.Filter = "CONVERT([Дата_оплаты], 'System.String') LIKE '*." + comboBox1.Text + ".*'" + "and [ФИО_специалиста] LIKE '" + textBox1.Text + "'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OWORK_1BindingSource.Filter = "";
            this.OWORK_2BindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Workers f1 = new Workers();
            f1.Show();
        }
    }
}
