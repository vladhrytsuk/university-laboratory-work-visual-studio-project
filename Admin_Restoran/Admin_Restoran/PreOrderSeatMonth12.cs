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
    public partial class PreOrderSeatMonth12 : Form
    {
        public PreOrderSeatMonth12()
        {
            InitializeComponent();
        }

        private void PreOrderSeatMonth12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.PreOrderSeatMonth12". При необходимости она может быть перемещена или удалена.
            this.PreOrderSeatMonth12TableAdapter.Fill(this.Admin_RestoranDataSet1.PreOrderSeatMonth12);

            this.reportViewer1.RefreshReport();
        }
    }
}
