using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Strategies.HelloStrategies;

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

        public IHelloStrategy GetStrategy()
        {
            if (currentName == "")
            {
                askName();
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
