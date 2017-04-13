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
    public partial class ActivityWarehouseMonth8 : Form
    {
        public ActivityWarehouseMonth8()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth8_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth8_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth8_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth8_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth8_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth8_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth8". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth8TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth8);

            this.reportViewer1.RefreshReport();
        }
    }
}
