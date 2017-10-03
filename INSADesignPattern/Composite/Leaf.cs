using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observables;

namespace INSADesignPattern.Composite
{
    class Leaf : IMenuComponent
    {
        private string description;
        private string keyword;
        private LeafObservable monObservable;

        public Leaf(string description, string keyword)
        {
            this.description = description;
            this.keyword = keyword;
            monObservable = new LeafObservable(this);
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetKeyWord()
        {
            return keyword;
        }

        public MonIObservable GetObservable()
        {
            return monObservable;
        }
    }
}
