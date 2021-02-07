namespace Builder.BuilderConcept
{
    /// <summary>
    /// Las clases de Concrete Builder siguen la interfaz de Builder y proporcionan implementaciones específicas de 
    /// los pasos de construcción. Su programa puede tener varias variaciones de Builders, implementadas de 
    /// manera diferente.
    /// </summary>

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
            this._product = new Product();
        }

        // Todos los pasos de producción funcionan con la misma instancia de producto.
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }
    }
}
