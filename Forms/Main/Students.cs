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

        }

        private void Students_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            //ShowAll();

            load();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Student Astd = new Add_Student();
            Astd.ShowDialog();

            load();

            //ShowAll();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Student Ustd = new Update_Student();
            Ustd.ShowDialog();

            load();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove_Student Rstd = new Remove_Student();
            Rstd.ShowDialog();

            load();

        }

        private void Students_Load_1(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            string select = "SELECT * FROM Students";
            SqlConnection conn = new SqlConnection(constring);
            SqlDataAdapter adap = new SqlDataAdapter(select, conn);
            DataSet ds = new DataSet();

            conn.Open();

            adap.Fill(ds, "Students");
            dbView.DataSource = ds;
            dbView.DataMember = "Students";

            conn.Close();
        }
    }
}
