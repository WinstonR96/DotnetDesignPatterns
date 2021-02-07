namespace Builder.Exercie1.Producto
{
    public class Coche
    {
        private string nombre { get; set; }
        private int cilindrada { get; set; }

        private int potencia { get; set; }

        private string tipo { get; set; }

        private int num_asientos { get; set; }


        public Coche Nombre(string nombre)
        {
            this.nombre = nombre;
            return this;
        }

        public Coche Cilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
            return this;
        }

        public Coche Potencia(int potencia)
        {
            this.potencia = potencia;
            return this;
        }

        public Coche Tipo(string tipo)
        {
            this.tipo = tipo;
            return this;
        }

        public Coche numAsientos(int num_asientos)
        {
            this.num_asientos = num_asientos;
            return this;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nCilindrada: {this.cilindrada}\nAsientos: {this.num_asientos}\nPotencia: {this.potencia}\nTipo: {this.tipo}";
        }
    }
}
