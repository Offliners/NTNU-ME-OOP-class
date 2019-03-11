using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06_19_1
{
    class Mouse
    {
        private string name;
        public delegate void MouseRunEventHandler(object sender, MouseRunEventArgs args); //宣告委託
        public event MouseRunEventHandler run;//產生事件物件的參考，其事件類型是委託MouseRunEventHandler
        public Mouse(string name)
        {
            this.name = name;
        }
        public string Name
        {
            set { name = value; }
            get { return name; } 
        }
        public void Run(object sender,CatShoutEventArgs args)
        {
            Console.WriteLine("我是{0},{1}來了，快跑!\n",Name,args.Name);
            if (run != null)
            {
                MouseRunEventArgs e = new MouseRunEventArgs();//宣告事件參數
                e.Name = this.Name;
                run(this,e);//事件Run觸發, 通知所有登記過的物件，並將發送通知的自己this以及參數Args傳遞出去
            }
        }
        public void Help(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine("我是{0},{1}來了，救命啊!\n", Name,args.Name);
        }
    }
    class MouseRunEventArgs : EventArgs
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
    }
}
