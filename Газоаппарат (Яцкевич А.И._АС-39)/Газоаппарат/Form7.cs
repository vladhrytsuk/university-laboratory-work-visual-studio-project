using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void выполнение_работBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выполнение_работBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Выполнение_работ". При необходимости она может быть перемещена или удалена.
            this.выполнение_работTableAdapter.Fill(this.брестГазDataSet.Выполнение_работ);

        }
    }
}
