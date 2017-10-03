using System;
using INSADesignPattern.Strategies;
using INSADesignPattern.Strategies.HelloStrategies;

namespace INSADesignPattern.Observables
{
    public class HelloObservable : MonIObservable
    {

        HelloContext monContexte;

        //Constructeur
        //Récupère le contexte utilisé
        public HelloObservable(HelloContext helloContext)
        {
            monContexte = helloContext;
        }

        public Boolean Execute()
        {
            return monContexte.GetStrategy().RunStrategy(monContexte.CurrentName);
        }

    }
}

