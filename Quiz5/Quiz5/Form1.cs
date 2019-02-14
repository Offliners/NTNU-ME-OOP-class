using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _106_Quiz4;

namespace Quiz5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Triangle tri = new Triangle();
            tri.CreatePoints();
            tri.ptArr[0].xCoord = double.Parse(textBox1.Text);
            tri.ptArr[0].yCoord = double.Parse(textBox2.Text);
            tri.ptArr[1].xCoord = double.Parse(textBox3.Text);
            tri.ptArr[1].yCoord = double.Parse(textBox4.Text);
            tri.ptArr[2].xCoord = double.Parse(textBox5.Text);
            tri.ptArr[2].yCoord = double.Parse(textBox6.Text);
            if (tri.isValid() == true)
            {
                if (checkBox1.Checked)
                    message += ("Area = " + tri.Area().ToString() + Environment.NewLine);
                if (checkBox2.Checked)
                    message += ("Perimeter = " + tri.Perimeter().ToString() + Environment.NewLine);
                if (checkBox3.Checked)
                {
                    switch(tri.ShapeType())
                    {
                        case 1:
                            message += "為直角三角形";
                            break;
                        case 2:
                            message += "為銳角三角形";
                            break;
                        case 3:
                            message += "為鈍角三角形";
                            break;
                    }
                }
            }
            else
                message += "此三點無法形成三角形";
            richTextBox1.Text = message;
        }
    }
}
