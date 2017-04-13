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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void заявкаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Заявка". При необходимости она может быть перемещена или удалена.
            this.заявкаTableAdapter.Fill(this.брестГазDataSet.Заявка);

        }
    }
}
