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
    public partial class Employees : UserControl
    {
        
        public Employees()
        {
            InitializeComponent();
            
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
        private void AddControls(UserControl F)
        {
            EmployeesPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            EmployeesPanel.Controls.Add(F);
            F.BringToFront();
        }

        private void empRecordBtn_Click(object sender, EventArgs e)
        {
            AddControls(new EmployeesRecord());
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            dob.ForeColor = Color.FromArgb(1, 61, 90);
        }
    }
}
