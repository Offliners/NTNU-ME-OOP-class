using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_11_1
{
    class MachineCat:Cat,IMagic
    {
        private string thing = "";
        public MachineCat():base()
        {
        }
        public MachineCat(string name):base(name)
        {
        }
        public MachineCat(string name,int shout):base(name,shout)
        {
        }
         public MachineCat(string name, int shout, string thing)
            : base(name, shout)
        {
            this.thing = thing;
        }
        public string ChangeThing() //實現介面的方法, 不能加上 override
        {
            return base.Shout() + "我有萬能口袋，可以變出:" + thing;
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
    }
}
