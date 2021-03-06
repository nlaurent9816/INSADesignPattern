﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INSADesignPattern.Observables;

namespace INSADesignPattern.Composite
{
    class Node : IMenuComponent
    {
        private string description;
        private string keyword;
        private List<IMenuComponent> enfants;
        private MonObserver usedObserver;

        public Node(string description, string keyword, MonObserver usedObserver)
        {
            this.description = description;
            this.keyword = keyword;
            enfants = new List<IMenuComponent>();
            this.usedObserver = usedObserver;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetKeyWord()
        {
            return keyword;
        }

        public void AddChild(IMenuComponent child)
        {
            enfants.Add(child);
        }

        public MonIObservable GetObservable()
        {
            return new NodeObservable(enfants,usedObserver);
        }
    }
}
