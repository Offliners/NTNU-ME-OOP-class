using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_18_1
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
            if(shoutDelegate!=null)      //如果委託沒有綁到任何函式，其值為 null
                str += shoutDelegate();  //呼叫委託
            return str;
        }
    }
}
