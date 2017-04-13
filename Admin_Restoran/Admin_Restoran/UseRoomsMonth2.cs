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
    public partial class UseRoomsMonth2 : Form
    {
        public UseRoomsMonth2()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth2". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth2TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth2);

            this.reportViewer1.RefreshReport();
        }
    }
}
