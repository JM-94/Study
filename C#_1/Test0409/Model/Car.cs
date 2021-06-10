using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0409
{
    class Car
    {


        // 접근제한자 생략시 기본 private으로 생성됨
        //인스턴스 속성
        public const string JIJUM = "동대구 영업소"; // const변수는 대문자로 작성해야함
        string model;
        string color;
        string company;
        string price;
        
        public Car() {
            model = "아반떼";
            color = "흰색";
            company = "현대";
            price = "2천만원";
                } //기본생성자 , 클래스이름과 항상 같아야함
        //기본 생성자가 없으면 자동으로 생성
        // 기본생성자를 생성 하지않고 매개변수가 있는 생성자를 선언하면 기본생성자를 자동으로 생성하지 않음.
        public Car(string model, string color, string company, string price)
        {
            this.model = model;
            this.color = color;
            this.company = company;
            this.price = price;
        }



        //C#형식 , 람다식 이용
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public string Price { get => price; set => price = value; }

        public void printInfoCar()
        {
            Console.WriteLine("모델:" + model);
            Console.WriteLine("제조사:" + company);
            Console.WriteLine("색상:" + color);
            Console.WriteLine("가격:" + price);
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        public override string ToString()
        {
            string str = "모델 : " + model + "\n";
            str += "제조사 : " + company + "\n";
            str += "색상 : " + color + "\n";
            str += "가격 : " + price + "\n";
            Console.WriteLine("------------------------------------------------------------------------------");
            return str;
        }
        


    }


}
