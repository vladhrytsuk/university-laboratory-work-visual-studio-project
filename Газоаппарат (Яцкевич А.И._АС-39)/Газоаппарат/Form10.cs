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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void накладная_на_внутреннее_перемещение_оборудованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.накладная_на_внутреннее_перемещение_оборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Накладная_на_внутреннее_перемещение_оборудования". При необходимости она может быть перемещена или удалена.
            this.накладная_на_внутреннее_перемещение_оборудованияTableAdapter.Fill(this.брестГазDataSet.Накладная_на_внутреннее_перемещение_оборудования);

        }

       
    }
}
