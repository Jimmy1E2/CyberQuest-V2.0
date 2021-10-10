using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CyberQuest_Innovations.Forms
{
    public partial class Add_Student : Form
    {

        public Add_Student()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close this form and return to the previous
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(tbName.Text != null && tbLast_Name.Text != null && tbCell.Text != null && tbMail.Text != null)
            {
                Form1 f1 = new Form1();
                string constring = f1.constring;
                SqlConnection conn = new SqlConnection(constring);

                conn.Open();

                SqlCommand cmd;
                string sql = "INSERT INTO Students(Name, Last_Name, Cellphone_Number, [E-Mail_Address]) VALUES (@name, @lname, @cell, @mail)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", tbName.Text);
                cmd.Parameters.AddWithValue("@lname", tbLast_Name.Text);
                cmd.Parameters.AddWithValue("@cell", tbCell.Text);
                cmd.Parameters.AddWithValue("@mail", tbMail.Text);
                cmd.ExecuteNonQuery();

                conn.Close();
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all input and reset the focus to the first textbox
            tbName.Clear();
            tbLast_Name.Clear();
            tbCell.Clear();
            tbMail.Clear();
            tbName.Clear();
            tbCell.Clear();

            tbName.Focus();
        }


    }
}
