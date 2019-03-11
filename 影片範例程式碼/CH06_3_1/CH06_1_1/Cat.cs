using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_3_1
{
    class Cat
    {
        private string name = "";
        public Cat()
        {
            this.name = "無名";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        public string Shout(int ShoutNum)
        {
            string str = "我的名字叫" + name;
            for (int i = 0; i < ShoutNum; i++)
            {
                str += " 喵~";
            }
            return str;
        }
        public string Shout()
        {
            return "我的名字叫" + name + " 喵~";
        }
    }
}
