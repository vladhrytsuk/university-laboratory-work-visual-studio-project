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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void журнал_учета_заявок_на_ремонт_оборудованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.журнал_учета_заявок_на_ремонт_оборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Журнал_учета_заявок_на_ремонт_оборудования". При необходимости она может быть перемещена или удалена.
            this.журнал_учета_заявок_на_ремонт_оборудованияTableAdapter.Fill(this.брестГазDataSet.Журнал_учета_заявок_на_ремонт_оборудования);

        }
    }
}
