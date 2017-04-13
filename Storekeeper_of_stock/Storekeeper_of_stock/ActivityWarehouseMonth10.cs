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
    public partial class ActivityWarehouseMonth10 : Form
    {
        public ActivityWarehouseMonth10()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth10_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth10_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth10_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth10_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth10_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth10_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth10". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth10TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth10);

            this.reportViewer1.RefreshReport();
        }
    }
}
