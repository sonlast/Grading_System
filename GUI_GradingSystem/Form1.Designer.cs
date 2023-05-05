namespace GUI_GradingSystem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.studentid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.records = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.project = new System.Windows.Forms.TextBox();
            this.assignments = new System.Windows.Forms.TextBox();
            this.quizzes = new System.Windows.Forms.TextBox();
            this.attendance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.finals = new System.Windows.Forms.TextBox();
            this.midterm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(291, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "STUDENT GRADING SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.studentid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 130);
            this.panel1.TabIndex = 21;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(285, 78);
            this.lastname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 21);
            this.lastname.TabIndex = 12;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(99, 76);
            this.firstname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 21);
            this.firstname.TabIndex = 11;
            // 
            // studentid
            // 
            this.studentid.Location = new System.Drawing.Point(99, 23);
            this.studentid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentid.MaxLength = 4;
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(100, 21);
            this.studentid.TabIndex = 10;
            this.studentid.TextChanged += new System.EventHandler(this.studentid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // records
            // 
            this.records.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.records.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.first,
            this.last,
            this.avg});
            this.records.EnableHeadersVisualStyles = false;
            this.records.Location = new System.Drawing.Point(16, 465);
            this.records.Name = "records";
            this.records.ReadOnly = true;
            this.records.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.records.Size = new System.Drawing.Size(405, 187);
            this.records.TabIndex = 22;
            // 
            // id
            // 
            this.id.HeaderText = "Student ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // first
            // 
            this.first.HeaderText = "First Name";
            this.first.Name = "first";
            this.first.ReadOnly = true;
            // 
            // last
            // 
            this.last.HeaderText = "Last Name";
            this.last.Name = "last";
            this.last.ReadOnly = true;
            // 
            // avg
            // 
            this.avg.HeaderText = "Average";
            this.avg.MaxInputLength = 3;
            this.avg.Name = "avg";
            this.avg.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.project);
            this.panel2.Controls.Add(this.assignments);
            this.panel2.Controls.Add(this.quizzes);
            this.panel2.Controls.Add(this.attendance);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(13, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 195);
            this.panel2.TabIndex = 23;
            // 
            // project
            // 
            this.project.Location = new System.Drawing.Point(116, 156);
            this.project.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.project.MaxLength = 3;
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(42, 21);
            this.project.TabIndex = 24;
            // 
            // assignments
            // 
            this.assignments.Location = new System.Drawing.Point(116, 108);
            this.assignments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.assignments.MaxLength = 3;
            this.assignments.Name = "assignments";
            this.assignments.Size = new System.Drawing.Size(42, 21);
            this.assignments.TabIndex = 23;
            // 
            // quizzes
            // 
            this.quizzes.Location = new System.Drawing.Point(116, 62);
            this.quizzes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quizzes.MaxLength = 3;
            this.quizzes.Name = "quizzes";
            this.quizzes.Size = new System.Drawing.Size(42, 21);
            this.quizzes.TabIndex = 22;
            // 
            // attendance
            // 
            this.attendance.Location = new System.Drawing.Point(116, 17);
            this.attendance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.attendance.MaxLength = 3;
            this.attendance.Name = "attendance";
            this.attendance.Size = new System.Drawing.Size(42, 21);
            this.attendance.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 159);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Project:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Assignments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quizzes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Attendance:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.finals);
            this.panel3.Controls.Add(this.midterm);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(220, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 195);
            this.panel3.TabIndex = 24;
            // 
            // finals
            // 
            this.finals.Location = new System.Drawing.Point(117, 126);
            this.finals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.finals.MaxLength = 3;
            this.finals.Name = "finals";
            this.finals.Size = new System.Drawing.Size(42, 21);
            this.finals.TabIndex = 22;
            // 
            // midterm
            // 
            this.midterm.Location = new System.Drawing.Point(117, 45);
            this.midterm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.midterm.MaxLength = 3;
            this.midterm.Name = "midterm";
            this.midterm.Size = new System.Drawing.Size(42, 21);
            this.midterm.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "FINAL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "MIDTERM:";
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Done.Location = new System.Drawing.Point(337, 668);
            this.Done.Margin = new System.Windows.Forms.Padding(2);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(92, 32);
            this.Done.TabIndex = 27;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(163, 410);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(110, 40);
            this.add.TabIndex = 28;
            this.add.Text = "Submit";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 711);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.records);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "STUDENT GRADING SYSTEM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox studentid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView records;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox project;
        private System.Windows.Forms.TextBox assignments;
        private System.Windows.Forms.TextBox quizzes;
        private System.Windows.Forms.TextBox attendance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox finals;
        private System.Windows.Forms.TextBox midterm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first;
        private System.Windows.Forms.DataGridViewTextBoxColumn last;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg;
    }
}

