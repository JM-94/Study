using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0408
{
    class Student
    {
        private string name;
        private int age;
        private char gender;
        private string tel;
        private string addr;

        public Student(string name, int age, char gender, string tel, string addr)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.tel = tel;
            this.addr = addr;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }

        public override string ToString()
        {
            return base.ToString();
        }
        public void studentInfo()
        {
           
            Console.WriteLine("이름 : "+name);
            Console.WriteLine("나이 : "+age);
            Console.WriteLine("전화 : "+tel);
            Console.WriteLine("성별 : "+gender);
            Console.WriteLine("주소 : "+addr);
            Console.WriteLine("-----------------------");
        }
        public static void menuMain()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("학생 관리 프로그램 v1.0");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. 학생정보 생성");
            Console.WriteLine("2. 학생정보 출력");
            Console.WriteLine("3. 종료");
            Console.WriteLine("-----------------------");
        }
    }
}
