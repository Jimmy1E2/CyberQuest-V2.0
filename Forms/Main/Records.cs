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
    public partial class Records : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\Year 2\Semester 2\CMPG 223\Project Final Code\CyberQuest-Final - Group 30\CyberQuest-Final(0.1)\CyberQuest-Final(0.1)\Records.mdf;Integrated Security=True";
        SqlCommand comm;
        SqlConnection conn;
        SqlDataAdapter adap;
        DataSet ds;

        public Records()
        {
            InitializeComponent();
        }

        public Form1 f1 = new Form1();

        public void GridViewPopulate(string filter)
        {
            string constring = f1.constring;
            string select = "SELECT * FROM " + filter;
            SqlConnection conn = new SqlConnection(constring);
            SqlDataAdapter adap = new SqlDataAdapter(select, conn);
            DataSet ds = new DataSet();

            conn.Open();

            adap.Fill(ds, "Populate");
            dgv1.DataSource = ds;
            dgv1.DataMember = "Populate";

            conn.Close();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "TITLE";

            GridViewPopulate("Students");
            cb1.Items.Add("Students");
            cb1.Items.Add("Event");
            cb1.Items.Add("Room");
            cb1.Items.Add("Corridor");
            cb1.Items.Add("Users");

            //conn = new SqlConnection(conStr);
            //conn.Open();
            //conn.Close();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            lblPageNum.Text = "Page 1";
            lblPageOfPages.Text = "Page 1 of 1";

            if(cbDateFilter.Checked)
            {
                string fromDate = dtFrom.Value.ToShortDateString();
                string toDate = dtTo.Value.ToShortDateString();

                if(toDate.CompareTo(fromDate) < 0)
                {
                    MessageBox.Show("Invalid date input.");
                }
                             
                string constring = f1.constring;
                string select = "SELECT * FROM " + cb1.SelectedItem.ToString()+ $" WHERE Event_Date >= '{fromDate}' AND Event_Date <= '{toDate}'";
                SqlConnection conn = new SqlConnection(constring);
                SqlDataAdapter adap = new SqlDataAdapter(select, conn);
                DataSet ds = new DataSet();

                conn.Open();

                adap.Fill(ds, "Populate");
                dgv1.DataSource = ds;
                dgv1.DataMember = "Populate";

                conn.Close();
                lblTitle.Text = "Summary Report for " + cb1.SelectedItem.ToString() + " from " + dtFrom.Value.ToShortDateString() + " to " + dtTo.Value.ToShortDateString();
            }
            else
            {
                lblTitle.Text = "Summary Report for " + cb1.SelectedItem.ToString();
                GridViewPopulate(cb1.SelectedItem.ToString());
            }



        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
            conn.Open();

            DataTable dt = new DataTable();
            adap = new SqlDataAdapter("select * from tbl_Event", conn);

            conn.Close();
        }

      
    }
}
