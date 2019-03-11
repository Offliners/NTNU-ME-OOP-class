using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_3
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
        public void Run()
        {
            Console.WriteLine("我是{0},貓來了，快跑!\n",Name);
        }
        public void Help()
        {
            Console.WriteLine("我是{0},貓來了，救命啊!\n", Name);
        }
    }
}
