using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinboard
{
    public partial class Form1 : Form
    {
        private RadioButton[,] radiobutton;
        private GroupBox[,] groupbox;
        private TextBox[,] textbox;
        private int count = 0;
        private string message = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rd_xpos = 12;
            int rd_ypos = 22;
            int gb_xpos = 10;
            int gb_ypos = 15;
            int tx_xpos = 20;
            int tx_ypos = 100;
            if (groupBox3.Controls.Count>0)
                ClearAllObjectInGroupBox3();
            if (groupBox2.Controls.Count > 5)
                ClearAlltextboxInGroupbox2();
            int row = Convert.ToInt32(textBox1.Text);
            int col = Convert.ToInt32(textBox2.Text);
            radiobutton = new RadioButton[row, col];
            groupbox = new GroupBox[row, col];
            textbox = new TextBox[3, 4];
            for (int i = 0; i < row ; i++)
            {
                for (int j = 0; j < col ; j++)
                {
                    this.radiobutton[i, j] = new RadioButton();
                    this.groupbox[i, j] = new GroupBox();
                    this.groupbox[i, j].Controls.Add(this.radiobutton[i, j]);
                    this.groupbox[i, j].Size = new System.Drawing.Size(40, 50);
                    this.groupbox[i, j].Location = new System.Drawing.Point(gb_xpos + j * 46, gb_ypos + i * 56);
                    this.radiobutton[i, j].Size = new System.Drawing.Size(17, 16);
                    this.radiobutton[i, j].Location = new System.Drawing.Point(rd_xpos, rd_ypos);
                    this.groupBox3.Controls.Add(this.groupbox[i, j]);
                    this.radiobutton[i, j].Name = "radiobutton" + (i + j).ToString();
                    this.radiobutton[i, j].CheckedChanged += new EventHandler(this.radiobutton_CheckedChanged);
                }
            }
            for(int i= 0;i<=2;i++)
            {
                for(int j=0;j<=3;j++)
                {
                    this.textbox[i, j] = new TextBox();
                    this.groupBox2.Controls.Add(textbox[i, j]);
                    this.textbox[i, j].Size = new System.Drawing.Size(50, 25);
                    this.textbox[i, j].Location = new System.Drawing.Point(tx_xpos + j * 65, tx_ypos + i * 75);
                    if (j >= 2)
                    {
                        this.textbox[i, j].Text = "0";
                        this.textbox[i, j].Enabled = false;
                    }
                }
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(textBox1.Text);
            int col = Convert.ToInt32(textBox2.Text);
            count = 0;
            for (int i = 0;i< row;i++)
            {
                for(int j= 0;j<col;j++)
                {
                    this.radiobutton[i, j].Checked = false;
                }
            }
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    this.radiobutton[i, j].Enabled = true;
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 3; j++)
                    textbox[i, j].Text = "";
            }
        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            int k = 0;
            int h = 0;
            RadioButton num = (RadioButton)sender;
            int row = Convert.ToInt32(textBox1.Text);
            int col = Convert.ToInt32(textBox2.Text);
            if (num.Checked == true)
                count += 1;
            if (count <= 3)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if(radiobutton[i,j].Checked == true)
                        {
                            textbox[k, h].Text = i.ToString();
                            textbox[k, h + 1].Text = j.ToString();
                            k++;
                            h = 0;
                        }
                        else if(count == 3)
                            this.radiobutton[i, j].Enabled = false;
                    }
                }
            }
            ConvertToCoordination();
        }

        private void ClearAllObjectInGroupBox3()
        {
            while (groupBox3.Controls.Count>0)
            {
                foreach (Control item in radiobutton)
                {
                    item.Dispose();
                }
                foreach (Control item in groupbox)
                {
                    item.Dispose();
                }
            }           
        }

        private void ConvertToCoordination()
        {
            int xinterval = Convert.ToInt32(textBox3.Text);
            int yinterval = Convert.ToInt32(textBox4.Text);
            for(int i = 0;i<=2;i++)
            {
                for(int j = 0;j<=1;j++)
                {
                    if (textbox[i, j].Text != "")
                    {
                        if (j == 0)
                            textbox[i, j + 3].Text = (yinterval * (Convert.ToInt32(textbox[i, j].Text))).ToString();
                        else
                            textbox[i, j + 1].Text = (xinterval * (Convert.ToInt32(textbox[i, j].Text))).ToString();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();
            tri.CreatePoints();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 2; j <= 3; j++)
                {
                    if(j == 2)
                        tri.ptArr[i].xCoord = Double.Parse(textbox[i, j].Text);
                    else
                        tri.ptArr[i].yCoord = Double.Parse(textbox[i, j].Text);
                }
            }
            if (tri.isValid())
            {
                message += ("Area = " + tri.Area().ToString() + Environment.NewLine);
                message += ("Perimeter = " + tri.Perimeter().ToString() + Environment.NewLine);
                switch (tri.ShapeType())
                {
                    case 1:
                        message += ("為直角三角形" + Environment.NewLine);
                        break;
                    case 2:
                        message += ("為銳角三角形" + Environment.NewLine);
                        break;
                    case 3:
                        message += ("為鈍角三角形" + Environment.NewLine);
                        break;
                    default:
                        message += ("Error" + Environment.NewLine);
                        break;
                }

            }
            else
                message += ("此三點無法形成三角形" + Environment.NewLine);
            textBox5.Text = message;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void ClearAlltextboxInGroupbox2()
        {
            while (groupBox2.Controls.Count > 5)
            {
                foreach (Control item in textbox)
                {
                    item.Dispose();
                }
            }
        }
    }
}
