using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Strategies
{
    public interface IHelloStrategy
    {
        bool RunStrategy(string name);
    }
}
