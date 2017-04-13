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
    public partial class PreOrderSeatMonth4 : Form
    {
        public PreOrderSeatMonth4()
        {
            InitializeComponent();
        }

        private void PreOrderSeatMonth4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.PreOrderSeatMonth4". При необходимости она может быть перемещена или удалена.
            this.PreOrderSeatMonth4TableAdapter.Fill(this.Admin_RestoranDataSet1.PreOrderSeatMonth4);

            this.reportViewer1.RefreshReport();
        }
    }
}
