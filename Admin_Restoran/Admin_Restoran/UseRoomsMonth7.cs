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
    public partial class UseRoomsMonth7 : Form
    {
        public UseRoomsMonth7()
        {
            InitializeComponent();
        }

        private void UseRoomsMonth7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet1.UseRoomsMonth7". При необходимости она может быть перемещена или удалена.
            this.UseRoomsMonth7TableAdapter.Fill(this.Admin_RestoranDataSet1.UseRoomsMonth7);

            this.reportViewer1.RefreshReport();
        }
    }
}
