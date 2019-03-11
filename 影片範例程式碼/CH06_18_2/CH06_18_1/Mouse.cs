using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_2
{
    class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { name = value; }
            get { return name; } 
        }
        public string Run()
        {
            return "我是" + Name + "，貓來了，快跑!\n";
        }
        public string Help()
        {
            return "我是" + Name + "，貓來了，救命啊!\n";
        }
    }
}
