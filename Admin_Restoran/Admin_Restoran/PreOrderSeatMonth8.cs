using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Restoran
{
    public partial class PreOrderSeatMonth8 : Form
    {
        public PreOrderSeatMonth8()
        {
            InitializeComponent();
        }

        private void PreOrderSeatMonth8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.PreOrderSeatMonth8". При необходимости она может быть перемещена или удалена.
            this.PreOrderSeatMonth8TableAdapter.Fill(this.Admin_RestoranDataSet1.PreOrderSeatMonth8);

            this.reportViewer1.RefreshReport();
        }
    }
}
