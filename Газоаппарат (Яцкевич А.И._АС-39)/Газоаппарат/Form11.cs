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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void карточка_складского_учетаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.карточка_складского_учетаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.брестГазDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "брестГазDataSet.Карточка_складского_учета". При необходимости она может быть перемещена или удалена.
            this.карточка_складского_учетаTableAdapter.Fill(this.брестГазDataSet.Карточка_складского_учета);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
