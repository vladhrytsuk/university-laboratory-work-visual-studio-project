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
    public partial class ActivityWarehouseMonth11 : Form
    {
        public ActivityWarehouseMonth11()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth11_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth11_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth11_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth11_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth11_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth11_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth11". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth11TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth11);

            this.reportViewer1.RefreshReport();
        }
    }
}
