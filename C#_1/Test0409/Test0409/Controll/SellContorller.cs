using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test0409.Util;

namespace Test0409.Controll
{
    class SellContorller
    {

        RandData rand;
        List<SellContorller> sel_list = new List<SellContorller>();
        public SellContorller(RandData rand)
        {
            this.rand = rand;
        }

        public void InsertSel(int count)
        {
            for (int i = 0; i < count; i++)
            {
                //sel_list.Add(new SellContorller(rand.getSeller_name(), rand.getStore_tel(), rand.getJikwi(), rand.getOffice()));
            }

        }
        public void CusView()
        {
            for (int i = 0; i < sel_list.Count; i++)
            {
                Console.WriteLine("번호 : " + (i + 1));
                Console.WriteLine(sel_list[i].ToString());
            }
        }


    }
}
