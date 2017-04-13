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
    public partial class UseRoomsMonth1 : Form
    {
        public UseRoomsMonth1()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth1". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth1TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth1);

            this.reportViewer1.RefreshReport();
        }
    }
}
