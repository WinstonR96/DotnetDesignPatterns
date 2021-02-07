using Builder.Exercie1.Producto;

namespace Builder.Exercie1.Builder
{
    public interface ICocheBuilder
    {
        public void Reset();

        public void DarNombre();

        public Coche GetCoche();
        public void construirMotor();

        public void construirCarroceria();

    }
}
