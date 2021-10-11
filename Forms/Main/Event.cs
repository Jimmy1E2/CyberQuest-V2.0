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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            new Add_Event().ShowDialog();

            load();
        }

        private void tbSelected_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            new Update_Event().ShowDialog();

            load();

        }

        private void btnCRemove_Click(object sender, EventArgs e)
        {
            new Remove_Event().ShowDialog();

            load();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            string select = "SELECT * FROM Event";
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(select, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Event");
            dbView.DataSource = ds;
            dbView.DataMember = "Event";


            string sql = $"SELECT * FROM Event";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Event_Name", typeof(string));
            dt.Load(reader);
            cb1.ValueMember = "Event_Name";
            cb1.DataSource = dt;

            conn.Close();

        }

        private void btnCSubmit_Click(object sender, EventArgs e)
        {

            if (tbStu.Text == "")
            {
                MessageBox.Show("Please enter student id");
            }
            else
            {
                string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Luan\Downloads\CyberQuest-Final(0.1)\CyberQuest-Final(0.1)\Records.mdf;Integrated Security=True";
                SqlConnection conn;
                SqlCommand comm;

                conn = new SqlConnection(conStr);

                string Event_Name = cb1.SelectedValue.ToString();
                int Student_ID = int.Parse(tbStu.Text);

                conn.Open();

                string sql = $"INSERT INTO ATTEND(Student_ID, Name) VALUES(@Student_ID, @E_Name)";
                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@Student_ID", Student_ID);
                comm.Parameters.AddWithValue("@E_Name", Event_Name);
                comm.ExecuteNonQuery();

                conn.Close();

                tbStu.Clear();
                MessageBox.Show("Entry submitted");
            }

        }
    }
}
