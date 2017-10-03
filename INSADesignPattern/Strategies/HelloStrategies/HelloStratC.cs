using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Strategies.HelloStrategies
{
    class HelloStratC : INSADesignPattern.Strategies.IHelloStrategy
    {
        public bool RunStrategy(string name)
        {
            Console.WriteLine("Ok, " + name + " , I understand you're very polite. Please stop that game.");
            return true;
        }
    }
}
