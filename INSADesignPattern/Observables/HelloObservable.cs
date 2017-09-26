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
            Console.WriteLine("Oh, you said 'hello' !");

            return true;
        }

    }
}

