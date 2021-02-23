using Flyweight.Exercise_1.flyweight;
using System;

namespace Flyweight.Exercise_1.ConcreteFlyweight
{
    public class Arbol : IArbolLigero
    {
        private string tipo;

        public Arbol(string tipo)
        {
            this.tipo = tipo;
        }

        public void dibujar(long x, long y, long z)
        {
            Console.WriteLine($"Árbol {getTipo()} dibujado en las coordenadas ({x},{y},{z})");
        }

        public string getTipo()
        {
            return this.tipo;
        }
    }
}
