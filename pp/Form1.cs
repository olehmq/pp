using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        Graphics g;
        Drop[] t = new Drop[500];

        Param[] p = new Param[2];
        ParamWaterDrop p1 = new ParamWaterDrop();
        ParamTwoWaterDrop p2 = new ParamTwoWaterDrop();
        int count = 0;
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // r.Next(10, 800);

            if (r.Next(0, 10) % 2 == 0)
                t[count] = new Drop(r.Next(10, 1500), r.Next(10, 1500), p1);
            else
                t[count] = new Drop(r.Next(10, 1500), r.Next(10, 1500), p2);

            g.DrawImage(t[count].p.pic, new Rectangle(t[count].x, t[count].y, t[count].p.h, 20));
            if (count < 499)
                count++;
            else
                timer1.Stop();
        }
    }
}
