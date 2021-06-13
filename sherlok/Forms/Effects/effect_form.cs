using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sherlok.Forms.Effects
{
    public partial class effect_form : Form
    {
        List<Salut> saluts;


        public effect_form()
        {
            InitializeComponent();
            saluts = new List<Salut>();
        }

        Random r = new Random();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Color[] clrs = new Color[] { Color.Blue};

            int cnum = r.Next(clrs.GetLength(0));

            ColorSalut s = new ColorSalut(clrs[cnum]);
            s.Gravity = -0.0F;
            s.Start(e.Location);
            saluts.Add(s);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Salut s in saluts)
            {
                s.Paint(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Salut s in saluts)
            {
                s.Update(0.1);
            }
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Color[] clrs = new Color[] { Color.Blue };
            
            int cnum = r.Next(clrs.GetLength(0));

            ColorSalut s = new ColorSalut(clrs[cnum]);
            s.Gravity = -0.0F;
            Point endPoint = new Point();
            endPoint.X = r.Next(1,SystemInformation.PrimaryMonitorSize.Width);
            endPoint.Y = r.Next(1, SystemInformation.PrimaryMonitorSize.Height); 
            s.Start(endPoint);
            saluts.Add(s);
        }


        private void effect_form_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Escape) this.Close();
            timer1.Enabled = false;
            timer2.Enabled = false;
            this.Close();
        }
    }
}
