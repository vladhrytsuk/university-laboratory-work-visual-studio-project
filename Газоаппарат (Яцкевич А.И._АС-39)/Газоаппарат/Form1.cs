using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Газоаппарат
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     

        private void накладнаяНаВнутреннееПеремещениеОборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.Show();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void поставщикиОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

        private void видыРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
        }

        private void выполнениеРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
        }

        private void списокРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.Show();
        }

        private void заявкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.Show();
        }

        private void карточкаСкладскогоУчетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 fr11 = new Form11();
            fr11.Show();
        }

        private void журналУчетаЗаявокНаРемонтОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 fr12 = new Form12();
            fr12.Show();
        }

        private void нарядЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 fr13 = new Form13();
            fr13.Show();
        }

        private void отчетПоОборудованиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 fr14 = new Form14();
            fr14.Show();
        }

        private void отчетПоЖУЗРОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 fr15 = new Form15();
            fr15.Show();
        }

        private void отчетПоНарядЗаданиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 fr16 = new Form16();
            fr16.Show();
        }

        private void отчетПоКСУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 fr17 = new Form17();
            fr17.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }
    }
}
