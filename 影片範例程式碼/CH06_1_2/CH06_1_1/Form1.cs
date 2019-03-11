using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CatShout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Shout());
        }

        private void btn_CatShout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Shout());
        }
        private void btn_CatShout3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Shout());
        }

        private string Shout()
        {
            return "我的名字是咪咪，喵~";
        }



    }
}
