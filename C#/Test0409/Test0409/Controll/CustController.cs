using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0409.Model;
using Test0409.Util;

namespace Test0409.Controll
{
    class CustController
    {
        List<Customer> cus_list = new List<Customer>();
        RandData rand;

        public CustController(RandData rand) 
        {
            this.rand = rand;

        }

        public void InsertCus(int count)
        {
            for (int i = 0; i < count; i++)
            {
                cus_list.Add(new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getAddr(),rand.getGender()));
            }

        }
        public void CusView()
        {
            for (int i = 0; i < cus_list.Count; i++)
            {
                Console.WriteLine("번호 : " + (i + 1));
                Console.WriteLine(cus_list[i].ToString());
            }
        }

        public void addCarItem()
        {

        }

    }
}
