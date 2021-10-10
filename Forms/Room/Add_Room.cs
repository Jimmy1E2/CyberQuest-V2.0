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
    public partial class Add_Room : Form
    {
        public Add_Room()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Luan\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Room_DB_Test.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSID.Clear();

        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "UPDATE Room SET Student_ID = @sid WHERE Corridor_ID = @cor AND Room_Number = @rn";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@sid", tbSID.Text);
            cmd.Parameters.Add("@cor", tbCID.Text);
            cmd.Parameters.Add("@rn", tbRoom.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Room_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
