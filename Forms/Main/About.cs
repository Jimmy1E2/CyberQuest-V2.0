using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CyberQuest_Innovations.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/gdyWbftUMP");
        }

        private void btnTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/joinchat/2Bxmvov5BBphMzc0");
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("https://cyberquest.innovations.com/");
        }
    }
}
