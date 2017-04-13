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
    public partial class Produсts : Form
    {
        public Produсts()
        {
            InitializeComponent();
        }

        private void produсtsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produсtsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storekeeper_of_stockDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Produсts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storekeeper_of_stockDataSet.Produсts". При необходимости она может быть перемещена или удалена.
            this.produсtsTableAdapter.Fill(this.storekeeper_of_stockDataSet.Produсts);

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
