using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home homeControl = new Home();

            homeControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(homeControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void AddControls(UserControl F)
        {
            mainPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(F);
            F.BringToFront();
        }
        
        private void employeesBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Employees());
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Payroll());
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Report());
        }
    }
}
