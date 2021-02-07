using Builder.Exercie1.Builder;

namespace Builder.Exercie1.Director
{
    public class Concesionario
    {
        private ICocheBuilder _cocheBuilder;

        public ICocheBuilder CocheBuilder
        {
            set { this._cocheBuilder = value; }
        }

        public void construirCoche()
        {
            this._cocheBuilder.DarNombre();
            this._cocheBuilder.construirMotor();
            this._cocheBuilder.construirCarroceria();
        }
    }
}
