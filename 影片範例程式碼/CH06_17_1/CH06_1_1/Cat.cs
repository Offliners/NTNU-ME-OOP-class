using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CH06_17_1
{
    class Cat : Animal
    {
        //Fields
        private static int amount=0;
        //Constructors
        public Cat():base()
        {
            aniType = AnimalType.Types.Cat;
            amount++;
        }
        public Cat(string name):base(name)
        {
            aniType = AnimalType.Types.Cat;
            amount++;
        }
        public Cat(string name,int shout):base(name,shout)
        {
            aniType = AnimalType.Types.Cat;
            amount++;
        }

        ~Cat()
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
        
            return " 喵~";
        }
        public static Cat Create(string name,int shouts)
        {
            Cat cat=null;
            if (shouts <= 0)
                return cat;
            else
            {
                cat = new Cat(name,shouts);
                return cat;
            }
        }
    }
}
