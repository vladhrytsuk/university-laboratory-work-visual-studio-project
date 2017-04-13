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
    public partial class Consumer : Form
    {
        public Consumer()
        {
            InitializeComponent();
        }

        private void consumerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consumerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storekeeper_of_stockDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Consumer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storekeeper_of_stockDataSet.Consumer". При необходимости она может быть перемещена или удалена.
            this.consumerTableAdapter.Fill(this.storekeeper_of_stockDataSet.Consumer);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись добавлена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись удалена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
