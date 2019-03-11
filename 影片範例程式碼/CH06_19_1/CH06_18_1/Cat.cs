using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_19_1
{
    class Cat
    {
        private string name;

        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args); //宣告委託
        public event CatShoutEventHandler shout;//產生事件物件的參考，其事件類型是委託CatShoutEventHandler

        public Cat(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { name = value; }
            get { return name; } 
        }
        public void Shout()
        {
            Console.WriteLine("我是{0}! 喵~ \n",Name);
            if (shout != null)
            {
                CatShoutEventArgs e=new CatShoutEventArgs();
                e.Name=this.Name;
                shout(this,e);
            }
        }
        public void Catch(object sender,MouseRunEventArgs args)
        {
            Console.WriteLine("我是{0}! {1}別跑! \n", Name,args.Name);
        }
    }

    class CatShoutEventArgs:EventArgs
    {
        private string name;
        public string Name
        {
            set{name=value;}
            get{return name;}
        }
    }
}
