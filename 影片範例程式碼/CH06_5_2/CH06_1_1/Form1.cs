using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_5_2
{
    public partial class Form1 : Form
    {
        Cat[] catArr = new Cat[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            int amount = Cat.Amount;
            if (Cat.Amount >= 3)
            {
                MessageBox.Show("報名額滿!");
                return;
            }
            Cat cat = Cat.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
            if (cat==null)
            {
                MessageBox.Show("報名失敗!");
                return;
            }

            catArr[amount] = cat;
           
            txt_AmoutOfCats.Text = Cat.Amount.ToString();
        }

        private void btn_Contest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Cat.Amount; i++)
            {
                MessageBox.Show(catArr[i].Shout());
            }
        }
    }
}
