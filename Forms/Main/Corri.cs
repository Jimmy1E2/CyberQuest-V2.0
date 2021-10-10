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
    public partial class Corri : Form
    {
        public Corri()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Luan\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\Room_DB_Test.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapt;
        DataSet ds;
        SqlDataReader Reader;

        private void btnDescription_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);

            conn.Open();
            string sql = "SELECT Corridor_Name, Corridor_Description FROM ROOM";
            command = new SqlCommand(sql, conn);
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                tbCor_Description.Text = Reader.GetValue(0).ToString() + ": " + Reader.GetValue(1).ToString();
            }
            conn.Close();

        }

        public void load()
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            string select = "SELECT * FROM Room";
            SqlConnection conn = new SqlConnection(constring);
            SqlDataAdapter adap = new SqlDataAdapter(select, conn);
            DataSet ds = new DataSet();

            conn.Open();

            adap.Fill(ds, "Room");
            dgv1.DataSource = ds;
            dgv1.DataMember = "Room";

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.Add_Room().ShowDialog();
            load();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            new Forms.Remove_Room().ShowDialog();
            load();
        }

        private void Corri_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
