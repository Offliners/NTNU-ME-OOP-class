using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch07_1_1
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
            Complex result = Complex.Power(cNum, int.Parse(txt_Power.Text));
            txt_Result.Text = result.ToString();
        }
    }
}
