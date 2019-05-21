using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CizgeAlgoritmalarıVeSosyalAglar
{
    public partial class Form2 : Form
    {
        string[] koseDizi = {"Olivia,Doktor","Celine,Müh.","Winston,Politikacı","Chole,Mimar","John,Subay","Jack,Prof." };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            float a = 0, b = 0, a2, b2;
            Graphics g = this.CreateGraphics();
            this.Show();
            SolidBrush b1 = new SolidBrush(Color.Black);
            Pen p1 = new Pen(Color.Black, 1);



            for (int i = 0; i < 6; i++)
            {
                a = (float)Math.Cos(i * (360 / 6));
                b = (float)Math.Sin(i * (360 / 6));
                g.DrawString(" " + koseDizi[i], new Font("Times New Roman", 10), b1, (50 * a + 104), (50 * b + 104));
                g.DrawEllipse(p1, (50 * a + 100), (50 * b + 100), 20, 20);
                for (int j = 0; j < 6; j++)
                {

                    a2 = (float)Math.Cos(j * (360 / 6));
                    b2 = (float)Math.Sin(j * (360 / 6));
                    g.DrawLine(p1, (45 * a + 107), (45 * b + 115), (45 * a2 + 107), (45 * b2 + 115));

                }
            }

        }
    }
}
