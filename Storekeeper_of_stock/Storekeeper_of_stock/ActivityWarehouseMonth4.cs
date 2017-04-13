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
    public partial class ActivityWarehouseMonth4 : Form
    {
        public ActivityWarehouseMonth4()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth4_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth4_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth4_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth4_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth4_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth4_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth4". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth4TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth4);

            this.reportViewer1.RefreshReport();
        }
    }
}
