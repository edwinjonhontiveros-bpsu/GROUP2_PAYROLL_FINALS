
namespace Payroll_System
{
    partial class Report
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.totalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noLate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 625);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstName,
            this.middleName,
            this.lastName,
            this.time,
            this.date,
            this.salaryPerDay,
            this.workingDays,
            this.total,
            this.bonus,
            this.noOT,
            this.totalOT,
            this.noLate,
            this.totalLate,
            this.noAbsent,
            this.deduction,
            this.totalSalary});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(10, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(948, 379);
            this.dataGridView1.TabIndex = 33;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Window;
            this.textBox12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.textBox12.Location = new System.Drawing.Point(74, 17);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(281, 25);
            this.textBox12.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.label18.Location = new System.Drawing.Point(10, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 18);
            this.label18.TabIndex = 36;
            this.label18.Text = "Search";
            // 
            // totalSalary
            // 
            this.totalSalary.HeaderText = "Total Salary";
            this.totalSalary.MinimumWidth = 6;
            this.totalSalary.Name = "totalSalary";
            this.totalSalary.Width = 117;
            // 
            // deduction
            // 
            this.deduction.HeaderText = "Total Deduction";
            this.deduction.MinimumWidth = 6;
            this.deduction.Name = "deduction";
            this.deduction.Width = 147;
            // 
            // noAbsent
            // 
            this.noAbsent.HeaderText = "Total for Absent";
            this.noAbsent.MinimumWidth = 6;
            this.noAbsent.Name = "noAbsent";
            this.noAbsent.Width = 146;
            // 
            // totalLate
            // 
            this.totalLate.HeaderText = "Total for Late";
            this.totalLate.MinimumWidth = 6;
            this.totalLate.Name = "totalLate";
            this.totalLate.Width = 129;
            // 
            // noLate
            // 
            this.noLate.HeaderText = "No of Late";
            this.noLate.MinimumWidth = 6;
            this.noLate.Name = "noLate";
            this.noLate.Width = 108;
            // 
            // totalOT
            // 
            this.totalOT.HeaderText = "Total for OT";
            this.totalOT.MinimumWidth = 6;
            this.totalOT.Name = "totalOT";
            this.totalOT.Width = 120;
            // 
            // noOT
            // 
            this.noOT.HeaderText = "No of OT";
            this.noOT.MinimumWidth = 6;
            this.noOT.Name = "noOT";
            this.noOT.Width = 99;
            // 
            // bonus
            // 
            this.bonus.HeaderText = "Bonus";
            this.bonus.MinimumWidth = 6;
            this.bonus.Name = "bonus";
            this.bonus.Width = 81;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 70;
            // 
            // workingDays
            // 
            this.workingDays.HeaderText = "No of Working Day(s)";
            this.workingDays.MinimumWidth = 6;
            this.workingDays.Name = "workingDays";
            this.workingDays.Width = 183;
            // 
            // salaryPerDay
            // 
            this.salaryPerDay.HeaderText = "Salary Per Day";
            this.salaryPerDay.MinimumWidth = 6;
            this.salaryPerDay.Name = "salaryPerDay";
            this.salaryPerDay.Width = 137;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 68;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.Width = 70;
            // 
            // lastName
            // 
            this.lastName.FillWeight = 131.4658F;
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.Width = 109;
            // 
            // middleName
            // 
            this.middleName.FillWeight = 167.8778F;
            this.middleName.HeaderText = "Middle Name";
            this.middleName.MinimumWidth = 6;
            this.middleName.Name = "middleName";
            this.middleName.Width = 127;
            // 
            // firstName
            // 
            this.firstName.FillWeight = 158.7889F;
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.Width = 111;
            // 
            // ID
            // 
            this.ID.FillWeight = 74.07407F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(581, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 47);
            this.button4.TabIndex = 55;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(133)))), ((int)(((byte)(122)))));
            this.button1.Location = new System.Drawing.Point(709, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 54;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(133)))), ((int)(((byte)(122)))));
            this.updateBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.updateBtn.Location = new System.Drawing.Point(837, 458);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(122, 47);
            this.updateBtn.TabIndex = 53;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(970, 625);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn noLate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLate;
        private System.Windows.Forms.DataGridViewTextBoxColumn noAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn deduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalary;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button updateBtn;
    }
}
