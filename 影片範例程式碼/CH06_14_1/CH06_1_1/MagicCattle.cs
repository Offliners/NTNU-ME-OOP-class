using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_14_1
{
    class MagicCattle:Cattle,IMagic
    {
        private string thing = "";
        public MagicCattle():base()
        {
        }
        public MagicCattle(string name):base(name)
        {
        }
        public MagicCattle(string name,int shout):base(name,shout)
        {
        }
        public MagicCattle(string name, int shout, string thing)
            : base(name, shout)
        {
            this.thing = thing;
        }
        new public static MagicCattle Create(string name, int shouts)
        {
            MagicCattle cattle = null;
            if (shouts <= 0)
                return cattle;
            else
            {
                cattle = new MagicCattle(name, shouts);
                return cattle;
            }
        }
        public static MagicCattle Create(string name, int shouts,string thing)
        {
            MagicCattle cattle = null;
            if (shouts <= 0)
                return cattle;
            else
            {
                cattle = new MagicCattle(name, shouts,thing);
                return cattle;
            }
        }
        public string ChangeThing() //實現介面的方法, 不能加上 override
        {
            return base.Shout() + "我手持混鐵棒，可以變出:" + thing;
        }
    }
}
