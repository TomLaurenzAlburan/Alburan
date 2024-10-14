namespace Alburan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LastN = new TextBox();
            FirstN = new TextBox();
            MiddleN = new TextBox();
            label5 = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label6 = new Label();
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            label7 = new Label();
            cbProgram = new ComboBox();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            btnBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 25);
            label1.Name = "label1";
            label1.Size = new Size(272, 30);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 86);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Last Name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 159);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 227);
            label4.Name = "label4";
            label4.Size = new Size(125, 21);
            label4.TabIndex = 3;
            label4.Text = "Middle Name *";
            // 
            // LastN
            // 
            LastN.Location = new Point(55, 119);
            LastN.Name = "LastN";
            LastN.Size = new Size(375, 23);
            LastN.TabIndex = 4;
            LastN.TextChanged += LastN_TextChanged;
            // 
            // FirstN
            // 
            FirstN.Location = new Point(55, 192);
            FirstN.Name = "FirstN";
            FirstN.Size = new Size(375, 23);
            FirstN.TabIndex = 5;
            FirstN.TextChanged += FirstN_TextChanged;
            // 
            // MiddleN
            // 
            MiddleN.Location = new Point(55, 260);
            MiddleN.Name = "MiddleN";
            MiddleN.Size = new Size(375, 23);
            MiddleN.TabIndex = 6;
            MiddleN.TextChanged += MiddleN_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 313);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 7;
            label5.Text = "Gender *";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(123, 311);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(54, 19);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = " Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(183, 311);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(66, 19);
            rbFemale.TabIndex = 9;
            rbFemale.TabStop = true;
            rbFemale.Text = " Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 347);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth *";
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbDay.Location = new Point(55, 375);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(121, 23);
            cbDay.TabIndex = 11;
            cbDay.Text = "-Day-";
            cbDay.SelectedIndexChanged += cbDay_SelectedIndexChanged;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cbMonth.Location = new Point(182, 375);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(121, 23);
            cbMonth.TabIndex = 12;
            cbMonth.Text = "-Month-";
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" });
            cbYear.Location = new Point(309, 375);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(121, 23);
            cbYear.TabIndex = 13;
            cbYear.Text = "-Year-";
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 417);
            label7.Name = "label7";
            label7.Size = new Size(126, 17);
            label7.TabIndex = 14;
            label7.Text = "Program to apply *";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelor of Science in Business Administration (BSBA)", "Bachelor of Science in Accountancy (BSA)", "Bachelor of Science in Entrepreneurship (BSE)", "Bachelor of Science in Marketing Management (BSMM)", "Bachelor of Science in Management Accounting (BSMA)", "Bachelor of Science in Human Resource Management (BSHRM)", "Bachelor of Science in Civil Engineering (BSCE)", "Bachelor of Science in Mechanical Engineering (BSME)", "Bachelor of Science in Electrical Engineering (BSEE)", "Bachelor of Science in Electronics Engineering (BSECE)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Industrial Engineering (BSIE)", "Bachelor of Science in Architecture (BS Arch)", "Bachelor of Science in Nursing (BSN)", "Bachelor of Science in Pharmacy (BSPharm)", "Bachelor of Science in Medical Technology (BS MedTech)", "Doctor of Medicine (MD)", "Bachelor of Science in Physical Therapy (BSPT)", "Bachelor of Science in Dentistry (BSD)", "Bachelor of Secondary Education (BSEd)", "Bachelor of Elementary Education (BEEd)", "Bachelor of Science in Psychology (BS Psych)", "Bachelor of Arts in Communication (AB Comm)", "Bachelor of Science in Social Work (BSW)", "Bachelor of Arts in Political Science (AB PolSci)" });
            cbProgram.Location = new Point(56, 437);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(374, 23);
            cbProgram.TabIndex = 15;
            cbProgram.SelectedIndexChanged += cbProgram_SelectedIndexChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.RosyBrown;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(55, 479);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(327, 80);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register student";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(487, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 321);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Gray;
            btnBrowse.Location = new Point(590, 382);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(230, 88);
            btnBrowse.TabIndex = 18;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 585);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox1);
            Controls.Add(btnRegister);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Controls.Add(label6);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(label5);
            Controls.Add(MiddleN);
            Controls.Add(FirstN);
            Controls.Add(LastN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox LastN;
        private TextBox FirstN;
        private TextBox MiddleN;
        private Label label5;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label label6;
        private ComboBox cbDay;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Label label7;
        private ComboBox cbProgram;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Button btnBrowse;
    }
}
