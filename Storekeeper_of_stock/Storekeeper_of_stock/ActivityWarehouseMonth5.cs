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
    public partial class ActivityWarehouseMonth5 : Form
    {
        public ActivityWarehouseMonth5()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth5_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth5_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth5_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth5_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth5_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth5_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth5". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth5TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth5);

            this.reportViewer1.RefreshReport();
        }
    }
}
