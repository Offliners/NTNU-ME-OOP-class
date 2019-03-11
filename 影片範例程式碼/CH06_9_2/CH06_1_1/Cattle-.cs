using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_9_2
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
        protected override string getShout()
        {

            return " 哞~";
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
