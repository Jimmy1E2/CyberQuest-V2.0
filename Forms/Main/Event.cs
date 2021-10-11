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

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            new Add_Event().Show();

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
            new Update_Event().Show();

            load();

        }

        private void btnCRemove_Click(object sender, EventArgs e)
        {
            new Remove_Event().Show();

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
            SqlDataAdapter adap = new SqlDataAdapter(select, conn);
            DataSet ds = new DataSet();

            conn.Open();

            adap.Fill(ds, "Event");
            dbView.DataSource = ds;
            dbView.DataMember = "Event";

            conn.Close();

        }
    }
}
