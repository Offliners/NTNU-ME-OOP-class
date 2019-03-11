using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH07_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Complex[] cNumArr = new Complex[4];
            Complex cNum1 = new Complex(double.Parse(txt_Real1.Text), double.Parse(txt_Imag1.Text));
            Complex cNum2 = new Complex(double.Parse(txt_Real2.Text), double.Parse(txt_Imag2.Text));
            Complex cNum3 = new Complex(double.Parse(txt_Real3.Text), double.Parse(txt_Imag3.Text));
            Complex cNum4 = new Complex(double.Parse(txt_Real4.Text), double.Parse(txt_Imag4.Text));
            cNumArr[0] = cNum1;
            cNumArr[1] = cNum2;
            cNumArr[2] = cNum3;
            cNumArr[3] = cNum4;
            txt_Result.AppendText(Complex.Multiply(cNum1, cNum2).ToString()+"\r\n");
            txt_Result.AppendText(Complex.Multiply(cNum1, cNum2, cNum3).ToString() + "\r\n");
            txt_Result.AppendText(Complex.Multiply(cNum1, cNum2, cNum3, cNum4).ToString() + "\r\n");
            txt_Result.AppendText(Complex.Multiply(cNumArr).ToString() + "\r\n");
        }
    }
}
