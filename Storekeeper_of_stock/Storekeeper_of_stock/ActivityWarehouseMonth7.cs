﻿using System;
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
    public partial class ActivityWarehouseMonth7 : Form
    {
        public ActivityWarehouseMonth7()
        {
            InitializeComponent();
        }

        private void ActivityWarehouseMonth7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth7_1". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth7_1TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth7_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth7_2". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth7_2TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth7_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ActivityWarehouseMonth7". При необходимости она может быть перемещена или удалена.
            this.ActivityWarehouseMonth7TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ActivityWarehouseMonth7);

            this.reportViewer1.RefreshReport();
        }
    }
}
