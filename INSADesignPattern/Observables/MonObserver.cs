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

        /// <summary>
        /// Observeur réagissant à des mots clés.
        /// Lorsque déclanché avec la méthode MonObserver.Trigger(string), recherche les observables enregistrés sur ce mot-clé et les exécutent.
        /// </summary>
        public MonObserver()
        {
            listeners = new Dictionary<string, List<MonIObservable>>();
        }

        /// <summary>
        /// Inscrit un observable sur un mot-clé
        /// </summary>
        /// <param name="keyword">mot-clé auquel réagir</param>
        /// <param name="observable">observable à inscrire</param>
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

        /// <summary>
        /// Désinscrit un observable sur un mot-clé
        /// </summary>
        /// <param name="keyword">mot-clé auquel réagissait l'Observable</param>
        /// <param name="observable">observable à désinscrire</param>
        public void Unregister(string keyword,MonIObservable observable)
        {
            List<MonIObservable> theList;

            if (listeners.TryGetValue(keyword, out theList))
                theList.Remove(observable);
        }

        /// <summary>
        /// Désinscrit tout les observables actuellemnt inscrits.
        /// </summary>
        public void Reset()
        {
            listeners.Clear();
        }

        /// <summary>
        /// Déclanche l'exécution des Observables inscrits réagissants au mot clé passé en paramètre.
        /// </summary>
        /// <param name="keyword">Mot-clé filtrant les observables à exécuter.</param>
        /// <returns>Le nombre d'observables exécutés. Une erreur dans l'exécution d'un observable empèche l'exécution des suivants.</returns>
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
