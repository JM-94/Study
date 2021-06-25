using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extends_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_animal_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.name = "안준모";
            a.age = 28;
            a.Sleep();
            // a.Eat();
        }

        private void button_cat_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = "나비";
            c.age = 2;
            c.eyeColor = "오드아이";
            c.Sleep();
            c.DailyLottin();
        }

        private void button_dog_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            d.name = "초코";
            d.age = 1;
            d.hairColor = "갈색";
            d.Sleep();
        }

        private void button_animals_Click(object sender, EventArgs e)
        {
            // 다형성
            Animal a = new Cat();
            Animal b = new Dog();

            a.age = 1;
            a.name = "카레";
            if (a is Cat)
            {
                ((Cat)a).eyeColor = "sky";
                (a as Cat).eyeColor = "하늘색";
                (a as Cat).DailyLottin();
                (a as Cat).Sleep();
                a.Sleep();
            }

            var temp = a as Cat;
            if (temp != null)
                temp.DailyLottin();

            b.age = 1;
            b.name = "도그";

            Animal c = new Cat();
            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(b);
            animals.Add(c);

            foreach (var item in animals)
            {
                if (item is Cat)
                    (item as Cat).DailyLottin();
                else
                    item.Sleep();
            }
        }

        private void button_ExInterface_Click(object sender, EventArgs e)
        {
            Fight(new Dog());
            Fight(new Cat());
        }
        private void Fight(IFight f)
        {
            f.Fight();
        }

        // 인터페이스를 몰랐더라면
        private void Fight(Animal f)
        {
            if (f is Cat)
                (f as Cat).Fight();
            if (f is Dog)
                (f as Dog).Fight();
        }
    }
}
