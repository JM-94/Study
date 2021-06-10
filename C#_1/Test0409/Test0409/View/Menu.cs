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

       

        public int mainMenu()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("고객 차량 관리 앱 v1.0");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. 랜덤 데이어 생성");
            Console.WriteLine("2. 모든 데이터 삭제");
            Console.WriteLine("3. 데이터 보기");
            Console.WriteLine("4. 데이터 추가");
            Console.WriteLine("5. 데이터 삭제");
            Console.WriteLine("6. 데이터 수정");
            Console.WriteLine("7. 앱 종료");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Main 메뉴 선택");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int getRandSize()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("랜덤데이터 갯수 설정 v1.0");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("갯수 입력");
            return Convert.ToInt32(Console.ReadLine());
        }

        public string[] addCarMenu()
        {
            string[] data = new string[4];
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Car 데이터 추가");
            Console.WriteLine("--------------------------------------");
            Console.Write("1. 차종 : ");
            data[0] = Console.ReadLine();
            Console.Write("2. 색상");
            data[1] = Console.ReadLine();
            Console.Write("3. 제조사");
            data[2] = Console.ReadLine();
            Console.Write("4. 차량가격");
            data[3] = Console.ReadLine();
            Console.Write("----------------------------------------");
            return data; 
        }

        public Car addCarMenu2()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Car 데이터 추가");
            Console.WriteLine("--------------------------------------");
            Console.Write("1. 차종 : ");
            String model = Console.ReadLine();
            Console.Write("2. 색상 : ");
            String color = Console.ReadLine();
            Console.Write("3. 제조사 : ");
            String company = Console.ReadLine();
            Console.Write("4. 차량가격 : ");
            String price = Console.ReadLine();
            Console.Write("----------------------------------------");

            return new Car(model,color,company,price);
        }

        public string delCarMenu()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Car 데이터 삭제");
            Console.WriteLine("--------------------------------------");
            Console.Write("삭제할 차종 입력 : ");
            return Console.ReadLine();            
        }

        public string[] updateCarMenu()
        {
            string[] model = new string[2]
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Car 데이터 수정");
            Console.WriteLine("--------------------------------------");
            Console.Write("검색할 차종 입력 : ");
            model[0] = Console.ReadLine();
            Console.Write("변경할 차종 입력 : ");
            model[1] = Console.ReadLine();    
        }
    }
}
