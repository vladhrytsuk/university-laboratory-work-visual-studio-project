using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storekeeper_of_stockTV
{
    public partial class TV : Form
    {
        public TV()
        {
            InitializeComponent();
        }

        private void tVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storekeeper_of_stockTVDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TV_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storekeeper_of_stockTVDataSet.TV". При необходимости она может быть перемещена или удалена.
            this.tVTableAdapter.Fill(this.storekeeper_of_stockTVDataSet.TV);

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
