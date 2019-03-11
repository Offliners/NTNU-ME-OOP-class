using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH08_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double real;
            double imag;
            int power;
            real = double.Parse(txt_Real.Text);
            imag = double.Parse(txt_Imag.Text);
            power = int.Parse(txt_Power.Text);

            Complex cNum = new Complex(real,imag);
            Complex result = Complex.Power(cNum, power);
            txt_Result.Text = result.ToString();
        }
    }
}
