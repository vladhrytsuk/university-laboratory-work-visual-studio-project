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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "БрестГазDataSet.Журнал". При необходимости она может быть перемещена или удалена.
            this.ЖурналTableAdapter.Fill(this.БрестГазDataSet.Журнал);

            this.reportViewer1.RefreshReport();
        }
    }
}
