﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Газоаппарат
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void список_работBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.список_работBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Список_работ". При необходимости она может быть перемещена или удалена.
            this.список_работTableAdapter.Fill(this.брестГазDataSet.Список_работ);

        }
    }
}
