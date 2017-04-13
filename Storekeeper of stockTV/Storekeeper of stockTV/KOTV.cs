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
    public partial class KOTV : Form
    {
        public KOTV()
        {
            InitializeComponent();
        }

        private void kOTVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kOTVBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storekeeper_of_stockTVDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KOTV_Load(object sender, EventArgs e)
        {
             this.kOTVTableAdapter.Fill(this.storekeeper_of_stockTVDataSet.KOTV);
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
