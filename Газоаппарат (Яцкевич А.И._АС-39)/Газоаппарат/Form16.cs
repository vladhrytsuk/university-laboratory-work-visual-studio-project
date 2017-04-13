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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "БрестГазDataSet.НЗ". При необходимости она может быть перемещена или удалена.
            this.НЗTableAdapter.Fill(this.БрестГазDataSet.НЗ);

            this.reportViewer1.RefreshReport();
        }
    }
}
