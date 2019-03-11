using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch05_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double x, y;
            double x2, y2;
            if (chkbox_Point1.Checked)
            {
                x = double.Parse(txt_Point1X.Text);
                y = double.Parse(txt_Point1Y.Text);
                txt_Display.AppendText(DisplayString(x, y, 0, 0));
            }
            if (chkbox_Point2.Checked)
            {
                x = double.Parse(txt_Point2X.Text);
                y = double.Parse(txt_Point2Y.Text);
                txt_Display.AppendText(DisplayString(x, y, 0, 0));

            }
            if (chkbox_TwoPoints.Checked)
            {
                x = double.Parse(txt_Point1X.Text);
                y = double.Parse(txt_Point1Y.Text);
                x2 = double.Parse(txt_Point2X.Text);
                y2 = double.Parse(txt_Point2Y.Text);
                txt_Display.AppendText(DisplayString(x, y, x2, y2));
            }
        }

        private double DistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        private string DisplayString(double x1, double y1, double x2, double y2)
        {
            string StrDisplay = "";
            StrDisplay += '(' + x1.ToString() + ',' + y1.ToString() + ')';
            StrDisplay += "到 ";
            StrDisplay += '(' + x2.ToString() + ',' + y2.ToString() + ')';
            StrDisplay += "的距離 = ";
            StrDisplay += DistanceBetweenTwoPoints(x1,y1,x2,y2).ToString();
            StrDisplay += '\n';
            return StrDisplay;
        }

    }
}
