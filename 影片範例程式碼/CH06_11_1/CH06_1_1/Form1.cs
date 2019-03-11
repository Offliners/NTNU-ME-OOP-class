﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_11_1
{
    public partial class Form1 : Form
    {
        Animal[] aniArr = new Animal[10];
        IMagic[] magicAniArr = new IMagic[10];
        private static int amountOfMagicAnimal = 0;
 
        public Form1()
        {
            InitializeComponent();
            txt_ShoutNum.Text = "1";
            cbox_AnimalType.SelectedIndex = 0;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            int amount = Animal.Amount;
            if (Animal.Amount >= 10)
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
                    aniArr[amount] = cat;
                    txt_AmountOfCats.Text = Cat.Amount.ToString();
                    break;
                case 1:
                    Dog dog = Dog.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (dog==null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = dog;
                    txt_AmountOfDogs.Text = Dog.Amount.ToString();
                    break;
                case 2:
                    Cattle cattle = Cattle.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (cattle == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = cattle;
                    txt_AmountOfCattles.Text = Cattle.Amount.ToString();
                    break;
                case 3:
                    Sheep sheep = Sheep.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text));
                    if (sheep == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = sheep;
                    txt_AmountOfSheeps.Text = Sheep.Amount.ToString();
                    break;
                case 4:
                    MachineCat mcat = MachineCat.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text),txt_Thing.Text);
                    if (mcat == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = mcat;
                    magicAniArr[amountOfMagicAnimal] = mcat;
                    amountOfMagicAnimal++;
                    txt_AmountOfCats.Text = Cat.Amount.ToString();
                    txt_AmountOfMagicAnimal.Text = amountOfMagicAnimal.ToString();
                    break;
                case 5:
                    MagicCattle mcattle = MagicCattle.Create(txt_CatName.Text, int.Parse(txt_ShoutNum.Text), txt_Thing.Text);
                    if (mcattle == null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = mcattle;
                    magicAniArr[amountOfMagicAnimal] = mcattle;
                    amountOfMagicAnimal++;
                    txt_AmountOfCattles.Text = Cattle.Amount.ToString();
                    txt_AmountOfMagicAnimal.Text = amountOfMagicAnimal.ToString();
                    break;
                default:
                    break;
            }
            txt_AmountOfAnimals.Text = Animal.Amount.ToString();
        }

        private void btn_Contest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Animal.Amount; i++)
            {
                MessageBox.Show(aniArr[i].Shout());
            }
        }

        private void btn_MagicContest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amountOfMagicAnimal; i++)
            {
                MessageBox.Show(magicAniArr[i].ChangeThing());
            }
        }
    }
}
