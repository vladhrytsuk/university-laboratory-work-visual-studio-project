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
    public partial class UseRoomsMonth4 : Form
    {
        public UseRoomsMonth4()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth4". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth4TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth4);

            this.reportViewer1.RefreshReport();
        }
    }
}
