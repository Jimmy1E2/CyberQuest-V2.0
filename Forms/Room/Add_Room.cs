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
            tbCor_Name.Clear();
            tbRoom_Number.Clear();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);

                string corName = tbCor_Name.Text;
                string corDesc = tbCorrDesc.Text;
                int roomNum = int.Parse(tbRoom_Number.Text);

                conn.Open();

                string sql = $"INSERT INTO ROOM(Room_Num, Corridor_Name, Corridor_Description) VALUES(@room, @corridor, @description)";
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@room", roomNum);
                command.Parameters.AddWithValue("@corridor", corName);
                command.Parameters.AddWithValue("@description", corDesc);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Text fields may not be empty");
            }
            
            this.Close();
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
