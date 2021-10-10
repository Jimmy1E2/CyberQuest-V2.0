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
    public partial class Add_Event : Form
    {
        public Add_Event()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void btnEBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEClear_Click(object sender, EventArgs e)
        {
            tbEventName.Clear();
            tbDescription.Clear();
        }

        private void btnESubmit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "INSERT INTO Event(Event_Name, Event_Date, Event_Description) VALUES (@ename, @edate, @edesc)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ename", tbEventName.Text);
            cmd.Parameters.AddWithValue("@edate", dtp1.Value);
            cmd.Parameters.AddWithValue("@edesc", tbDescription.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }
    }
}
