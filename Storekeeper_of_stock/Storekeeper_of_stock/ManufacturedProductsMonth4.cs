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
    public partial class ManufacturedProductsMonth4 : Form
    {
        public ManufacturedProductsMonth4()
        {
            InitializeComponent();
        }

        private void ManufacturedProductsMonth4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Storekeeper_of_stockDataSet.ManufacturedProductsMonth4". При необходимости она может быть перемещена или удалена.
            this.ManufacturedProductsMonth4TableAdapter.Fill(this.Storekeeper_of_stockDataSet.ManufacturedProductsMonth4);

            this.reportViewer1.RefreshReport();
        }
    }
}
