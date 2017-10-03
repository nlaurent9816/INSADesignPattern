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
        }

        public string CurrentName { get => currentName; set => currentName = value; }

        public int GetContext(string name)
        {
            if (name == "")
                return -1;

            if (name == currentName)
                return ++helloCounter;
            else
            {
                currentName = name;
                return helloCounter = 1;
            }
        }
    }
}
