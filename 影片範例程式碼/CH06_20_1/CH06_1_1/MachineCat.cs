using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_20_1
{
    class MachineCat:Cat,IMagic
    {
        private string thing = "";
        public delegate string ChangeThingDelegate();
        public ChangeThingDelegate change;
        public MachineCat():base()
        {
            aniType = AnimalType.Types.MachineCat;
        }
        public MachineCat(string name):base(name)
        {
            aniType = AnimalType.Types.MachineCat;
        }
        public MachineCat(string name,int shout):base(name,shout)
        {
            aniType = AnimalType.Types.MachineCat;
        }
         public MachineCat(string name, int shout, string thing)
            : base(name, shout)
        {
            aniType = AnimalType.Types.MachineCat;
            this.thing = thing;
        }
        public string ChangeThing() //實現介面的方法, 不能加上 override
        {
            string str=base.Shout() + "我有萬能口袋，可以變出:" + thing+"\r\n"; // \r\n 可在textbox中進行換行
            if (change != null)
            {
                foreach (ChangeThingDelegate single in change.GetInvocationList())
                {
                    str += (single() + "\r\n");
                }
            }
            return str;
        }
        new public static MachineCat Create(string name, int shouts)
        {
            MachineCat cat = null;
            if (shouts <= 0)
                return cat;
            else
            {
                cat = new MachineCat(name, shouts);
                return cat;
            }
        }
        public static MachineCat Create(string name, int shouts,string thing)
        {
            MachineCat cat = null;
            if (shouts <= 0)
                return cat;
            else
            {
                cat = new MachineCat(name, shouts,thing);
                return cat;
            }
        }
        public void RemoveAllEvent()
        {
            if (change == null)
                return;
         
            change = null;
        }
    }
}
