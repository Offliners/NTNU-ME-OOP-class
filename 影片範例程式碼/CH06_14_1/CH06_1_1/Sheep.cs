using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_14_1
{
    class Sheep : Animal
    {
        //Fields
        private static int amount=0;
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
        public static int Amount
        {
            get { return amount; }
        }

        //override Methods
        protected override string getShout()
        {

            return " 咩~";
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
