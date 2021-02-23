using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Flyweight
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +  extrinsicstate);
        }
    }
}
