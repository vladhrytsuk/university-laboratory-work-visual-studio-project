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
    public partial class ActivityWarehouseMonth2 : Form
    {
        public ActivityWarehouseMonth2()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth2_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth2_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth2_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth2_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth2_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth2_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth2);

            this.reportViewer1.RefreshReport();
        }
    }
}
