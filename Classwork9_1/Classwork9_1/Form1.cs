using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork9_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm ChildForm = new ChildForm();
            ChildForm.Show();
            ChildForm.childform += new ChildForm.ChildFormEvent(ShowMessage);
        }

        private void ShowMessage(string str)
        {
            textBox1.Text = str;
        }
    }
}
