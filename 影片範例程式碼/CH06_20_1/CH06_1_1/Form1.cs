using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CH06_20_1
{
    public partial class Form1 : Form
    {
        List<Animal> aniArr=new List<Animal>();
 
        public Form1()
        {
            InitializeComponent();
            txt_ShoutNum.Text = "1";
            cbox_AnimalType.SelectedIndex = 0;
            cbox_SortSelect.SelectedIndex = 0;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            int amount = aniArr.Count;
            if (amount >= 10)
            {
                MessageBox.Show("報名額滿!");
                return;
            }
            switch (cbox_AnimalType.SelectedIndex)
            {
                case 0:
                    Cat cat = Cat.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (cat==null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    cat.Order = aniArr.Count;
                    aniArr.Add(cat);
                    txt_AmountOfCats.Text = Cat.Amount.ToString();
                    break;
                case 1:
                    Dog dog = Dog.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (dog==null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    dog.Order = aniArr.Count;
                    aniArr.Add(dog);
                    txt_AmountOfDogs.Text = Dog.Amount.ToString();
                    break;
                case 2:
                    Cattle cattle = Cattle.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (cattle == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    cattle.Order = aniArr.Count;
                    aniArr.Add(cattle);
                    txt_AmountOfCattles.Text = Cattle.Amount.ToString();
                    break;
                case 3:
                    Sheep sheep = Sheep.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (sheep == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    sheep.Order = aniArr.Count;
                    aniArr.Add(sheep);
                    txt_AmountOfSheeps.Text = Sheep.Amount.ToString();
                    break;
                case 4:
                    MachineCat mcat = MachineCat.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text),txt_Thing.Text);
                    if (mcat == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    mcat.Order = aniArr.Count;
                    aniArr.Add(mcat);
                    txt_AmountOfCats.Text = Cat.Amount.ToString();
                    break;
                case 5:
                    MagicCattle mcattle = MagicCattle.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text), txt_Thing.Text);
                    if (mcattle == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    mcattle.Order = aniArr.Count;
                    aniArr.Add(mcattle);
                    txt_AmountOfCattles.Text = Cattle.Amount.ToString();
                    break;
                default:
                    break;
            }
            txt_AmountOfAnimals.Text = aniArr.Count.ToString();
        }

        private void btn_Contest_Click(object sender, EventArgs e)
        {
            Sort();
            RegisterEvent();
            txt_ShoutContest.Text = "";
            txt_ShoutContest.Update();
            txt_MagicContest.Text = "";
            txt_MagicContest.Update();
            foreach (Animal animal in aniArr)
            {
                if (animal != null)
                {
                    txt_ShoutContest.AppendText(animal.Shout()+Environment.NewLine);
                    
                    if (animal is IMagic)
                    {
                        IMagic m = (IMagic)animal;
                        txt_MagicContest.AppendText(m.ChangeThing() + Environment.NewLine);
                    }
                  
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int order = int.Parse(txt_Order.Text);
            if (aniArr.Count <= order)
                return;

            
            
            //回收記憶體，但有時無法回收這是因為此物件仍然被委託所使用
            aniArr[order] = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //移除 List
            aniArr.RemoveAt(int.Parse(txt_Order.Text));
            txt_AmountOfCats.Text = Cat.Amount.ToString();
            txt_AmountOfDogs.Text = Dog.Amount.ToString();
            txt_AmountOfCattles.Text = Cattle.Amount.ToString();
            txt_AmountOfSheeps.Text = Sheep.Amount.ToString();
            txt_AmountOfAnimals.Text = aniArr.Count.ToString();
        }
        private void RegisterEvent()
        {
            foreach (Animal mAni in aniArr)
            {
                if (mAni is MachineCat)
                {
                    MachineCat mCat = (MachineCat)mAni;
                    mCat.RemoveAllEvent();
                    foreach (Animal ani in aniArr)
                    {
                        if ((ani is Cat)&&!(ani is MachineCat))
                        {
                            Cat cat = ani as Cat;
                            mCat.change += new MachineCat.ChangeThingDelegate(cat.Clap);
                        }
                    }
                }
            }
        }
        private void Sort()
        {
            switch (cbox_SortSelect.SelectedIndex)
            {
                case 0:
                    aniArr.Sort(CompareByOrder);
                    break;
                case 1:
                    aniArr.Sort(CompareByType);
                    break;
                default:
                    break;
            }
        }

        
        private int CompareByOrder(Animal a,Animal b)
        {
            if (a.Order > b.Order)
                return 1;
            else
                return -1;
        }
        private int CompareByType(Animal a, Animal b)
        {
            if (a.AniType > b.AniType)
                return 1;
            else
                return -1;
        }
    }
}
