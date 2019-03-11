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
    public partial class ChildForm : Form
    {
        public delegate void ChildFormEvent(string str);
        public ChildFormEvent childform;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (childform != null)
                childform(textBox1.Text);
        }
    }
}
