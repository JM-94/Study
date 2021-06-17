using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0409.View
{
    class Menu
    {
        public const int MENU_MAIN_RAND = 1;
        public const int MENU_MAIN_DEL_ALL = 2;
        public const int MENU_MAIN_VIEW = 3;
        public const int MENU_MAIN_ADD = 4;
        public const int MENU_MAIN_DEL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;

        public int MainMenu()
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("고객차량관리 앱 V1.0");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. 랜덤데이터 생성");
            Console.WriteLine("2. 모든 데이터 삭제");
            Console.WriteLine("3. 데이터 보기");
            Console.WriteLine("4. 데이터 추가");
            Console.WriteLine("5. 데이터 삭제");
            Console.WriteLine("6. 데이터 수정");
            Console.WriteLine("7. 앱 종료");
            Console.WriteLine("--------------------");
            Console.Write("Main메뉴 선택 : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void getRandSize()
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("랜덤 데이터 갯수 설정");
            Console.WriteLine("--------------------");
            Console.WriteLine("갯수 입력 : ");
            Console.WriteLine("--------------------");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}


