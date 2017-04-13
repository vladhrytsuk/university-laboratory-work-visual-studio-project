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
    public partial class ActivityWarehouseMonth6 : Form
    {
        public ActivityWarehouseMonth6()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth6_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth6_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth6_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth6_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth6_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth6_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth6". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth6TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth6);

            this.reportViewer1.RefreshReport();
        }
    }
}
