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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramm ab = new AboutProgramm();
            ab.Show();
        }

        private void отчетПоПредварительнымЗаказамМестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreOrderSeat f1 = new PreOrderSeat();
            f1.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients f2 = new Clients();
            f2.Show();
        }

        private void справочникЗалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room f3 = new Room();
            f3.Show();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table f4 = new Table();
            f4.Show();
        }

        private void списковСтоловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabless f5 = new Tabless();
            f5.Show();
        }

        private void журналУчетаПредварительныхЗаказовМестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order_Seat f6 = new Order_Seat();
            f6.Show();
        }

        private void журналПланЗанятостиМестРесторанаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plane_in_Restoran f7 = new Plane_in_Restoran();
            f7.Show();
        }

        private void списокЗанятыхСтоловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_Table f8 = new List_Table();
            f8.Show();
        }

        private void журналУчетаПосещенийКлиентамиРесторанаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients_in_Restoran f9 = new Clients_in_Restoran();
            f9.Show();
        }

        private void отчетПоИспользованиюЗаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseRoomsMonth f10 = new UseRoomsMonth();
            f10.Show();
        }

        private void отчетОДеятельностиРесторанаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurantActivities f11 = new RestaurantActivities();
            f11.Show();
        }

        private void резервноеКопированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
