using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Strategies
{
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

        private void askName()
        {
            Console.WriteLine("What's your name ?");
            currentName = Console.ReadLine();
        }

        public int GetContext()
        {
            if (currentName == "")
            {
                askName();
            }

            if (currentName == "")
                return -1;
            else
                return ++helloCounter;

        }
    }
}
