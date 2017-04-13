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
    public partial class UseRoomsMonth10 : Form
    {
        public UseRoomsMonth10()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth10". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth10TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth10);

            this.reportViewer1.RefreshReport();
        }
    }
}
