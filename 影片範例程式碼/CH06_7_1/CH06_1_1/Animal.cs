using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_7_2
{
    class Animal
    {
        //Fields
        protected string name = "";
        protected int shoutNum;
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
        //ReadOnly Attribute
        public string Name
        {
            get { return name; }
        }
    }
}
