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
            InitializeDynaticTextBox();
        }

        private TextBox[,] textbox;

        private void InitializeDynaticTextBox()
        {
            textbox = new TextBox[3, 2];
            int xpos = 80;
            int ypos = 45;
            int xinc = 120;
            int yinc = 50;
            // new
            for(int i=0;i<=2;i++)
            {
                for(int j= 0;j<=1;j++)
                    this.textbox[i, j] = new TextBox();
            }

            // add to groupbox
            for(int i =0;i<=2;i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    this.groupBox1.Controls.Add(this.textbox[i, j]);
                    this.textbox[i, j].TabIndex = (i + j + 1);
                }
            }

            //textbox imformation
            for(int i= 0;i<=2;i++)
            {
                for(int j=0;j<=1;j++)
                {
                    this.textbox[i, j].Size = new System.Drawing.Size(100, 25);
                    this.textbox[i, j].Location = new System.Drawing.Point(xpos + j * xinc, ypos + i * yinc);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            Triangle tri = new Triangle();
            tri.CreatePoints();
            tri.ptArr[0].xCoord = Double.Parse(textbox[0,0].Text);
            tri.ptArr[0].yCoord = Double.Parse(textbox[0,1].Text);
            tri.ptArr[1].xCoord = Double.Parse(textbox[1,0].Text);
            tri.ptArr[1].yCoord = Double.Parse(textbox[1,1].Text);
            tri.ptArr[2].xCoord = Double.Parse(textbox[2,0].Text);
            tri.ptArr[2].yCoord = Double.Parse(textbox[2,1].Text);
            if (tri.isValid())
            {
                if (checkBox1.Checked)
                    message += ("Area = " + tri.Area().ToString() + Environment.NewLine);
                if (checkBox2.Checked)
                    message += ("Perimeter = " + tri.Perimeter().ToString() + Environment.NewLine);
                if (checkBox3.Checked)
                {
                    switch (tri.ShapeType())
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
            textBox7.Text = message;
        }
    }
}
