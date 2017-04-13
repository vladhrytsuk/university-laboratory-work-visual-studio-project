using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Cosmetic
{
    public partial class ZNOY : Form
    {
        public ZNOY()
        {
            InitializeComponent();
        }

        private void zNOYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zNOYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admin_CosmeticDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ZNOY_Load(object sender, EventArgs e)
        {
            this.zNOYTableAdapter.Fill(this.admin_CosmeticDataSet.ZNOY);
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
