using System;

namespace Entidades
{
    public class Consulta
    {

        int id;
        static int nextId;
        bool estado;
        Paciente paciente;
        Medico medico;

        static Consulta()
        {
            nextId = 0;
        }
        public Consulta(Medico medico, Paciente paciente)
        {
            nextId += 1;
            this.id = nextId;
            this.estado = false;
            this.paciente = paciente;
            this.medico = medico;
        }
        public Consulta(Medico medico, Paciente paciente, bool estado) : this(medico,paciente)
        {
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Paciente Paciente { get => paciente; set => paciente = value; }
        public Medico Medico { get => medico; set => medico = value; }

        /// <summary>
        /// Genera un estado tipo string personalizado en base al atributo estado de tipo booleano.
        /// </summary>
        /// <returns>Devuelve "En curso" en caso de ser true, de lo contrario "Finalizada"</returns>
        public string EstadoStr()
        {
            if (this.estado)
                return "En curso";
            else
                return "Finalizada";
        }
        /// <summary>
        /// Genera una nueva consulta con su respectivo medico y paciente.
        /// </summary>
        /// <param name="medico"></param>
        /// <param name="paciente"></param>
        /// <returns>Devuelve una consulta generada y setea su estado como "En curso"</returns>
        public static Consulta NewConsulta(Medico medico, Paciente paciente)
        {
            if(medico is null || paciente is null)
            {
                throw new Exception("Oh, parece que debes ingresar personas validas para realizar la consulta...");
            }
            Consulta consulta = new Consulta(medico,paciente,true);
            return consulta;
        }
        

    }
}
