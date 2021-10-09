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
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Desktop\Year 2\Semester 2\CMPG 223\Project\Project\CyberQuest_Innovations\CyberQuest_Innovations\Forms\Student\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;

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
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUStudent.Clear();
            tbUDetail.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                columName = "Room_Number";
                IUpdate = int.Parse(tbUDetail.Text);
            }

            if (comboBox1.SelectedIndex == 1)
            {
                columName = "Field_of_Study_ID";
                IUpdate = int.Parse(tbUDetail.Text);
            }

            if (comboBox1.SelectedIndex == 2)
            {
                columName = "Name";
                SUpdate = tbUDetail.Text;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                columName = "Last_Name";
                SUpdate = tbUDetail.Text;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                columName = "Cell_Num";
                SUpdate = tbUDetail.Text;
            }

            if (comboBox1.SelectedIndex == 5)
            {
                columName = "Email_Address";
                SUpdate = tbUDetail.Text;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbUStudent.Text, out student_ID))
            {
                conn.Open();
                string sql;
                if (IUpdate == 0)
                {
                    sql = $"UPDATE STUDENT SET {columName} = '{SUpdate}' WHERE Stuent_ID = {student_ID}";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                else
                {
                    sql = $"UPDATE STUDENT SET {columName} = {IUpdate} WHERE Stuent_ID = {student_ID}";
                    comm = new SqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                }
                conn.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect data type for Student_ID. Please try again");
                tbUStudent.Clear();
                tbUStudent.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close this form and return to the previous
            this.Close();
        }


    }
}
