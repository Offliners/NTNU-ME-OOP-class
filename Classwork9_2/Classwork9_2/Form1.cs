using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.Show();
            childForm.stringevent += new ChildForm.StringEvent(ShowMessgae);
        }

        private void ShowMessgae(object sender,SetEvent args)
        {
            textBox1.Text = args.Str;
        }
    }
}
