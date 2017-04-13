using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Restoran
{
    public partial class PreOrderSeatMonth1 : Form
    {
        public PreOrderSeatMonth1()
        {
            InitializeComponent();
        }

        private void PreOrderSeatMonth1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.PreOrderSeatMonth1". При необходимости она может быть перемещена или удалена.
            this.PreOrderSeatMonth1TableAdapter.Fill(this.Admin_RestoranDataSet1.PreOrderSeatMonth1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
