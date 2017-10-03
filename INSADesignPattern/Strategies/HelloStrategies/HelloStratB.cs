using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Strategies.HelloStrategies
{
    class HelloStratB : INSADesignPattern.Strategies.IHelloStraegy
    {
        public bool RunStrategy(string name)
        {
            Console.WriteLine("Yes, " + name + " , I remember you.");
            return true;
        }
    }
}
