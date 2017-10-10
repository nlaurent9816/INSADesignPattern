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

        /// <summary>
        /// Un Observable implémentant l'interface MonIObservable et dont le déclanchement exécute la feuille/champ de menu liée
        /// </summary>
        /// <param name="linkedLeaf">feuille/champ de menu lié</param>
        public LeafObservable(Leaf linkedLeaf)
        {
            this.linkedLeaf = linkedLeaf;
        }

        public bool Execute()
        {
            return linkedLeaf.ExecuteLeaf();
        }
    }
}
