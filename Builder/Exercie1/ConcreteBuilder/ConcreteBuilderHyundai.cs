using Builder.Exercie1.Builder;
using Builder.Exercie1.Producto;

namespace Builder.Exercie1.ConcreteBuilder
{
    public class ConcreteBuilderHyundai : ICocheBuilder
    {
        private Coche coche = new Coche();

        public ConcreteBuilderHyundai()
        {
            Reset();
        }

        public void DarNombre()
        {
            coche.Nombre("Hyundai Santa Fe");
        }


        public void construirCarroceria()
        {
            coche.numAsientos(7).Tipo("4x4");
        }

        public void construirMotor()
        {
            coche.Cilindrada(4000).Potencia(120);
        }

        public Coche GetCoche()
        {
            Coche result = this.coche;
            Reset();
            return result;

        }

        public void Reset()
        {
            coche = new Coche();
        }
    }
}
