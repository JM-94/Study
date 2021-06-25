using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Animal : Creature
    {
        public string name { get; set; }
        public int age { get; set; }

        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("알필요없자나");
        }

        public virtual void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("zzz");
        }

        // protected : Animal을 상속한 클래스들만 호출 가능
        protected void Eat()
        {
            System.Windows.Forms.MessageBox.Show("냠냠");
        }
    }
}
