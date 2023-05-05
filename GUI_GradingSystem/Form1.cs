using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace GUI_GradingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void studentid_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void Done_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentid.Text) ||
                string.IsNullOrWhiteSpace(firstname.Text) ||
                string.IsNullOrWhiteSpace(lastname.Text) ||
                string.IsNullOrWhiteSpace(attendance.Text) ||
                string.IsNullOrWhiteSpace(quizzes.Text) ||
                string.IsNullOrWhiteSpace(assignments.Text) ||
                string.IsNullOrWhiteSpace(project.Text) ||
                string.IsNullOrWhiteSpace(midterm.Text) ||
                string.IsNullOrWhiteSpace(finals.Text))
            { 
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
            else
            {
                string studentID = studentid.Text;
                string firstName = firstname.Text;
                string lastName = lastname.Text;

                double att = Convert.ToDouble(attendance.Text);
                double quiz = Convert.ToDouble(quizzes.Text);
                double assigns = Convert.ToDouble(assignments.Text);
                double proj = Convert.ToDouble(project.Text);
                double mid = Convert.ToDouble(midterm.Text);
                double fin = Convert.ToDouble(finals.Text);

                double avg = (att + quiz + assigns + proj + mid + fin) / 6;
                string[] row = new string[] { studentID, firstName, lastName, avg.ToString("0.00") };
                records.Rows.Add(row);

                studentid.Text = "";
                firstname.Text = "";
                lastname.Text = "";
                attendance.Text = "";
                quizzes.Text = "";
                assignments.Text = "";
                project.Text = "";
                midterm.Text = "";
                finals.Text = "";

                add.Enabled = true;
            }
        }
    }
}
