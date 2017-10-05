using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observables;
using INSADesignPattern.Composite;

namespace INSADesignPattern.Composite
{
    class NodeObservable : MonIObservable
    {
        private List<IMenuComponent> enfants;
        private MonObserver usedObserver;

        public NodeObservable(List<IMenuComponent> children, MonObserver usedObserver)
        {
            enfants = children;
            this.usedObserver = usedObserver;
        }

        public bool Execute()
        {
            usedObserver.Reset();

            foreach (IMenuComponent component in enfants)
            {
                //Partie 1 : affichage du nouveau menu
                Console.Write(component.GetDescription());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" <" + component.GetKeyWord() + ">");
                Console.ResetColor();

                //Partie 2 : édition de l'observeur
                usedObserver.Register(component.GetKeyWord(), component.GetObservable());

            }

            return true;
        }
    }
}
