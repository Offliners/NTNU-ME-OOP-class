using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_9_1
{
    class Sheep : Animal
    {
        //Fields
        new private static int amount=0;
        //Constructors
        public Sheep():base()
        {
            amount++;
        }
        public Sheep(string name):base(name)
        {
            amount++;
        }
        public Sheep(string name,int shout):base(name,shout)
        {
            amount++;
        }
        //繼承隱藏 hide inherited attribute
        new public static int Amount
        {
            get { return amount; }
        }

        //override Methods
        public override string Shout()
        {
            string str = "我的名字叫" + name;
            for (int i = 0; i < ShoutNum; i++) //ShoutNum 是屬性非欄位
            {
                str += " 咩~";
            }
            return str;
        }
        public static Sheep Create(string name,int shouts)
        {
            Sheep Sheep=null;
            if (shouts <= 0)
                return Sheep;
            else
            {
                Sheep = new Sheep(name,shouts);
                return Sheep;
            }
        }
    }
}
