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
    public partial class Remove_Room : Form
    {
        public Remove_Room()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                string corName = cbCorridor.Text;
                int roomNum = int.Parse(cbRoom.Text);

                conn.Open();

                string sql = $"DELETE FROM ROOM WHERE Corridor_Name = @corridor AND Room_Num = @room";
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@corridor", corName);
                command.Parameters.AddWithValue("@room", roomNum);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Text fields cannot be empty!"); //Exception for when text fields are empty
            }
            
            this.Close();
        }



        private void Remove_Room_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();

            string sql = $"SELECT * FROM ROOM";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Corridor_Name", typeof(string)); 
            dt.Columns.Add("Room_Num", typeof(int));
            dt.Load(reader);
            cbCorridor.ValueMember = "Corridor_Name"; //Adds Corridor_Name to the combobox
            cbCorridor.DataSource = dt;
            cbRoom.ValueMember = "Room_Num"; //Adds Room_Num to combobox
            cbRoom.DataSource = dt;

            conn.Close();
        }
    }
}
