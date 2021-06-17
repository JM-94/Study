using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0409.Util
{
    class RandData
    {
        static string[] name = { "안재혁", "홍성인", "도현우", "양수빈", "신용원" };
        static int[] age = { 26, 30, 31, 28, 29 };
        static string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
        static char[] gender = { '남', '여' };
        static string[] addr = { "대구 북구 칠곡", "대구 남구 신천1동", "대구 동구 아양로", "대구 북구 산격동", "대구 달서구 신천2동" };
        static string[] jikwi = { "주임", "대리", "과장", "부장", "차장" };
        static string[] office = { "북대구영업소", "남대구영업소", "동대구영업소", "북대구영업소", "남대구영업소" };
        static string[] model = { "K7", "K8", "그랜저", "제네시스", "SM6" };
        static string[] color = { "검정", "흰색", "노란색", "파랑", "은색" };
        static string[] price = { "3천만원", "4천만원", "1억원", "5천만원", "6천만원" };
        static string[] company = { "현대", "KIA", "삼성르노", "쌍용", "GM" };

        Random r = new Random();

        public string getName()
        {
            return name[r.Next(5)];
        }

        public int getAge()
        {
            return age[r.Next(5)];
        }

        public string getTel()
        {
            return tel[r.Next(5)];
        }

        public char getGender()
        {
            return gender[r.Next(2)];
        }

        public string getAddr()
        {
            return addr[r.Next(5)];
        }

        public string getJikwi()
        {
            return jikwi[r.Next(5)];
        }

        public string getOffice()
        {
            return office[r.Next(5)];
        }

        public string getmodel()
        {
            return model[r.Next(5)];
        }

        public string getColor()
        {
            return color[r.Next(5)];
        }

        public string getPrice()
        {
            return price[r.Next(5)];
        }

        public string getCompany()
        {
            return company[r.Next(5)];
        }



    }
}
