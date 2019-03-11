using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_6_1
{
    class Dog
    {
        //Fields
        private string name = "";
        private int shoutNum;
        private static int amount=0;
        //Constructors
        public Dog()
        {
            this.name = "無名";
            amount++;
        }
        public Dog(string name)
        {
            this.name = name;
            amount++;
        }
        public Dog(string name,int shout)
        {
            if (name=="")
                this.name = "無名";
            else
                this.name = name;
            ShoutNum = shout;
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
                str += " 汪~";
            }
            return str;
        }
        public static Dog Create(string name,int shouts)
        {
            Dog dog=null;
            if (shouts <= 0)
                return dog;
            else
            {
                dog = new Dog(name,shouts);
                return dog;
            }
        }
    }
}
