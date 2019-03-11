using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH07_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Complex cNum = new Complex(double.Parse(txt_Real.Text), double.Parse(txt_Imag.Text));
            //Complex result;   //reuslt = null, Error!!
            Complex result=new Complex(0,0); 
            cNum.Power(int.Parse(txt_Power.Text),ref result);
            txt_Result.Text = result.ToString();
        }
    }
}
