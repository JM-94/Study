using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface Subject
    {
        // register or subscribe
        void register(Observer o);
        // remove or dissubscribeqqqq
        void remove(Observer o);
        void notifyObserver();
    }
}
