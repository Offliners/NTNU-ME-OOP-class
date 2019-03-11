using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH08_1_2
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
            if (!double.TryParse(txt_Real.Text, out real))
            {
                MessageBox.Show("實部格式錯誤!");
                return;
            }
            if (!double.TryParse(txt_Imag.Text, out imag))
            {
                MessageBox.Show("虛部格式錯誤!");
                return;
            }
            if (!int.TryParse(txt_Power.Text, out power))
            {
                MessageBox.Show("次方格式錯誤!");
                return;
            }
            Complex cNum = new Complex(real,imag);
            Complex result = Complex.Power(cNum, power);
            txt_Result.Text = result.ToString();
        }
    }
}
