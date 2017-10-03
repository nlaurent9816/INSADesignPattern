using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observables;

namespace INSADesignPattern.Composite
{
    class LeafObservable : MonIObservable
    {
        private Leaf linkedLeaf;

        public LeafObservable(Leaf linkedLeaf)
        {
            this.linkedLeaf = linkedLeaf;
        }

        public bool Execute()
        {
            Console.WriteLine("Executing leaf " + linkedLeaf.GetDescription());
            return true;
        }
    }
}
