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
    public partial class Update_Student : Form
    {
        //SqlConnection conn;
        //SqlCommand comm;

        public int student_ID;
        public int IUpdate = 0;
        public string SUpdate;
        public string columName;

        public Update_Student()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
        }

        private void Update_Student_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUStudent.Clear();
            tbUDetail.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            string constring = f1.constring;
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd;
            string select;
            conn.Open();
            

            if(comboBox1.SelectedItem.ToString() == "Name")
            {
                select = "UPDATE Students SET Name = @name WHERE Student_ID = @sid";
                cmd = new SqlCommand(select, conn);
                cmd.Parameters.Add("@sid", tbUStudent.Text);
                cmd.Parameters.Add("@name", tbUDetail.Text);
                cmd.ExecuteNonQuery();
            }
            if(comboBox1.SelectedItem.ToString() == "Last Name")
            {
                select = "UPDATE Students SET Last_Name = @lname WHERE Student_ID = @sid";
                cmd = new SqlCommand(select, conn);
                cmd.Parameters.Add("@sid", tbUStudent.Text);
                cmd.Parameters.Add("@lname", tbUDetail.Text);
                cmd.ExecuteNonQuery();
            }
            if (comboBox1.SelectedItem.ToString() == "Cellphone Number")
            {
                select = "UPDATE Students SET Cellphone_Number = @cell WHERE Student_ID = @sid";
                cmd = new SqlCommand(select, conn);
                cmd.Parameters.Add("@sid", tbUStudent.Text);
                cmd.Parameters.Add("@cell", tbUDetail.Text);
                cmd.ExecuteNonQuery();
            }
            if (comboBox1.SelectedItem.ToString() == "E-Mail Address")
            {
                select = "UPDATE Students SET [E-Mail_Address] = @mail WHERE Student_ID = @sid";
                cmd = new SqlCommand(select, conn);
                cmd.Parameters.Add("@sid", tbUStudent.Text);
                cmd.Parameters.Add("@mail", tbUDetail.Text);
                cmd.ExecuteNonQuery();
            }
            

            conn.Close();
            this.Close();

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close this form and return to the main
            this.Close();
        }


    }
}
