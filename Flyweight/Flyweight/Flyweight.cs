using System;
// Use Json.NET library,
using Newtonsoft.Json;

namespace Flyweight.Flyweight
{
    /*El Flyweight almacena una parte común del estado (también llamado estado intrínseco) 
     * que pertenece a múltiples entidades comerciales reales. Flyweight acepta el resto del 
     * estado (estado extrínseco, único para cada entidad) a través de sus parámetros de método.*/
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}
