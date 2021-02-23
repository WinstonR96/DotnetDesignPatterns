using Flyweight.Exercise_1.ConcreteFlyweight;
using Flyweight.Exercise_1.flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Exercise_1.FlyweightFactory
{
    public class FabricaDeArboles
    {
        private Dictionary<string, Arbol> arboles;

        public FabricaDeArboles()
        {
            this.arboles = new Dictionary<string, Arbol>();
        }

        public Arbol GetArbol(string tipo)
        {
            if (!arboles.ContainsKey(tipo))
                arboles.Add(tipo, new Arbol(tipo));
            return ((Arbol)arboles[tipo]);
        }
    }
}
