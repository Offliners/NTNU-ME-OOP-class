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
            double x, y, d;
            double x2, y2;
            string StrDisplay = "";
            switch (cbox_Select.SelectedIndex)
            {
                case 0:
                    x = double.Parse(txt_Point1X.Text);
                    y = double.Parse(txt_Point1Y.Text);
                    d = Math.Sqrt(x * x + y * y);
                    StrDisplay += '(' + x.ToString() + ',' + y.ToString() + ')';
                    StrDisplay += "到 ";
                    StrDisplay += '(' + 0.ToString() + ',' + 0.ToString() + ')';
                    StrDisplay += "的距離 = ";
                    StrDisplay += d.ToString();
                    StrDisplay += '\n';
                    txt_Display.AppendText(StrDisplay);
                    break;
                case 1:
                    x = double.Parse(txt_Point2X.Text);
                    y = double.Parse(txt_Point2Y.Text);
                    d = Math.Sqrt(x * x + y * y);
                    StrDisplay += '(' + x.ToString() + ',' + y.ToString() + ')';
                    StrDisplay += "到 ";
                    StrDisplay += '(' + 0.ToString() + ',' + 0.ToString() + ')';
                    StrDisplay += "的距離 = ";
                    StrDisplay += d.ToString();
                    StrDisplay += '\n';
                    txt_Display.AppendText(StrDisplay);
                    break;
                case 2:
                    x = double.Parse(txt_Point1X.Text);
                    y = double.Parse(txt_Point1Y.Text);
                    x2 = double.Parse(txt_Point2X.Text);
                    y2 = double.Parse(txt_Point2Y.Text);
                    d = Math.Sqrt((x-x2) * (x-x2) + (y-y2) * (y-y2));
                    StrDisplay += '(' + x.ToString() + ',' + y.ToString() + ')';
                    StrDisplay += "到 ";
                    StrDisplay += '(' + x2.ToString() + ',' + y2.ToString() + ')';
                    StrDisplay += "的距離 = ";
                    StrDisplay += d.ToString();
                    StrDisplay += '\n';
                    txt_Display.AppendText(StrDisplay);
                    break;
                default:
                    break;
            }
        }

       
       

    }
}
