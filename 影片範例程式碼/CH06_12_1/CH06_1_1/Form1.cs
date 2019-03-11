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

namespace CH06_12_1
{
    public partial class Form1 : Form
    {
        ArrayList aniArr=new ArrayList();
        ArrayList magicAniArr=new ArrayList();
 
        public Form1()
        {
            InitializeComponent();
            txt_ShoutNum.Text = "1";
            cbox_AnimalType.SelectedIndex = 0;
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
                    aniArr.Add(mcat);
                    magicAniArr.Add(mcat);
                    txt_AmountOfCats.Text = Cat.Amount.ToString();
                    txt_AmountOfMagicAnimal.Text = magicAniArr.Count.ToString();
                    break;
                case 5:
                    MagicCattle mcattle = MagicCattle.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text), txt_Thing.Text);
                    if (mcattle == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr.Add(mcattle);
                    magicAniArr.Add(mcattle);
                    txt_AmountOfCattles.Text = Cattle.Amount.ToString();
                    txt_AmountOfMagicAnimal.Text = magicAniArr.Count.ToString();
                    break;
                default:
                    break;
            }
            txt_AmountOfAnimals.Text = aniArr.Count.ToString();
        }

        private void btn_Contest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aniArr.Count;i++ )
            {
                MessageBox.Show(((Animal)aniArr[i]).Shout());
            }
        }

        private void btn_MagicContest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < magicAniArr.Count; i++)
            {
                MessageBox.Show(((IMagic)magicAniArr[i]).ChangeThing());
            }
        }
    }
}