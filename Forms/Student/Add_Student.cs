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

        string conStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = DataDirectory|\Database1.mdf; Integrated Security = True";
        SqlConnection conn;
        SqlCommand comm;


        public int student_ID;
        public int roomNumber;
        public int event_ID;
        public int field_of_study_ID;
        public string name;
        public string last_name;
        public string cellNumber;
        public string email;

        public Add_Student()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close this form and return to the previous
            this.Close();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            conn.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Here we validate the input of each textbox and if it is valid we validate the next and so on until all the  input is validated and is correct then we close the form

            this.Close();

            if (int.TryParse(tbStudentID.Text, out student_ID))
            {
                if (int.TryParse(tbRoom_Number.Text, out roomNumber))
                {
                    if (int.TryParse(tbEventID.Text, out event_ID))
                    {
                        if (int.TryParse(tbField.Text, out field_of_study_ID))
                        {
                            name = tbName.Text;
                            last_name = tbLastName.Text;
                            cellNumber = tbCell.Text;
                            email = tbEmail.Text;

                            conn.Open();

                            string sql = $"INSERT INTO STUDENT (Stuent_ID, Room_Number, Event_ID, Field_of_Study_ID, Name, Last_Name, Cell_Num, Email_Address) VALUES ('{student_ID}','{roomNumber}', '{event_ID}', '{field_of_study_ID}', '{name}', '{last_name}', '{cellNumber}', '{email}')";
                            comm = new SqlCommand(sql, conn);
                            comm.ExecuteNonQuery();
                            conn.Close();

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid data type for Student_ID. Please try again.");
                            tbStudentID.Clear();
                            tbStudentID.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid data type for Event_ID. Please try again.");
                        tbEventID.Clear();
                        tbEventID.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid data type for Room_Number. Please try again.");
                    tbRoom_Number.Clear();
                    tbRoom_Number.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid data type for Student_ID. Please try again.");
                tbStudentID.Clear();
                tbStudentID.Focus();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all input and reset the focus to the first textbox
            tbStudentID.Clear();
            tbRoom_Number.Clear();
            tbEventID.Clear();
            tbField.Clear();
            tbName.Clear();
            tbLastName.Clear();
            tbCell.Clear();
            tbEmail.Clear();

            tbStudentID.Focus();
        }


    }
}
