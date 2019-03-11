using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_17_2
{
    class Cattle : Animal
    {
        //Fields
        private static int amount=0;
        //Constructors
        public Cattle():base()
        {
            aniType = AnimalType.Types.Cattle;
            amount++;
        }
        public Cattle(string name):base(name)
        {
            aniType = AnimalType.Types.Cattle;
            amount++;
        }
        public Cattle(string name,int shout):base(name,shout)
        {
            aniType = AnimalType.Types.Cattle;
            amount++;
        }
        ~Cattle()
        {
            amount--;
        }
        //繼承隱藏 hide inherited attribute
        public static int Amount
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
