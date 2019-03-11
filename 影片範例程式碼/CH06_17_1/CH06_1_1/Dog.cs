using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_17_1

{
    class Dog:Animal
    {
        //Fields
    
        private static int amount=0;
        //Constructors
        public Dog():base()
        {
            aniType = AnimalType.Types.Dog;
            amount++;
        }
        public Dog(string name):base(name)
        {
            aniType = AnimalType.Types.Dog;
            amount++;
        }
        public Dog(string name,int shout):base(name,shout)
        {
            aniType = AnimalType.Types.Dog;
            amount++;
        }
        ~Dog()
        {
            amount--;
        }
        public static int Amount
        {
            get { return amount; }
        }
        //override Methods
        protected override string getShout()
        {

            return " 汪~";
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
