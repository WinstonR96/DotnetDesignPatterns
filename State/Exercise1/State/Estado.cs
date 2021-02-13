using State.Exercise1.Context;

namespace State.Exercise1.State
{
    public abstract class Estado
    {
        protected Vehiculo _context;
        public void SetContext(Vehiculo context)
        {
            this._context = context;
        }
        public abstract void Acelerar();
        public  abstract void Frenar();
        public abstract void Contacto();
    }
}
