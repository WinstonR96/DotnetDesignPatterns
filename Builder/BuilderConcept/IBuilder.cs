namespace Builder.BuilderConcept
{
    /// <summary>
    /// La interfaz Builder especifica los metodos para crear las diferentes partes de un producto
    /// </summary>
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
