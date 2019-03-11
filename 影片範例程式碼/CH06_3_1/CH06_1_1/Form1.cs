using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CatShout_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat();
            if (txt_ShoutNum.Text == "")
                MessageBox.Show(cat.Shout());
            else
                MessageBox.Show(cat.Shout(int.Parse(txt_ShoutNum.Text)));

        }

        private void btn_CatShout2_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("大肥貓");
            if (txt_ShoutNum.Text == "")
                MessageBox.Show(cat.Shout());
            else
                MessageBox.Show(cat.Shout(int.Parse(txt_ShoutNum.Text)));
        }
        private void btn_CatShout3_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("凱蒂");
            if (txt_ShoutNum.Text == "")
                MessageBox.Show(cat.Shout());
            else
                MessageBox.Show(cat.Shout(int.Parse(txt_ShoutNum.Text)));
        }

    }
}
