using Builder.Exercie1.Builder;
using Builder.Exercie1.Producto;

namespace Builder.Exercie1.ConcreteBuilder
{
    public class ConcreteBuilderAudi : ICocheBuilder
    {
        private Coche coche = new Coche();

        public ConcreteBuilderAudi()
        {
            Reset();
        }

        public void Reset()
        {
            coche = new Coche();
        }
        public void DarNombre()
        {
            coche.Nombre("Audi A7 Audi A7 Sportback 3.0 TFSI quattro S tronic 7 vel.");
        }

        public void construirCarroceria()
        {
            coche.Tipo("Sedan HB").numAsientos(5);
        }

        public void construirMotor()
        {
            coche.Cilindrada(2995).Potencia(300);
        }

        public void DarNombre(string nombre)
        {
            coche.Nombre(nombre);
        }

        public void construirCarroceria(string tipo, int asiento)
        {
            coche.Tipo(tipo).numAsientos(asiento);
        }

        public void construirMotor(int cilindrada, int potencia)
        {
            coche.Cilindrada(cilindrada).Potencia(potencia);
        }

        public Coche GetCoche()
        {
            Coche result = this.coche;
            Reset();
            return result;
        }

    }
}
