using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sherlok.Forms
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://r-tech.ru");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/nwm1989");
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            label2.Text = "Версия: " + Properties.Settings.Default.version;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                Forms.Effects.effect_form form = new Forms.Effects.effect_form();
                form.ShowDialog();
        }
    }
}
