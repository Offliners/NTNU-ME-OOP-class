using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midexam
{
    public partial class Form1 : Form
    {
        private List<Shape3D> shapeArr = new List<Shape3D>();
        private delegate bool CompareFunction(Shape3D a, Shape3D b);
        private Shapetype.Material _mtype;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shape = comboBox2.SelectedItem.ToString();
            switch(shape)
            {
                case "球":
                    shapeArr.Add(new Ball(Double.Parse(textBox2.Text), _mtype));
                    break;
                case "立方體":
                    shapeArr.Add(new Cube(Double.Parse(textBox2.Text), _mtype));
                    break;
                case "圓柱體":
                    shapeArr.Add(new Cylinder(Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), _mtype));
                    break;
                case "金字塔":
                    shapeArr.Add(new Pyramid(Double.Parse(textBox2.Text), Double.Parse(textBox3.Text), _mtype));
                    break;
                default:
                    break;
            }
            textBox4.Text = Shape3D.Amount.ToString();
            textBox5.Text = Ball.Amount.ToString();
            textBox6.Text = Cube.Amount.ToString();
            textBox7.Text = Cylinder.Amount.ToString();
            textBox8.Text = Pyramid.Amount.ToString();
            ShowAllInformation(textBox9);
        }

        public void ShowAllInformation(TextBox msg)
        {
            string info = "";
            foreach(var shape in shapeArr)
                info += (shape.ShapeProperty() + "\r\n");
            msg.Text = info;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = comboBox1.SelectedItem.ToString();
            _mtype = MaterialTable.MarerialType(material);
            textBox1.Text = MaterialTable.Density(material).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shape = comboBox2.SelectedItem.ToString();
            switch(shape)
            {
                case "球":
                    label4.Text = "半徑";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    break;
                case "立方體":
                    label4.Text = "邊長";
                    label5.Visible = false;
                    textBox3.Visible = false;
                    break;
                case "圓柱體":
                    label4.Text = "半徑";
                    label5.Text = "高度";
                    label5.Visible = true;
                    textBox3.Visible = true;
                    break;
                case "金字塔":
                    label4.Text = "邊長";
                    label5.Text = "高度";
                    label5.Visible = true;
                    textBox3.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void BubbleSort(CompareFunction cmp)
        {
            Shape3D temp;
            for(int pass = 0; pass<shapeArr.Count;pass++)
            {
                for(int i = 0;i<shapeArr.Count-1; i++)
                {
                    if(cmp(shapeArr[i],shapeArr[i+1]))
                    {
                        temp = shapeArr[i];
                        shapeArr[i] = shapeArr[i + 1];
                        shapeArr[i + 1] = temp;
                    }
                }
            }
        }

        private bool CompareShapeAscent(Shape3D a,Shape3D b)
        {
            if (a.ShapeType > b.ShapeType)
                return true;
            else
                return false;
        }

        private bool CompareShapeDescent(Shape3D a, Shape3D b)
        {
            if (a.ShapeType < b.ShapeType)
                return true;
            else
                return false;
        }

        private bool CompareMaterialAscent(Shape3D a, Shape3D b)
        {
            if (a.MaterialType > b.MaterialType)
                return true;
            else
                return false;
        }

        private bool CompareMaterialDescent(Shape3D a, Shape3D b)
        {
            if (a.MaterialType < b.MaterialType)
                return true;
            else
                return false;
        }

        private bool CompareVolumnAscent(Shape3D a, Shape3D b)
        {
            if (a.Volumn() > b.Volumn())
                return true;
            else
                return false;
        }

        private bool CompareVolumnDescent(Shape3D a, Shape3D b)
        {
            if (a.Volumn() < b.Volumn())
                return true;
            else
                return false;
        }

        private bool CompareWeightAscent(Shape3D a, Shape3D b)
        {
            if (a.Weight() > b.Weight())
                return true;
            else
                return false;
        }

        private bool CompareWeightDescent(Shape3D a, Shape3D b)
        {
            if (a.Weight() < b.Weight())
                return true;
            else
                return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select = comboBox3.SelectedItem.ToString();
            switch(select)
            {
                case "形狀":
                    if (radioButton1.Checked == true)
                        BubbleSort(CompareShapeAscent);
                    else
                        BubbleSort(CompareShapeDescent);
                    break;
                case "材質":
                    if (radioButton1.Checked == true)
                        BubbleSort(CompareMaterialAscent);
                    else
                        BubbleSort(CompareMaterialDescent);
                    break;
                case "體積":
                    if (radioButton1.Checked == true)
                        BubbleSort(CompareVolumnAscent);
                    else
                        BubbleSort(CompareVolumnDescent);
                    break;
                case "重量":
                    if (radioButton1.Checked == true)
                        BubbleSort(CompareWeightAscent);
                    else
                        BubbleSort(CompareWeightDescent);
                    break;
                default:
                    break;
            }
            ShowAllInformation(textBox10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string info = "";
            IRollable Roll = null;
            List<IRollable> RollableShape = new List<IRollable>();
            foreach(var obj in shapeArr)
            {
                Roll = obj as IRollable;
                if (Roll != null)
                    RollableShape.Add(Roll);
            }
            RollableShape.Sort(CompareDistance);
            foreach(var rollshpae in RollableShape)
            {
                info += (rollshpae.RollableShapeProperty() + string.Format("{0,8:F2}",rollshpae.Distance()) + "\r\n");
            }
            textBox11.Text = info;
        }

        private int CompareDistance(IRollable a, IRollable b)
        {
            if (a.Distance() < b.Distance())
                return 1;
            else
                return -1;
        }
    }
}
