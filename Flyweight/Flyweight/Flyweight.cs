using System;
// Use Json.NET library,
using Newtonsoft.Json;

namespace Flyweight.Flyweight
{
    /*El Flyweight almacena una parte común del estado (también llamado estado intrínseco) 
     * que pertenece a múltiples entidades comerciales reales. Flyweight acepta el resto del 
     * estado (estado extrínseco, único para cada entidad) a través de sus parámetros de método.*/
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
