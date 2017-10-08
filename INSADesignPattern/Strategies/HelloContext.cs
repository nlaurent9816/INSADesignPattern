using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Strategies.HelloStrategies;

namespace INSADesignPattern.Strategies
{
    //Classe comportant les informations sur le contexte d'exécution de HelloObservable.
    public class HelloContext
    {
        private string currentName;
        private int helloCounter;

        public HelloContext()
        {
            currentName = "";
            helloCounter = 0;
        }

        public string CurrentName { get => currentName; }

        private void AskName()
        {
            Console.WriteLine("What's your name ?");
            currentName = Console.ReadLine();
        }

        //Appelé à chaque exécution de HelloObservable, cette classe va mettre à jour
        //le contexte et en déduire la stratégie à appliquer.
        public IHelloStrategy GetStrategy()
        {
            if (currentName == "")
            {
                AskName();
            }

            if (currentName == "")
                return new HelloStratNoName();
            else
            {
                helloCounter++;
                System.Diagnostics.Debug.WriteLine(helloCounter);
                if (helloCounter < 2)
                    return new HelloStratA();
                else if (helloCounter < 6)
                    return new HelloStratB();
                else
                    return new HelloStratC();
            }

        }
    }
}
