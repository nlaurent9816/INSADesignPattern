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
            Console.WriteLine("Hello " + name);

            return true;
        }

    }
}

