using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observables
{
    class SmileyObservable : MonIObservable
    {
        public bool Execute()
        {
            Console.WriteLine(":)");
            return true;
        }
    }
}
