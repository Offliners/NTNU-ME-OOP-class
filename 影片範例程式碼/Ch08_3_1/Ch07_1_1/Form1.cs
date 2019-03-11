using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH08_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            double real=0;
            double imag=0;
            int power=0;
            Complex cNum; 
            Complex result;
            try
            {
                real = double.Parse(txt_Real.Text);
                imag = double.Parse(txt_Imag.Text);
                power = int.Parse(txt_Power.Text);
                cNum = new Complex(real, imag);
                result = Complex.Power(cNum, power);
              
            }
            catch (FormatException eF)
            {
                MessageBox.Show(eF.Message);
                return;
            }
            catch (PowerException eN)
            {
                MessageBox.Show(eN.Message);
                return;
            }

           
            txt_Result.Text = result.ToString();
        }

    }
   
}
