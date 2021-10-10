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

            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "DELETE FROM Students WHERE Student_ID = @studentid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@studentid", tbRStudent.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            tbRStudent.Clear();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close this form and return to the previous
            this.Close();
        }


    }
}
