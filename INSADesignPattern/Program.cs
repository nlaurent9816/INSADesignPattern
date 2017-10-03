using INSADesignPattern.Observables;
using INSADesignPattern.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Définition de l'Observer, des Observables et du contexte
            MonObserver userObserver = new MonObserver();
            HelloContext userHelloContext = new HelloContext();
            HelloObservable hello = new HelloObservable(userHelloContext);
            SmileyObservable smiley = new SmileyObservable();

            //Enregistre les observables auprès de l'observer
            userObserver.Register("hello", hello);
            userObserver.Register("Hello", hello);
            userObserver.Register("hello", smiley);
            //userObserver.Unregister("hello", smiley);

            //Prompt d'accueil
            string line;
            Console.WriteLine("");
            Console.WriteLine("     __   __     __  ________  _____");
            Console.WriteLine("    /  / /  |  /  / /  _____/ /  _  |");
            Console.WriteLine("   /  / /   | /  / /  /____  /  /_| |");
            Console.WriteLine("  /  / /    |/  / /____   / /  ___  |");
            Console.WriteLine(" /  / /  /|    / _____/  / /  /   | |");
            Console.WriteLine("/__/ /__/ |___/ /_______/ /__/    |_|");
            Console.WriteLine("Desing Patterns - Anthony Maudry amaudry@gmail.com");
            Console.WriteLine("Hello,");
            Console.WriteLine("Write something (type 'exit' to exit the program).");

            //Questrion-réponse avec l'Observer qui réagit aux mots clés définits plus haut
            while ((line = Console.ReadLine()) != "exit")
            {
                if (0 == userObserver.Trigger(line))
                {
                    Console.WriteLine("You wrote : ");
                    Console.WriteLine(line);
                }

            }

            Console.WriteLine("Goodbye.");
        }
    }
}
