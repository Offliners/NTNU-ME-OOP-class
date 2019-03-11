using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_4_2
{
    class Cat
    {
        //Fields
        private string name = "";
        private int shoutNum;
        //Constructors
        public Cat()
        {
            this.name = "無名";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        //Attributes
        public int ShoutNum
        {
            get { return shoutNum; }
            set 
            {
                if (value >= 10)
                    shoutNum = 10;
                else
                    shoutNum = value; 
            }

        }
        //ReadOnly Attribute
        public string Name
        {
            get { return name; }
        }
        //Methods
        public string Shout()
        {
            string str = "我的名字叫" + name;
            for (int i = 0; i < ShoutNum; i++) //ShoutNum 是屬性非欄位
            {
                str += " 喵~";
            }
            return str;
        }
    }
}
