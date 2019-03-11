using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_8_1
{
    public partial class Form1 : Form
    {
        Animal[] aniArr = new Animal[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            int amount = Animal.Amount;
            if (Animal.Amount >= 5)
            {
                MessageBox.Show("報名額滿!");
                return;
            }
            switch (cbox_AnimalType.SelectedIndex)
            {
                case 0:
                    Cat cat = Cat.Create(txt_CatName.Text, int.Parse(txt_CatShoutNum.Text));
                    if (cat==null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = cat;
                    break;
                case 1:
                    Dog dog = Dog.Create(txt_CatName.Text, int.Parse(txt_CatShoutNum.Text));
                    if (dog==null)
                    {
                        MessageBox.Show("報名失敗!");
                        return;
                    }
                    aniArr[amount] = dog;
                    break;
                default:
                    break;
            }
            txt_AmountOfCats.Text = Cat.Amount.ToString();
            txt_AmountOfDogs.Text = Dog.Amount.ToString();
            txt_AmountOfAnimals.Text = Animal.Amount.ToString();
        }

        private void btn_Contest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Animal.Amount; i++)
            {
                MessageBox.Show(aniArr[i].Shout());
               // MessageBox.Show(aniArr[i].Hello());  //子類別以父類別的的身分出現時，子類別特有的屬性跟方法不可以使用
            }
        }
    }
}
