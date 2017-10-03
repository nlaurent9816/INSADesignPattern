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

        public NodeObservable(List<IMenuComponent> children)
        {
            enfants = children;
        }

        public bool Execute()
        {
            Program.userObserver.Reset();

            foreach (IMenuComponent component in enfants)
            {
                //Partie 1 : affichage du nouveau menu
                Console.Write(component.GetDescription());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" <" + component.GetKeyWord() + ">");
                Console.ResetColor();

                //Partie 2 : édition de l'observeur
                Program.userObserver.Register(component.GetKeyWord(), component.GetObservable());

            }

            return true;
        }
    }
}
