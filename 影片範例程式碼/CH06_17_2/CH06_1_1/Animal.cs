using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_17_2
{
    abstract class Animal
    {
        //Fields
        protected string name = "";
        protected int shoutNum;
        protected int order;
        protected AnimalType.Types aniType;
        
        //Constructors
        public Animal()
        {
            this.name = "無名";
        }
        public Animal(string name)
        {
            this.name = name;
        }
        public Animal(string name,int shout)
        {
            if (name=="")
                this.name = "無名";
            else
                this.name = name;
            ShoutNum = shout;
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
        public int Order
        {
            get { return order; }
            set
            {
                order = value;
            }
        }
        public int AniType
        {
            get { return (int)aniType; }
        }
        //ReadOnly Attribute
        public string Name
        {
            get { return name; }
        }
       
        public string Shout()
        {
            string str = "我的名字叫" + name;
            for (int i = 0; i < ShoutNum; i++) //ShoutNum 是屬性非欄位
            {
                str += getShout();
            }
            return str;
        }
        //Virtual Methods
        protected abstract string getShout();
    }

    static class AnimalType
    {
        public enum Types { Unknown = 0, Cat, Dog, Cattle, Sheep, MachineCat, MagicCattle };
    }
}
