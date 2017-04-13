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
    public partial class RestaurantActivities : Form
    {
        public RestaurantActivities()
        {
            InitializeComponent();
        }

        private void RestaurantActivities_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Admin_RestoranDataSet2.RestaurantActivities". При необходимости она может быть перемещена или удалена.
            this.RestaurantActivitiesTableAdapter.Fill(this.Admin_RestoranDataSet2.RestaurantActivities);

            this.reportViewer1.RefreshReport();
        }
    }
}
