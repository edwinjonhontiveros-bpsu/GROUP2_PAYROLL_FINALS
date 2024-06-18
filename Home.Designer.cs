
namespace Payroll_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lateSaveBtn = new System.Windows.Forms.Button();
            this.lateCancelBtn = new System.Windows.Forms.Button();
            this.lateEditBtn = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.otCancelBtn = new System.Windows.Forms.Button();
            this.otSaveBtn = new System.Windows.Forms.Button();
            this.otEditBtn = new System.Windows.Forms.Button();
            this.pesoOt = new System.Windows.Forms.Label();
            this.otTb = new System.Windows.Forms.TextBox();
            this.lateTb = new System.Windows.Forms.TextBox();
            this.pesoLate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 625);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(502, 319);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 68);
            this.panel7.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(95, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Deduction per Late";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(68, 322);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(401, 68);
            this.panel11.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(95, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Overtime per Hour";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel8.Controls.Add(this.lateTb);
            this.panel8.Controls.Add(this.pesoLate);
            this.panel8.Controls.Add(this.lateSaveBtn);
            this.panel8.Controls.Add(this.lateCancelBtn);
            this.panel8.Controls.Add(this.lateEditBtn);
            this.panel8.Location = new System.Drawing.Point(502, 316);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(401, 259);
            this.panel8.TabIndex = 41;
            // 
            // lateSaveBtn
            // 
            this.lateSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(133)))), ((int)(((byte)(122)))));
            this.lateSaveBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateSaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.lateSaveBtn.Location = new System.Drawing.Point(269, 203);
            this.lateSaveBtn.Name = "lateSaveBtn";
            this.lateSaveBtn.Size = new System.Drawing.Size(122, 47);
            this.lateSaveBtn.TabIndex = 52;
            this.lateSaveBtn.Text = "Save";
            this.lateSaveBtn.UseVisualStyleBackColor = false;
            this.lateSaveBtn.Click += new System.EventHandler(this.lateSaveBtn_Click);
            // 
            // lateCancelBtn
            // 
            this.lateCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lateCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.lateCancelBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateCancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.lateCancelBtn.Location = new System.Drawing.Point(10, 203);
            this.lateCancelBtn.Name = "lateCancelBtn";
            this.lateCancelBtn.Size = new System.Drawing.Size(122, 47);
            this.lateCancelBtn.TabIndex = 51;
            this.lateCancelBtn.Text = "Cancel";
            this.lateCancelBtn.UseVisualStyleBackColor = false;
            this.lateCancelBtn.Click += new System.EventHandler(this.lateCancelBtn_Click);
            // 
            // lateEditBtn
            // 
            this.lateEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.lateEditBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.lateEditBtn.Location = new System.Drawing.Point(140, 203);
            this.lateEditBtn.Name = "lateEditBtn";
            this.lateEditBtn.Size = new System.Drawing.Size(122, 47);
            this.lateEditBtn.TabIndex = 50;
            this.lateEditBtn.Text = "Edit";
            this.lateEditBtn.UseVisualStyleBackColor = false;
            this.lateEditBtn.Click += new System.EventHandler(this.lateEditBtn_Click);
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel12.Controls.Add(this.otTb);
            this.panel12.Controls.Add(this.pesoOt);
            this.panel12.Controls.Add(this.otSaveBtn);
            this.panel12.Controls.Add(this.otCancelBtn);
            this.panel12.Controls.Add(this.otEditBtn);
            this.panel12.Location = new System.Drawing.Point(68, 319);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(401, 259);
            this.panel12.TabIndex = 37;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(502, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(401, 68);
            this.panel9.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(135, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bonus Paid";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(502, 47);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(401, 214);
            this.panel10.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 24.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.label7.Location = new System.Drawing.Point(106, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 58);
            this.label7.TabIndex = 1;
            this.label7.Text = "000000";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(68, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 68);
            this.panel6.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(135, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Salary Paid";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(68, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 214);
            this.panel5.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 24.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(106, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 58);
            this.label4.TabIndex = 1;
            this.label4.Text = "000000";
            // 
            // otCancelBtn
            // 
            this.otCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.otCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.otCancelBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otCancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.otCancelBtn.Location = new System.Drawing.Point(10, 203);
            this.otCancelBtn.Name = "otCancelBtn";
            this.otCancelBtn.Size = new System.Drawing.Size(122, 47);
            this.otCancelBtn.TabIndex = 51;
            this.otCancelBtn.Text = "Cancel";
            this.otCancelBtn.UseVisualStyleBackColor = false;
            this.otCancelBtn.Click += new System.EventHandler(this.otCancelBtn_Click);
            // 
            // otSaveBtn
            // 
            this.otSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(133)))), ((int)(((byte)(122)))));
            this.otSaveBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otSaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.otSaveBtn.Location = new System.Drawing.Point(269, 203);
            this.otSaveBtn.Name = "otSaveBtn";
            this.otSaveBtn.Size = new System.Drawing.Size(122, 47);
            this.otSaveBtn.TabIndex = 52;
            this.otSaveBtn.Text = "Save";
            this.otSaveBtn.UseVisualStyleBackColor = false;
            this.otSaveBtn.Click += new System.EventHandler(this.otSaveBtn_Click);
            // 
            // otEditBtn
            // 
            this.otEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.otEditBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.otEditBtn.Location = new System.Drawing.Point(140, 203);
            this.otEditBtn.Name = "otEditBtn";
            this.otEditBtn.Size = new System.Drawing.Size(122, 47);
            this.otEditBtn.TabIndex = 50;
            this.otEditBtn.Text = "Edit";
            this.otEditBtn.UseVisualStyleBackColor = false;
            this.otEditBtn.Click += new System.EventHandler(this.otEditBtn_Click);
            // 
            // pesoOt
            // 
            this.pesoOt.AutoSize = true;
            this.pesoOt.Font = new System.Drawing.Font("Arial Black", 24.2F, System.Drawing.FontStyle.Bold);
            this.pesoOt.ForeColor = System.Drawing.Color.DimGray;
            this.pesoOt.Location = new System.Drawing.Point(91, 111);
            this.pesoOt.Name = "pesoOt";
            this.pesoOt.Size = new System.Drawing.Size(59, 58);
            this.pesoOt.TabIndex = 53;
            this.pesoOt.Text = "₱";
            this.pesoOt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otTb
            // 
            this.otTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.otTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otTb.Font = new System.Drawing.Font("Arial Black", 24.2F, System.Drawing.FontStyle.Bold);
            this.otTb.ForeColor = System.Drawing.Color.DimGray;
            this.otTb.HideSelection = false;
            this.otTb.Location = new System.Drawing.Point(143, 112);
            this.otTb.Name = "otTb";
            this.otTb.Size = new System.Drawing.Size(167, 57);
            this.otTb.TabIndex = 54;
            this.otTb.Text = "110.00";
            // 
            // lateTb
            // 
            this.lateTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.lateTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lateTb.Font = new System.Drawing.Font("Arial Black", 24.2F, System.Drawing.FontStyle.Bold);
            this.lateTb.ForeColor = System.Drawing.Color.DimGray;
            this.lateTb.HideSelection = false;
            this.lateTb.Location = new System.Drawing.Point(147, 114);
            this.lateTb.Name = "lateTb";
            this.lateTb.Size = new System.Drawing.Size(167, 57);
            this.lateTb.TabIndex = 56;
            this.lateTb.Text = "60.00";
            // 
            // pesoLate
            // 
            this.pesoLate.AutoSize = true;
            this.pesoLate.Font = new System.Drawing.Font("Arial Black", 24.2F, System.Drawing.FontStyle.Bold);
            this.pesoLate.ForeColor = System.Drawing.Color.DimGray;
            this.pesoLate.Location = new System.Drawing.Point(95, 113);
            this.pesoLate.Name = "pesoLate";
            this.pesoLate.Size = new System.Drawing.Size(59, 58);
            this.pesoLate.TabIndex = 55;
            this.pesoLate.Text = "₱";
            this.pesoLate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(970, 625);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button lateSaveBtn;
        private System.Windows.Forms.Button lateCancelBtn;
        private System.Windows.Forms.Button lateEditBtn;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lateTb;
        private System.Windows.Forms.Label pesoLate;
        private System.Windows.Forms.TextBox otTb;
        private System.Windows.Forms.Label pesoOt;
        private System.Windows.Forms.Button otSaveBtn;
        private System.Windows.Forms.Button otCancelBtn;
        private System.Windows.Forms.Button otEditBtn;
    }
}
