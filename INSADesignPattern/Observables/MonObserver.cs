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

        public void Unregister(MonIObservable observable)
        {
            //TODO
        }

        public int Trigger(string keyword)
        {
            List<MonIObservable> theList;

            int observableCalled = 0;

            if(listeners.TryGetValue(keyword, out theList))
            {
                foreach (MonIObservable observable in theList)
                {
                    observable.Execute();
                    observableCalled++;
                }
            }

            return observableCalled;

        }

    }
}
