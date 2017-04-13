using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storekeeper_of_stock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spravka f1 = new Spravka();
            f1.Show();
        }

        private void отчетПоДППToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DPP f2 = new DPP();
            f2.Show();
        }

        private void отчетОДеятельностиСкладаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OActivityWarehouse f3 = new OActivityWarehouse();
            f3.Show();
        }

        private void сЗАОБрестскийЗаводРастетильныхМаселToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers f4 = new Suppliers();
            f4.Show();
        }

        private void справочникПоставщикиПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produсts f5 = new Produсts();
            f5.Show();
        }

        private void справочникПоставщикиПродукцииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Workers f6 = new Workers();
            f6.Show();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consumer f7 = new Consumer();
            f7.Show();
        }

        private void договорНаПоставкуПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сontract f8 = new Сontract();
            f8.Show();
        }

        private void ноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сontract_List_Products f9 = new Сontract_List_Products();
            f9.Show();
        }

        private void накладнаяНаВнутренееПеремещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NVP f10 = new NVP();
            f10.Show();
        }

        private void карточкаСкладногоУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KSY f11 = new KSY();
            f11.Show();
        }

        private void отчетПоПроизведеннойПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OManufacturedProducts f12 = new OManufacturedProducts();
            f12.Show();
        }
    }
}
