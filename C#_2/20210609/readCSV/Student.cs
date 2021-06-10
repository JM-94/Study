using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Student
    {
        public Student(string name, int age, string hakbeon,
                       string hakgwa, string gender)
        {
            this.name = name;
            this.age = age;
            this.hakbeon = hakbeon;
            this.hakgwa = hakgwa;
            this.gender = gender;
        }

        //이름,나이,학번,학과,성별
        public string name { get; set; }
        public int age;
        public string hakbeon;


        //c# 스타일
        private string hakgwa;
        public string _hakgwa
        {
            get { return hakgwa; }
            set { hakgwa = value; }
        }


        //java나 c++ 스타일
        private string gender;
        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public string getGender()
        {
            return this.gender;
        }
    }
}
