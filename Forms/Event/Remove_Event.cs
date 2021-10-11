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
    public partial class Remove_Event : Form
    {
        public Remove_Event()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void btnEBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnERemove_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "DELETE FROM Event WHERE Event_ID = @eventid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@eventid", tb1.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }
    }
}
