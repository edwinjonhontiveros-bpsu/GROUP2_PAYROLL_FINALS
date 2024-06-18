using System;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();

            home.Show();
            this.Hide();
        }
    }
}
