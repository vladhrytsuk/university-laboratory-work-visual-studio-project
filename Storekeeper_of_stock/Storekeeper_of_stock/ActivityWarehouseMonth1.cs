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
    public partial class ActivityWarehouseMonth1 : Form
    {
        public ActivityWarehouseMonth1()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth1_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth1_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth1_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth1_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth1_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth1_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth1);

            this.reportViewer1.RefreshReport();
        }
    }
}
