using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_5_1
{
    class Cat
    {
        //Fields
        private string name = "";
        private int shoutNum;
        private static int amount=0;
        //Constructors
        public Cat()
        {
            this.name = "無名";
            amount++;
        }
        public Cat(string name)
        {
            this.name = name;
            amount++;
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
        public static int Amount
        {
            get { return amount; }
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
