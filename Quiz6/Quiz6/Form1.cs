using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            string shape = comboBox2.SelectedItem.ToString();
            switch(shape)
            {
                case "球":
                    Ball ball = new Ball(Double.Parse(textBox2.Text), Double.Parse(textBox1.Text));            
                    textBox8.AppendText(ball.ShapeProperty());
                    break;
                case "立方體":
                    Cube cube = new Cube(Double.Parse(textBox2.Text), Double.Parse(textBox1.Text));                
                    textBox8.AppendText(cube.ShapeProperty());
                    break;
                case "圓柱體":
                    Cylinder cylinder = new Cylinder(Double.Parse(textBox2.Text), Double.Parse(textBox9.Text), Double.Parse(textBox1.Text));             
                    textBox8.AppendText(cylinder.ShapeProperty());
                    break;
                case "金字塔":
                    Pyramid pyramid = new Pyramid(Double.Parse(textBox2.Text), Double.Parse(textBox9.Text), Double.Parse(textBox1.Text));              
                    textBox8.AppendText(pyramid.ShapeProperty());
                    break;
                default:
                    break;
            }
            textBox8.AppendText("\r\n");
            textBox3.Text = (Ball.Amount + Cube.Amount + Cylinder.Amount + Pyramid.Amount).ToString();
            textBox4.Text = Ball.Amount.ToString();
            textBox5.Text = Cube.Amount.ToString();
            textBox6.Text = Cylinder.Amount.ToString();
            textBox7.Text = Pyramid.Amount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = comboBox1.SelectedItem.ToString();
            double density;
            bool enable = false;
            switch(material)
            {
                case "鋁":
                    density = 2.7;
                    break;
                case "鐵":
                    density = 7.87;
                    break;
                case "鉛":
                    density = 11.3;
                    break;
                case "請自行輸入":
                    enable = true;
                    density = Double.Parse(textBox1.Text);
                    break;
                default:
                    density = 0;
                    break;
            }
            textBox1.Text = density.ToString();
            if (enable == false)
                textBox1.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = comboBox2.SelectedItem.ToString();
            switch(shape)
            {
                case "球":
                    label9.Text = "半徑";
                    label10.Visible = false;
                    textBox9.Visible = false;
                    break;
                case "立方體":
                    label9.Text = "邊長";
                    label10.Visible = false;
                    textBox9.Visible = false;
                    break;
                case "圓柱體":
                    label9.Text = "半徑";
                    label10.Text = "高度";
                    label10.Visible = true;
                    textBox9.Visible = true;
                    break;
                case "金字塔":
                    label9.Text = "邊長";
                    label10.Text = "高度";
                    label10.Visible = true;
                    textBox9.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
