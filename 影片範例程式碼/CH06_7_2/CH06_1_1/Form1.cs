using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH06_7_1
{
    public partial class Form1 : Form
    {
        Cat[] catArr = new Cat[3];
        Dog[] dogArr = new Dog[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            int amount = Cat.Amount;
            if (Cat.Amount >= 3)
            {
                MessageBox.Show("報名額滿!");
                return;
            }
            Cat cat = Cat.Create(txt_CatName.Text, int.Parse(txt_CatShoutNum.Text));
            if (cat==null)
            {
                MessageBox.Show("報名失敗!");
                return;
            }

            catArr[amount] = cat;
            txt_AmountOfAnimals.Text = Animal.Amount.ToString();
            txt_AmountOfCats.Text = Cat.Amount.ToString();
        }

        private void btn_Contest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Cat.Amount; i++)
            {
                MessageBox.Show(catArr[i].Shout());
            }
            for (int i = 0; i < Dog.Amount; i++)
            {
                MessageBox.Show(dogArr[i].Shout());
            }
        }

        private void btn_DogSignUp_Click(object sender, EventArgs e)
        {
            int amount = Dog.Amount;
            if (Dog.Amount >= 3)
            {
                MessageBox.Show("報名額滿!");
                return;
            }
            Dog dog = Dog.Create(txt_DogName.Text, int.Parse(txt_DogShoutNum.Text));
            if (dog == null)
            {
                MessageBox.Show("報名失敗!");
                return;
            }

            dogArr[amount] = dog;
            txt_AmountOfAnimals.Text = Animal.Amount.ToString();
            txt_AmountOfDogs.Text = Dog.Amount.ToString();
        }
    }
}
