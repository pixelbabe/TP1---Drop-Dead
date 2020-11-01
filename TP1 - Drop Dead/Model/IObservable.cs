using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead.Model
{
    interface IObservable
    {
        void AttachObserver(IObserver o);
        void DetachObserver(IObserver o);
        void NotifyObserver();
    }
}
