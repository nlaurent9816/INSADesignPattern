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
            int contextCounter;
            string name;
            IHelloStraegy usedStrat;

            //Demande le nom
            Console.WriteLine("What's your name ?");
            name = Console.ReadLine();

            //On donne le nom reçu au contexte qui va nous dire combien de fois de suite
            //le nom donné a été utilisé.
            contextCounter = monContexte.GetContext(name);

            //On choisit la stratégie selon le contexte
            if (contextCounter < 1)
                usedStrat = new HelloStratNoName();
            else if (contextCounter < 2)
                usedStrat = new HelloStratA();
            else if (contextCounter < 6)
                usedStrat = new HelloStratB();
            else
                usedStrat = new HelloStratC();

            //on exécute la stratégie
            return usedStrat.RunStrategy(name);

        }

    }
}

