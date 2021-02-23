namespace Flyweight.Exercise_1.flyweight
{
    // La clase flyweight contiene una parte del estado de un árbol.
    // Estos campos almacenan valores que son únicos para cada árbol
    // en particular. Por ejemplo, aquí no encontrarás las
    // coordenadas del árbol. Pero la textura y los colores que
    // comparten muchos árboles sí están aquí. Ya que esta cantidad
    // de datos suele ser GRANDE, dedicarás mucha memoria a
    // mantenerla en cada objeto árbol. En lugar de eso, podemos
    // extraer la textura, el color y otros datos repetidos y
    // colocarlos en un objeto independiente que muchos objetos
    // individuales del árbol pueden referenciar.
    public interface IArbolLigero
    {
        public string getTipo();

        public void dibujar(long x, long y, long z);
    }
}
