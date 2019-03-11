using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_9_1
{
    class Cattle : Animal
    {
        //Fields
        new private static int amount=0;
        //Constructors
        public Cattle():base()
        {
            amount++;
        }
        public Cattle(string name):base(name)
        {
            amount++;
        }
        public Cattle(string name,int shout):base(name,shout)
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
                str += " 哞~";
            }
            return str;
        }
        public static Cattle Create(string name,int shouts)
        {
            Cattle Cattle=null;
            if (shouts <= 0)
                return Cattle;
            else
            {
                Cattle = new Cattle(name,shouts);
                return Cattle;
            }
        }
    }
}
