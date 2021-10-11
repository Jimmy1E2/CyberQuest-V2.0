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
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            SqlCommand cmd;
            string sql = "UPDATE Room SET Student_ID = NULL WHERE Room_Number = @rn AND Corridor_ID = @cid";
            cmd = new SqlCommand(sql, conn);
            
            cmd.Parameters.Add("@rn", cbRoom.Text);
            cmd.Parameters.Add("@cid", cbCorridor.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }



        private void Remove_Room_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);

            conn.Open();

            string sql = $"SELECT * FROM ROOM";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Corridor_ID", typeof(string)); 
            dt.Columns.Add("Room_Number", typeof(int));
            dt.Load(reader);
            cbCorridor.ValueMember = "Corridor_ID"; //Adds Corridor_Name to the combobox
            cbCorridor.DataSource = dt;
            cbRoom.ValueMember = "Room_Number"; //Adds Room_Num to combobox
            cbRoom.DataSource = dt;

            conn.Close();
        }
    }
}
