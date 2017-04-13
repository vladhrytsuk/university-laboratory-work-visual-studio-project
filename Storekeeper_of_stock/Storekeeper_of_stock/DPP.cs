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
    public partial class DPP : Form
    {
        public DPP()
        {
            InitializeComponent();
        }

        private void DPP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.DPP". При необходимости она может быть перемещена или удалена.
            this.DPPTableAdapter.Fill(this.Storekeeper_of_stockDataSet.DPP);

            this.reportViewer1.RefreshReport();
        }
    }
}
