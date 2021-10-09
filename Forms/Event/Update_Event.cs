using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberQuest_Innovations.Forms
{
    public partial class Update_Event : Form
    {
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
            this.Close();
        }

        private void btnEClear_Click(object sender, EventArgs e)
        {
            tbEventName.Clear();
            tbDescription.Clear();
        }
    }
}
