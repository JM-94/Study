using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extends_Interface
{
    class Dog : Animal, IFight, IHwaHae
    {
        public string hairColor { get; set; }

        public void AkSoo()
        {
            System.Windows.Forms.MessageBox.Show("dd");
        }

        public void Fight()
        {
            System.Windows.Forms.MessageBox.Show("으르릉");
        }

        public void Hug()
        {
            System.Windows.Forms.MessageBox.Show("ㅇㅇㅋ");
        }
    }
}
