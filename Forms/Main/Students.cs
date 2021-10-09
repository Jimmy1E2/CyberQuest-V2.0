using CyberQuest_Innovations.Forms.Student;
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

namespace CyberQuest_Innovations.Forms
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();

        }

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\Year 2\Semester 2\CMPG 223\Project\Project\CyberQuest_Innovations\CyberQuest_Innovations\Forms\Student\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;

        private void ShowAll()
        {

            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM STUDENT";
            comm = new SqlCommand(sql, conn);

            adap.SelectCommand = comm;
            adap.Fill(ds, "STUDENT");

            dbView.DataSource = ds;
            dbView.DataMember = "STUDENT";

            conn.Close();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            ShowAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Student Astd = new Add_Student();
            Astd.ShowDialog();

            ShowAll();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Student Ustd = new Update_Student();
            Ustd.ShowDialog();
            ShowAll();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove_Student Rstd = new Remove_Student();
            Rstd.ShowDialog();

            conn.Open();

            string sql = $"DELETE FROM STUDENT WHERE Stuent_ID = {Rstd.student_ID}";
            comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            conn.Close();

            ShowAll();

            MessageBox.Show("You successfully removed the all records linked to the following Student_ID: " + Rstd.student_ID);

        }


    }
}
