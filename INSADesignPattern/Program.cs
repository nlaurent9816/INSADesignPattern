using INSADesignPattern.Observables;
using INSADesignPattern.Strategies;
using INSADesignPattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern
{
    class Program
    {
        public static MonObserver userObserver;
        public static MonObserver menuObserver;

        static Node generateMenu()
        {
            //Génération des objets composant le menu
            Leaf pointsHelp = new Leaf("Objectif", "points");
            Leaf infiniteHelp = new Leaf("Infini", "infinite");
            Leaf timedHelp = new Leaf("Chronométré", "timed");
            Leaf how = new Leaf("Comment jouer", "how");
            Leaf list = new Leaf("Liste", "list");
            Leaf score = new Leaf("Score", "score");
            Leaf pointsPlay = new Leaf("Objectif", "points");
            Leaf infinitePlay = new Leaf("Infini", "infinite");
            Leaf timedPlay = new Leaf("Chronométré", "timed");
            Leaf jouer = new Leaf("Partie rapide", "jouer");

            Node typeHelp = new Node("Type de partie", "type", menuObserver);
            Node commands = new Node("Commandes", "commands", menuObserver);
            Node help = new Node("Aide", "help", menuObserver);
            Node typePlay = new Node("Type de partie", "type", menuObserver);
            Node root = new Node("Menu", "menu", menuObserver);


            //On relie les noeuds entre eux pour former l'arbre des menus
            root.AddChild(jouer);
            root.AddChild(typePlay);
                typePlay.AddChild(timedPlay);
                typePlay.AddChild(infinitePlay);
                typePlay.AddChild(pointsPlay);
            root.AddChild(score);
            root.AddChild(help);
                help.AddChild(commands);
                    commands.AddChild(list);
                    commands.AddChild(how);
                help.AddChild(typeHelp);
                    typeHelp.AddChild(timedHelp);
                    typeHelp.AddChild(infiniteHelp);
                    typeHelp.AddChild(pointsHelp);

            return root;

        }



        static void Main(string[] args)
        {
            //Définition de l'Observer, des Observables et du contexte
            userObserver = new MonObserver();
            menuObserver = new MonObserver();
            HelloContext userHelloContext = new HelloContext();
            HelloObservable hello = new HelloObservable(userHelloContext);
            SmileyObservable smiley = new SmileyObservable();
            Node menu = generateMenu();

            //Enregistre les observables auprès de l'observer
            userObserver.Register("hello", hello);
            userObserver.Register("Hello", hello);
            userObserver.Register("hello", smiley);
            //userObserver.Unregister("hello", smiley);

            userObserver.Register(menu.GetKeyWord(), menu.GetObservable());

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
            Console.WriteLine("Write 'menu' to go to the game menu.");

            //Questrion-réponse avec l'Observer qui réagit aux mots clés définits plus haut
            while ((line = Console.ReadLine()) != "exit")
            {
                if (0 == (userObserver.Trigger(line) + menuObserver.Trigger(line)))
                {
                    Console.WriteLine("You wrote : ");
                    Console.WriteLine(line);
                }

            }

            Console.WriteLine("Goodbye.");
        }
    }
}
