using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CyberQuest_Innovations.Forms.Student
{
    public partial class Remove_Student : Form
    {

        SqlConnection conn;
        SqlCommand comm;

        public int student_ID;

        public Remove_Student()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the textbox
            tbRStudent.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (int.TryParse(tbRStudent.Text, out student_ID))
            {
                //Delete the record that corresponds to the student number given and close the form after displaying a message
                this.Close();
            }
            else
            {
                //Display a message if data type is incofrect and clear it and reset focus to the textbox
                MessageBox.Show("Incorrect dataype for Student_ID. Try an integer.");
                tbRStudent.Clear();
                tbRStudent.Focus();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close this form and return to the previous
            this.Close();
        }


    }
}
