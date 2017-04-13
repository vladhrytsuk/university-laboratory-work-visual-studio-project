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
    public partial class Сontract_List_Products : Form
    {
        public Сontract_List_Products()
        {
            InitializeComponent();
        }

        private void сontract_List_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сontract_List_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storekeeper_of_stockDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Сontract_List_Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storekeeper_of_stockDataSet.Сontract_List_Products". При необходимости она может быть перемещена или удалена.
            this.сontract_List_ProductsTableAdapter.Fill(this.storekeeper_of_stockDataSet.Сontract_List_Products);

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
