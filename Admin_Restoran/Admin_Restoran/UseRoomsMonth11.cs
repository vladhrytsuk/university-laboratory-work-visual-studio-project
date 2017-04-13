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
    public partial class UseRoomsMonth11 : Form
    {
        public UseRoomsMonth11()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth11". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth11TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth11);

            this.reportViewer1.RefreshReport();
        }
    }
}
