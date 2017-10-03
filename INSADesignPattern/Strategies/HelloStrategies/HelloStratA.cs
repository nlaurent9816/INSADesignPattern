using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Strategies.HelloStrategies
{
    class HelloStratA : INSADesignPattern.Strategies.IHelloStrategy
    {
        public bool RunStrategy(string name)
        {
            Console.WriteLine("Hello " + name);
            return true;
        }
    }
}
