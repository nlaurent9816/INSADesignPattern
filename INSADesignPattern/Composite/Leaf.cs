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
        protected string description;
        private string keyword;
        private LeafObservable monObservable;

        /// <summary>
        /// Génère une un champ de menu dont l'exécution affiche un texte générique.
        /// Le menu est implémenté sous forme d'arbre.
        /// Vos pouvez implémenter une sous-classe surchargeant la méthode 'ExecuteLeaf'
        /// </summary>
        /// <param name="leafDescription">Nom du champ</param>
        /// <param name="leafKeyword">Mot-clé déclanchant l'exécution de la feuille (lors de l'utilisation de l'Observer)</param>
        public Leaf(string leafDescription, string leafKeyword)
        {
            description = leafDescription;
            keyword = leafKeyword;
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

        public virtual bool ExecuteLeaf()
        {
            Console.WriteLine("Executing leaf " + description);
            return true;
        }
    }
}
