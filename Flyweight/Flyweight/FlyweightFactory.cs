using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, ConcreteFlyweight> flyweights = new Dictionary<string, ConcreteFlyweight>();

        // Constructor

        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteFlyweight());
            return ((Flyweight)flyweights[key]);
        }
    }
}
