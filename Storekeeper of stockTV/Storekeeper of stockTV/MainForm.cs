using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storekeeper_of_stockTV
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

        private void справочникКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients f1 = new Clients();
            f1.Show();
        }

        private void справочникТелевизорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TV f2 = new TV();
            f2.Show();
        }

        private void српавочникПоставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers f3 = new Suppliers();
            f3.Show();
        }

        private void справочникСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers f4 = new Workers();
            f4.Show();
        }

        private void отчётПоТТНзаМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OTTN f5 = new OTTN();
            f5.Show();
        }

        private void тТНToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTN f6 = new TTN();
            f6.Show();
        }

        private void нВПToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NVP f7 = new NVP();
            f7.Show();
        }

        private void кОТВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KOTV f8 = new KOTV();
            f8.Show();
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OTV f9 = new OTV();
            f9.Show();
        }

        private void отчётОДеятельностиСкладазаМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OActivityWarehouse f10 = new OActivityWarehouse();
            f10.Show();
        }
    }
}
