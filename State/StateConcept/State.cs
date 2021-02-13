namespace State.StateConcept
{
    //La clase de estado base declara métodos que todos los estados concretos deben implementar y 
    //también proporciona una referencia inversa al objeto de contexto, asociado con el estado.
    //Los Estados pueden utilizar esta referencia inversa para hacer la transición del contexto a otro Estado.
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
