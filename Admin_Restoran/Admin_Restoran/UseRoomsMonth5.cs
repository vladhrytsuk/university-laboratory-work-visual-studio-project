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
    public partial class UseRoomsMonth5 : Form
    {
        public UseRoomsMonth5()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth5". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth5TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth5);

            this.reportViewer1.RefreshReport();
        }
    }
}
