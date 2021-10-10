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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAddCor_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "INSERT INTO Corridor(Description) VALUES (@desc)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@desc", tb3.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            tb3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "INSERT INTO Room(Corridor_ID, Room_Number) VALUES (@c_id, @rn)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c_id", tb5.Text);
            cmd.Parameters.AddWithValue("@rn", tb7.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            tb5.Clear();
            tb7.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != tbPass1.Text)
            {
                MessageBox.Show("Password do not match!");
            }
            else
            {

                Form1 f1 = new Form1();
                string constring = f1.constring;
                SqlConnection conn = new SqlConnection(constring);

                conn.Open();

                SqlCommand cmd;
                string sql = "INSERT INTO Users(Username, Password) VALUES (@username, @password)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", tbUser.Text);
                cmd.Parameters.AddWithValue("@password", tbPass.Text);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            tbUser.Clear();
            tbPass.Clear();
            tbPass1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "DELETE FROM Room WHERE Room_Number = @roomnumber AND Corridor_ID = @corid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@roomnumber", tb6.Text);
            cmd.Parameters.AddWithValue("@corid", tb8.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            tb6.Clear();
            tb8.Clear();
        }

        private void btnRemoveCor_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "DELETE FROM Corridor WHERE Corridor_ID = @corridorid";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@corridorid", tb4.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            tb4.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
            tbPass.Clear();
            tbPass1.Clear();
        }
    }
    
}
