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
    public partial class OManufacturedProducts : Form
    {
        public OManufacturedProducts()
        {
            InitializeComponent();
        }

        private void OManufacturedProducts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.OManufacturedProducts". При необходимости она может быть перемещена или удалена.
            this.OManufacturedProductsTableAdapter.Fill(this.Storekeeper_of_stockDataSet.OManufacturedProducts);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OManufacturedProductsBindingSource.Filter = "CONVERT([Дата_заключения], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.OManufacturedProductsBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
