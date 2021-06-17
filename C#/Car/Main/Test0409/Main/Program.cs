using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0409.Model;
using Test0409.Util;
using Test0409.View;
using Test0409.Controll;

namespace Test0409
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            확인용
            Console.WriteLine(new Car().ToString());
            new Customer("홍길동", 100, "010 - 1234 - 1234", "대구 북구 침산동", '남').CoutomerInfo();
            Console.WriteLine();
            Console.WriteLine(new Seller("전우치", "010-4321-4321", "대리", "산격점").ToString());
            */

            RandData rand = new RandData();
            Menu menu = new Menu();
            CarController carCon = new CarController(rand);
            while (true)
            {
                switch (menu.MainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                        carCon.insRandData(menu.getRandSize());
                        break;
                    case Menu.MENU_MAIN_DEL_ALL:

                        break;
                    case Menu.MENU_MAIN_VIEW:
                        cc.carView();
                        break;
                    case Menu.MENU_MAIN_ADD:

                        break;
                    case Menu.MENU_MAIN_DEL:

                        break;
                    case Menu.MENU_MAIN_UPDATE:

                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }

    }
}

