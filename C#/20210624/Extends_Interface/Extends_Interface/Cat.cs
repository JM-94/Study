using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Cat : Animal, IFight
    {
        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("ㅎㅇ");
        }
        public string eyeColor { get; set; }
        public override void Sleep()
        {
            //base.Sleep();
            System.Windows.Forms.MessageBox.Show("굿나잇");
        }

        
        public void DailyLottin()
        {
            Eat();
        }

        public void Fight()
        {
            System.Windows.Forms.MessageBox.Show("그만싸워");
        }

    }
}
