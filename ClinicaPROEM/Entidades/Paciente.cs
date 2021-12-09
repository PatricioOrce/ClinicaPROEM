namespace Entidades
{
    public enum EObraSocial
    {
        NoTiene, CoberturaBasica, CoberturaCompleta
    }
    public class Paciente : Persona
    {
        EObraSocial obraSocial;
        bool estado;
        Medico medicoAsignado;

        public Paciente() { }

        public Paciente(string nombre, string apellido, short edad, long dni, EObraSocial obraSocial) : base(nombre, apellido, edad, dni)
        {
            this.obraSocial = obraSocial;
        }

        public EObraSocial ObraSocial { get => obraSocial; set => obraSocial = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Medico MedicoAsignado { get => medicoAsignado; set => medicoAsignado = value; }

        /// <summary>
        /// Genera la informacion del Paciente, Apellido, Nombre y DNI.
        /// </summary>
        /// <returns>Devuelve la informacion del paciente.</returns>
        public override string Informacion()
        {
            return $"Paciente: {base.apellido} {base.nombre} con DNI: {this.dni}";
        }
    }
}
