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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "БрестГазDataSet.Отчет_оборуд". При необходимости она может быть перемещена или удалена.
            this.Отчет_оборудTableAdapter.Fill(this.БрестГазDataSet.Отчет_оборуд);

            this.reportViewer1.RefreshReport();
        }
    }
}
