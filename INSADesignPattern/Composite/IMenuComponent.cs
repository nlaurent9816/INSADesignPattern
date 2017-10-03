using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observables;

namespace INSADesignPattern.Composite
{
    interface IMenuComponent
    {
        string GetDescription();
        string GetKeyWord();
        MonIObservable GetObservable();

    }
}
