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
    public partial class UseRoomsMonth6 : Form
    {
        public UseRoomsMonth6()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth6". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth6TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth6);

            this.reportViewer1.RefreshReport();
        }
    }
}
