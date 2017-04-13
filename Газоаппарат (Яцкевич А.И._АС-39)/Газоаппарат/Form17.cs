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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "БрестГазDataSet.КСУ". При необходимости она может быть перемещена или удалена.
            this.КСУTableAdapter.Fill(this.БрестГазDataSet.КСУ);

            this.reportViewer1.RefreshReport();
        }
    }
}
