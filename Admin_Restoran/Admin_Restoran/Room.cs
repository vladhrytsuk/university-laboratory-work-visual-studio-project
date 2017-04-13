using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Restoran
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.admin_RestoranDataSet1);
            MessageBox.Show("Запись сохранена", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "admin_RestoranDataSet1.Room". При необходимости она может быть перемещена или удалена.
            this.roomTableAdapter.Fill(this.admin_RestoranDataSet1.Room);

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
