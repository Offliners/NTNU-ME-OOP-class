﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_9_1
{
    class Animal
    {
        //Fields
        protected string name = "";
        protected int shoutNum;
        protected static int amount=0;
        //Constructors
        public Animal()
        {
            this.name = "無名";
            amount++;
        }
        public Animal(string name)
        {
            this.name = name;
            amount++;
        }
        public Animal(string name,int shout)
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
        //Virtual Methods
        public virtual string Shout()
        {
            return "";
        }
    }
}
