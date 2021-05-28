using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test0409.Model
{
    class Seller
    {
        private string seller_name;
        private string store_tel;
        private string jikwi;
        private string office;
        public Seller(string seller_name, string store_tel, string jikwi, string office)
        {
            this.seller_name = seller_name;
            this.store_tel = store_tel;
            this.jikwi = jikwi;
            this.office = office;
        }

        public string Seller_name { get => seller_name; set => seller_name = value; }
       
        public string Store_tel { get => this.store_tel; set => this.store_tel = value; }
    
        public string Jikwi { get => jikwi; set => jikwi = value; }
        public string Office { get => office; set => office = value; }

        public void SellerInfo()
        {
            Console.WriteLine("이름 : " + seller_name);
            Console.WriteLine("전화 : " + store_tel);
            Console.WriteLine("직급 : " + jikwi);
            Console.WriteLine("사무실 : " + office);
        }

        public override string ToString()
        {

            string data2 = "이름" + seller_name + "\n";
            data2 += "전화" + store_tel + "\n";
            data2 += "직급" + jikwi + "\n";
            data2 += "사무실" + office + "\n";
            return data2;
        }
    }

    


    


}
