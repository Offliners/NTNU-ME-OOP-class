using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_3
{
    class Cat
    {
        private string name;

        public delegate void EventDelegate(); //宣告委託
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
        public void Shout()
        {
            Console.WriteLine("我是{0}! 喵~ \n",Name);
            if (shoutDelegate != null)
                shoutDelegate();
            
        }
    }
}
