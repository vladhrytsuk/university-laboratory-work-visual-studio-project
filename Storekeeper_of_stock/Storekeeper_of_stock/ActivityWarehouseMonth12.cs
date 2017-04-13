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
    public partial class ActivityWarehouseMonth12: Form
    {
        public ActivityWarehouseMonth12()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth12_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth12_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth12_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth12_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth12_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth12_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth12". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth12TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth12);

            this.reportViewer1.RefreshReport();
        }
    }
}
