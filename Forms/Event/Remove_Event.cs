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
    public partial class Remove_Event : Form
    {
        public Remove_Event()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = String.Empty;
        }

        private void btnEBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnERemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
