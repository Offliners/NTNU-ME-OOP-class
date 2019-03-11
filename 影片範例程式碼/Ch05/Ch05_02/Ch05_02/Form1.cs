using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Point1ToOrigin_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txt_Point1X.Text);
            double y = double.Parse(txt_Point1Y.Text);
            double d = Math.Sqrt(x * x + y * y);
            string StrDisplay = '(' + x.ToString() + ',' + y.ToString() + ')';
            StrDisplay += "到 ";
            StrDisplay += '(' + 0.ToString() + ',' + 0.ToString() + ')';
            StrDisplay += "的距離 = ";
            StrDisplay += d.ToString();
            StrDisplay += '\n';
            txt_Display.AppendText(StrDisplay);
        }

        private void btn_Point2ToOrigin_Click(object sender, EventArgs e)
        {                
            double x = double.Parse(txt_Point2X.Text);
            double y = double.Parse(txt_Point2Y.Text);
            double d = Math.Sqrt(x * x + y * y);
            string StrDisplay = '(' + x.ToString() + ',' + y.ToString() + ')';
            StrDisplay += "到 ";
            StrDisplay += '(' + 0.ToString() + ',' + 0.ToString() + ')';
            StrDisplay += "的距離 = ";
            StrDisplay += d.ToString();
            StrDisplay += '\n';
            txt_Display.AppendText(StrDisplay);
        }

        private void btn_DistanceBetweenTwoPoints_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txt_Point1X.Text);
            double y1 = double.Parse(txt_Point1Y.Text);
            double x2 = double.Parse(txt_Point2X.Text);
            double y2 = double.Parse(txt_Point2Y.Text);
            double d = Math.Sqrt((x1-x2) * (x1-x2) + (y1-y2) * (y1-y2));
            string StrDisplay = '(' + x1.ToString() + ',' + y1.ToString() + ')';
            StrDisplay += "到 ";
            StrDisplay += '(' + x2.ToString() + ',' + y2.ToString() + ')';
            StrDisplay += "的距離 = ";
            StrDisplay += d.ToString();
            StrDisplay += '\n';
            txt_Display.AppendText(StrDisplay);
        }

    }
}
