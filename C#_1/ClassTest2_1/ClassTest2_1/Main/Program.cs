using ClassTest2_1.Controll;
using ClassTest2_1.Model;
using ClassTest2_1.Util;
using ClassTest2_1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RandData rand = new RandData();
            Menu menu = new Menu();
            CarController carCon = new CarController(rand);
            CustController custCon = new CustController(rand);
            SellController sellCon = new SellController(rand);

            while (true)
            {
                switch (menu.mainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                         switch (menu.subRandMenu())
                         {
                            case Menu.MENU_SUB_RAND_CAR:
                                 carCon.insRandData(menu.getRandSize());
                                break;
                            case Menu.MENU_SUB_RAND_CUST:
                                custCon.insRandData(menu.getRandSize());
                                break;
                            case  Menu.MENU_SUB_RAND_SELL:
                                sellCon.insRandData(menu.getRandSize());
                                break;
                            case  Menu.MENU_SUB_RAND_EXIT:
                                break;
                         }
                         break;
                    case Menu.MENU_MAIN_DEL_ALL:
                        switch (menu.subRemoveMenu())
                         {
                            case Menu.MENU_SUB_REMOVE_CAR:
                        carCon.removeAll();
                                break;
                            case Menu.MENU_SUB_REMOVE_CUST:
                        custCon.removeAll();
                                break;
                            case  Menu.MENU_SUB_REMOVE_SELL:
                        sellCon.removeAll();
                                break;
                            case  Menu.MENU_SUB_REMOVE_EXIT:
                                break;
                         }
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        switch (menu.subViewMenu())
                        {
                            case Menu.MENU_SUB_VIEW_CAR:
                                 carCon.carView();
                                break;
                            case Menu.MENU_SUB_VIEW_CUST:
                                custCon.custView();
                                break;
                            case  Menu.MENU_SUB_VIEW_SELL:
                                sellCon.sellView();
                                break;
                            case  Menu.MENU_SUB_VIEW_EXIT:
                                break;
                        }
                        
                        
                        
                        break;
                    case Menu.MENU_MAIN_ADD:
                        switch (menu.subAddMenu())
                        {
                            case Menu.MENU_SUB_ADD_CAR:
                                 carCon.addCarItem(menu.addCarMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_CUST:
                                custCon.addCustItem(menu.addCustMenu2());
                                break;
                            case  Menu.MENU_SUB_ADD_SELL:
                                sellCon.addSellItem(menu.addSellMenu2());
                                break;
                            case  Menu.MENU_SUB_ADD_EXIT:
                                break;
                        }
                        break;
                    case Menu.MENU_MAIN_DEL:
                        try
                        {
                            switch (menu.subAddMenu())
                            {
                                case Menu.MENU_SUB_DEL_CAR:
                                    carCon.delCarItem(menu.delCarMenu());
                                    break;
                                case Menu.MENU_SUB_DEL_CUST:
                                    custCon.delCustItem(menu.delCustMenu());
                                    break;
                                case  Menu.MENU_SUB_DEL_SELL:
                                     sellCon.delSellItem(menu.delSellMenu());
                                    break;
                                case  Menu.MENU_SUB_DEL_EXIT:
                                    break;
                            }
                        }catch
                        {

                        }
                         
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        switch (menu.subAddMenu())
                        {
                            case Menu.MENU_SUB_UPDATE_CAR:
                                carCon.updateCarItem(menu.updateCarMenu());
                                break;
                            case Menu.MENU_SUB_UPDATE_CUST:
                                custCon.updateCustItem(menu.updateCustMenu());
                                break;
                            case  Menu.MENU_SUB_UPDATE_SELL:
                                 sellCon.updateSellItem(menu.updateSellMenu());
                                break;
                            case  Menu.MENU_SUB_UPDATE_EXIT:
                                break;
                        }
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        }
    }

