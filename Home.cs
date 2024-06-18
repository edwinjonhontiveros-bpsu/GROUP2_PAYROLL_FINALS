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
    public partial class Home : UserControl
    {
        private Color originalColor;
        public Home()
        {
            InitializeComponent();
            originalColor = otTb.ForeColor;
            originalColor = pesoOt.ForeColor;
            originalColor = lateTb.ForeColor;
            originalColor = pesoLate.ForeColor;




            this.otTb.ReadOnly = true;
            this.lateTb.ReadOnly = true;

            this.otCancelBtn.Visible = false;
            this.otSaveBtn.Visible = false;
            this.lateCancelBtn.Visible = false;
            this.lateSaveBtn.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void otEditBtn_Click(object sender, EventArgs e)
        {
            otTb.ReadOnly = false;
            otEditBtn.Visible = false;
            otCancelBtn.Visible = true;
            otSaveBtn.Visible = true;

            otTb.ForeColor = Color.FromArgb(1, 61, 90);
            pesoOt.ForeColor = Color.FromArgb(1, 61, 90);
        }

        private void otCancelBtn_Click(object sender, EventArgs e)
        {
            otTb.ReadOnly = true;
            otEditBtn.Visible = true;
            otCancelBtn.Visible = false;
            otSaveBtn.Visible = false;

            otTb.ForeColor = originalColor;
            pesoOt.ForeColor = originalColor;
        }

        private void otSaveBtn_Click(object sender, EventArgs e)
        {
            otTb.ReadOnly = true;
            otEditBtn.Visible = true;
            otCancelBtn.Visible = false;
            otSaveBtn.Visible = false;

            otTb.ForeColor = originalColor;
            pesoOt.ForeColor = originalColor;
        }

        private void lateEditBtn_Click(object sender, EventArgs e)
        {
            lateTb.ReadOnly = false;
            lateEditBtn.Visible = false;
            lateCancelBtn.Visible = true;
            lateSaveBtn.Visible = true;

            lateTb.ForeColor = Color.FromArgb(1, 61, 90);
            pesoLate.ForeColor = Color.FromArgb(1, 61, 90);
        }

        private void lateCancelBtn_Click(object sender, EventArgs e)
        {
            lateTb.ReadOnly = true;
            lateEditBtn.Visible = true;
            lateCancelBtn.Visible = false;
            lateSaveBtn.Visible = false;

            lateTb.ForeColor = originalColor;
            pesoLate.ForeColor = originalColor;
        }

        private void lateSaveBtn_Click(object sender, EventArgs e)
        {
            lateTb.ReadOnly = true;
            lateEditBtn.Visible = true;
            lateCancelBtn.Visible = false;
            lateSaveBtn.Visible = false;

            lateTb.ForeColor = originalColor;
            pesoLate.ForeColor = originalColor;
        }
    }
}
