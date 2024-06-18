using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Payroll_System
{
    public partial class Employees : UserControl
    {

        private OleDbConnection cn = new OleDbConnection();

        public Employees()
        {
            InitializeComponent();

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = GROUP2_PAYROLL_FINALS.accdb; Persist Security Info = False;";
                cn.Open();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
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
            try
            {

                cn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;

                string q = "INSERT INTO employeeList (lname, fname, mname, address, birthdate, gender, marital, tel, mobile, email, joindate, position, basicrate) VALUES (@LName, @FName, @MName, @Addr, @Bday, @Gndr, @Mrtl, @Tel, @Mob, @Eml, @Joindt, @Pos, @BRate)";

                cmd.Parameters.AddWithValue("@LName", OleDbType.VarChar).Value = textBox4.Text;
                cmd.Parameters.AddWithValue("@FName", OleDbType.VarChar).Value = textBox2.Text;
                cmd.Parameters.AddWithValue("@MName", OleDbType.VarChar).Value = textBox3.Text;
                cmd.Parameters.AddWithValue("@Addr", OleDbType.LongVarChar).Value = textBox5.Text;
                cmd.Parameters.AddWithValue("@Bday", OleDbType.Date).Value = dob.Value;
                cmd.Parameters.AddWithValue("@Gndr", OleDbType.VarChar).Value = GenderCb.Text;
                cmd.Parameters.AddWithValue("@Mrtl", OleDbType.VarChar).Value = StatusCb.Text;
                cmd.Parameters.AddWithValue("@Tel", OleDbType.VarChar).Value = textBox8.Text;
                cmd.Parameters.AddWithValue("@Mob", OleDbType.VarChar).Value = textBox7.Text;
                cmd.Parameters.AddWithValue("@Eml", OleDbType.VarChar).Value = textBox6.Text;
                cmd.Parameters.AddWithValue("@Joindt", OleDbType.Date).Value = dateTimePicker1.Value;
                cmd.Parameters.AddWithValue("@Pos", OleDbType.VarChar).Value = comboBox2.Text;
                cmd.Parameters.AddWithValue("@BRate", OleDbType.Double).Value = textBox9.Text;

                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Employee record has been saved.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
