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
    public partial class ChildForm : Form
    {
        public delegate void StringEvent(object sender, SetEvent args);
        public event StringEvent stringevent; 

        public ChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stringevent != null)
            {
                SetEvent setEvent = new SetEvent();
                setEvent.Str = textBox1.Text;
                stringevent(button1,setEvent);
            }
        }
    }
}
