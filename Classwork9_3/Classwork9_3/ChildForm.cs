using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork9_3
{
    public partial class ChildForm : Form
    {
        public Form1 mainForm;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm != null)
                mainForm.ShowMessgae(textBox1.Text);
        }
    }
}
