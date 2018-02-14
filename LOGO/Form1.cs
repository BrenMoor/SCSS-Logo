using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics fg = this.CreateGraphics();
            fg.Clear(Color.Red);
            SolidBrush drawBrush = new SolidBrush(Color.ForestGreen);
            fg.FillEllipse(drawBrush, 145, 35, 200, 200);
          
            Font drawFont = new Font("Times New Roman", 144, FontStyle.Bold);
            Font drawFont1 = new Font("Impact", 30, FontStyle.Bold);
            Font drawFont2 = new Font("Times New Roman", 10, FontStyle.Italic);
            SolidBrush textBrush = new SolidBrush(Color.White);

            fg.DrawString("C", drawFont, textBrush, 115, 30);
            fg.DrawString("RAMS", drawFont1, textBrush, 225, 120);
            fg.TranslateTransform(350, 200);

            fg.RotateTransform(270);

            fg.DrawString("Central Rams Arcade", drawFont2, textBrush, new Rectangle());

            fg.ResetTransform();
        }
    }
}
