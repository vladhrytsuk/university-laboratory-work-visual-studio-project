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
    public partial class DPRC : Form
    {
        public DPRC()
        {
            InitializeComponent();
        }

        private void dPRCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dPRCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admin_CosmeticDataSet);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DPRC_Load(object sender, EventArgs e)
        {
            this.dPRCTableAdapter.Fill(this.admin_CosmeticDataSet.DPRC);
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
