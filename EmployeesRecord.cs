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
    public partial class EmployeesRecord : UserControl
    {
        public EmployeesRecord()
        {
            InitializeComponent();
        }


        private void AddControls(UserControl F)
        {
            EmployeesPanel2.Controls.Clear();
            F.Dock = DockStyle.Fill;
            EmployeesPanel2.Controls.Add(F);
            F.BringToFront();
        }
        private void AddEmpBtn_Click_1(object sender, EventArgs e)
        {
            AddControls(new Employees());
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployee u = new UpdateEmployee();
            u.StartPosition = FormStartPosition.CenterParent;
            u.ShowDialog();
        }
    }
}
