﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            EditPayroll u = new EditPayroll();
            u.StartPosition = FormStartPosition.CenterParent;
            u.ShowDialog();
        }
    }
}
