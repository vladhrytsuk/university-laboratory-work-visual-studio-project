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
    public partial class PreOrderSeatMonth9 : Form
    {
        public PreOrderSeatMonth9()
        {
            InitializeComponent();
        }

        private void PreOrderSeatMonth9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.PreOrderSeatMonth9". При необходимости она может быть перемещена или удалена.
            this.PreOrderSeatMonth9TableAdapter.Fill(this.Admin_RestoranDataSet1.PreOrderSeatMonth9);

            this.reportViewer1.RefreshReport();
        }
    }
}
