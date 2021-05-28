using System;
using Test0409.Controll;
using Test0409.Model;
using Test0409.Util;
using Test0409.View;

namespace Test0409
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Car().ToString());
            //new Customer("홍길동", 100, "010-1234-1234", "조선 한양 홍대감댁", '남').CustomerInfo();
            //Console.WriteLine(new Seller("전우치", "010-1111-1111", "과장", "동대구영업소").ToString());

            RandData rand = new RandData();
            Menu menu = new Menu();

           
            
            //carc.insRandData(num);


            CarController carc = new CarController(rand);

            while (true)
            {
                //menu.mainMenu();
                switch (menu.mainMenu())
                {
                    case 1:
                        carc.insRandData(menu.getRandSize());
                        break;
                    case 2:
                        CarController.removeAll();
                        break;
                    case 3:
                        carc.carView();
                        break;
                    case 4:
                        CarController.addCarItem(menu.add
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;

                }

            }

        }
    }
}
