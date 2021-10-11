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
    public partial class Update_Event : Form
    {

        SqlCommand comm;
        bool DataChanged = true;

        public Update_Event()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void btnEBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnESubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                string constring = f1.constring;
                SqlConnection conn = new SqlConnection(constring);

                conn.Open();

                string EventName = tbID.Text;
                string NewEventName = tbEventName.Text;
                string NewEventDescription = tbDescription.Text;
                DateTime NewEventDate = event_DatePicker.Value.Date;

                if (DataChanged)
                {
                    if (tbEventName.Text == "")
                    {
                        if (tbDescription.Text == "")
                        {

                        }
                        else
                        {
                            string sql2 = $"UPDATE EVENT SET Event_Description = '{NewEventDescription}' WHERE Event_ID = @eventid";

                            
                            comm = new SqlCommand(sql2, conn);
                            comm.Parameters.AddWithValue("@eventid", tbID.Text);
                            comm.ExecuteNonQuery();
                        }

                        string sql3 = $"UPDATE EVENT SET Event_Date = '{NewEventDate}' WHERE Event_ID = @eventid";

                        comm = new SqlCommand(sql3, conn);
                        comm.Parameters.AddWithValue("@eventid", tbID.Text);
                        comm.ExecuteNonQuery();
                    }
                    else
                    {
                        string sql = $"UPDATE EVENT SET Event_Name = '{NewEventName}' WHERE Event_ID = @eventid";

                        comm = new SqlCommand(sql, conn);
                        comm.Parameters.AddWithValue("@eventid", tbID.Text);
                        comm.ExecuteNonQuery();

                        if (tbDescription.Text == "")
                        {

                        }
                        else
                        {
                            string sql2 = $"UPDATE EVENT SET Event_Description = '{NewEventDescription}' WHERE Event_ID = @eventid";

                            comm = new SqlCommand(sql2, conn);
                            comm.Parameters.AddWithValue("@eventid", tbID.Text);
                            comm.ExecuteNonQuery();
                        }

                        string sql3 = $"UPDATE EVENT SET Event_Date = '{NewEventDate}' WHERE Event_ID = @eventid";

                        comm = new SqlCommand(sql3, conn);
                        comm.Parameters.AddWithValue("@eventid", tbID.Text);
                        comm.ExecuteNonQuery();
                    }
                }
                else
                {
                    if (tbEventName.Text == "")
                    {
                        if (tbDescription.Text == "")
                        {

                        }
                        else
                        {
                            string sql2 = $"UPDATE EVENT SET Event_Description = '{NewEventDescription}' WHERE Event_ID = @eventid";

                            comm = new SqlCommand(sql2, conn);
                            comm.Parameters.AddWithValue("@eventid", tbID.Text);
                            comm.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string sql = $"UPDATE EVENT SET Event_Name = '{NewEventName}' WHERE Event_ID = @eventid";

                        comm = new SqlCommand(sql, conn);
                        comm.Parameters.AddWithValue("@eventid", tbID.Text);
                        comm.ExecuteNonQuery();

                        if (tbDescription.Text == "")
                        {

                        }
                        else
                        {
                            string sql2 = $"UPDATE EVENT SET Event_Description = '{NewEventDescription}' WHERE Event_ID = @eventid";

                            comm = new SqlCommand(sql2, conn);
                            comm.Parameters.AddWithValue("@eventid", tbID.Text);
                            comm.ExecuteNonQuery();
                        }
                    }
                }

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Fields cannot be empty");
            }

            this.Close();
        }

    

    private void btnEClear_Click(object sender, EventArgs e)
        {
            tbEventName.Clear();
            tbDescription.Clear();
        }

        private void tbEventName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
