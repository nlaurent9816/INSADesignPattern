using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observables
{
    public class MonObserver
    {

        private Dictionary<string,List<MonIObservable>> listeners;

        public MonObserver()
        {
            listeners = new Dictionary<string, List<MonIObservable>>();
        }

        public void Register (string keyword, MonIObservable observable)
        {
            List<MonIObservable> theList;

            //Si le mot clé est déjà associé
            if (listeners.TryGetValue(keyword, out theList))
            {
                //On rajoute l'ovserver si non existant
                if (!theList.Contains(observable))
                    theList.Add(observable);
            }
            //Si le mot clé n'est pas déjà associé
            else
            {
                theList = new List<MonIObservable>();
                theList.Add(observable);
                listeners.Add(keyword, theList);
            };
        }

        public void Unregister(string keyword,MonIObservable observable)
        {
            List<MonIObservable> theList;

            if (listeners.TryGetValue(keyword, out theList))
                theList.Remove(observable);
        }

        public int Trigger(string keyword)
        {
            List<MonIObservable> theList;
            int observableCalled = 0;

            //On récupère la liste d'observables correspondant au mot-clé
            if(listeners.TryGetValue(keyword, out theList))
            {
                foreach (MonIObservable observable in theList)  // /!\ Cette boucle est break si une des exécutions ne marche pas
                {
                    observableCalled++;     //On compte le nombre d'observables exécutés
                    if (false == observable.Execute())
                        break;
                }
            }

            return observableCalled;

        }

    }
}
