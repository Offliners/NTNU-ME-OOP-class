using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_2
{
    class Cat
    {
        private string name;

        public delegate string EventDelegate(); //宣告委託
        public EventDelegate shoutDelegate;//產生委託物件的參考

        public Cat(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { name = value; }
            get { return name; } 
        }
        public string Shout()
        {
            string str="我是" + Name + "! 喵~" +'\n';
            if (shoutDelegate != null)
            {
                foreach(EventDelegate single in shoutDelegate.GetInvocationList())
                    str += single();  //呼叫委託
            }
            return str;
        }
    }
}
