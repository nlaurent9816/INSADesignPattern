using System;

namespace INSADesignPattern.Observables
{
    public class HelloObservable : MonIObservable
    {
	    public HelloObservable()
	    {
	    }

        public Boolean Execute()
        {
            string name;

            Console.WriteLine("What's your name ?");
            name = Console.ReadLine();
            if (name != "")
            {
                Console.WriteLine("Hello " + name);
                return true;
            }
            else
            {
                Console.WriteLine("Oh, you don't want to tell me your name...");
                return false;
            }
        }

    }
}

