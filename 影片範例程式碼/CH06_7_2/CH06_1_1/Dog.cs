using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_7_1
{
    class Dog:Animal
    {
        //Fields
        new private static int amount=0;
        //Constructors
        public Dog():base()
        {
            amount++;
        }
        public Dog(string name):base(name)
        {
            amount++;
        }
        public Dog(string name,int shout):base(name,shout)
        {
            amount++;
        }

        //ReadOnly Attribute
 
        new public static int Amount
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
