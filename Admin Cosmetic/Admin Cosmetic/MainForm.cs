using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Cosmetic
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

        private void справочникСотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workers f2 = new Workers();
            f2.Show();
        }

        private void справочникКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients f3 = new Clients();
            f3.Show();
        }

        private void справочникКаталогУслгToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cotalog f4 = new Cotalog();
            f4.Show();
        }

        private void справочникТарифыНаУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tariphs f5 = new Tariphs();
            f5.Show();
        }

        private void справочникКосметическиеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cosmetic f6 = new Cosmetic();
            f6.Show();
        }

        private void заказНаОказаниеУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZNOY f7 = new ZNOY();
            f7.Show();
        }

        private void дневнойПланРаботыСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DPRC f8 = new DPRC();
            f8.Show();
        }

        private void квитанцияНаОплатуУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KOTV f9 = new KOTV();
            f9.Show();
        }

        private void отчётПоВыполненнымЗаказамзаМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ODPRC f10 = new ODPRC();
            f10.Show();
        }

        private void отчётПоСотрудникузаМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OWORK f11 = new OWORK();
            f11.Show();
        }

        private void отчётПоВидамУслугзаМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OUSLUG f12 = new OUSLUG();
            f12.Show();
        }
    }
}
