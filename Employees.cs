using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Payroll_System
{
    public partial class Employees : UserControl
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GROUP2_PAYROLL_FINALS.accdb");

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

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into employeeList(lname, fname, mname, address, birthdate, gender, marital, tel, mobile, email, joindate, position, basicrate)Values('" + textBox4.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + dob.Text + "','" + GenderCb.Text + "','" + StatusCb.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + textBox9.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            con.Close();
        }
    }
}
