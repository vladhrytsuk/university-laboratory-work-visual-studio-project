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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void виды_работBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_работBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Виды_работ". При необходимости она может быть перемещена или удалена.
            this.виды_работTableAdapter.Fill(this.брестГазDataSet.Виды_работ);

        }
    }
}
