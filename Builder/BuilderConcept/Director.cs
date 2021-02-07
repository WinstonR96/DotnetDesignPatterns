namespace Builder.BuilderConcept
{
    /// <summary>
    /// El Director solo es responsable de ejecutar los pasos de construcción en una secuencia particular. 
    /// Es útil cuando se producen productos de acuerdo con un orden o configuración específicos. 
    /// Estrictamente hablando, la clase Director es opcional, ya que el cliente puede controlar a los 
    /// constructores directamente.
    /// </summary>
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        /// <summary>
        /// El director puede construir varias variaciones de producto usando los mismos pasos de construcción.
        /// </summary>
        public void buildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
