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
    public partial class ActivityWarehouseMonth9 : Form
    {
        public ActivityWarehouseMonth9()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth9_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth9_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth9_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth9_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth9_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth9_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth9". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth9TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth9);

            this.reportViewer1.RefreshReport();
        }
    }
}
