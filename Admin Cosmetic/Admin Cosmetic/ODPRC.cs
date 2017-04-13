﻿using System;
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
    public partial class ODPRC : Form
    {
        public ODPRC()
        {
            InitializeComponent();
        }

        private void ODPRC_Load(object sender, EventArgs e)
        {
           this.ODPRCTableAdapter.Fill(this.Admin_CosmeticDataSet.ODPRC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ODPRCBindingSource.Filter = "CONVERT([Дата_оплаты], 'System.String') LIKE '*." + comboBox1.Text + ".*'";
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ODPRCBindingSource.Filter = "";
            this.reportViewer1.RefreshReport();
        }
    }
}
