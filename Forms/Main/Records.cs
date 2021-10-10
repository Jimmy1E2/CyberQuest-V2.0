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
            GridViewPopulate("Students");
            cb1.Items.Add("Students");
            cb1.Items.Add("Event");
            cb1.Items.Add("Room");
            cb1.Items.Add("Corridor");
            cb1.Items.Add("Users");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            GridViewPopulate(cb1.SelectedItem.ToString());
        }
    }
}
