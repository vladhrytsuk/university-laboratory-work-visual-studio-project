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
    public partial class ActivityWarehouseMonth3 : Form
    {
        public ActivityWarehouseMonth3()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth3_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth3_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth3_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth3_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth3_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth3_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth3". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth3TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth3);

            this.reportViewer1.RefreshReport();
        }
    }
}
