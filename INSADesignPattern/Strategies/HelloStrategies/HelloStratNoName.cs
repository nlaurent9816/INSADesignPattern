using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Strategies.HelloStrategies
{
    class HelloStratNoName : INSADesignPattern.Strategies.IHelloStrategy
    {
        public bool RunStrategy(string name)
        {
            Console.WriteLine("Oh, you don't want to tell me your name...");
            return false;
        }
    }
}
