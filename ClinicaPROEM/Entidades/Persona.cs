using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected short edad;
        protected long dni;

        public Persona() { }
        public Persona(string nombre, string apellido, short edad, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public short Edad { get => edad; set => edad = value; }
        public long Dni { get => dni; set => dni = value; }

        /// <summary>
        /// Metodo que devuelve informacion de la persona que lo contenga.
        /// </summary>
        /// <returns></returns>
        public abstract string Informacion();

    }
}
