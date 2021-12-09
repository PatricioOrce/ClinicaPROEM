using System;
using System.Collections.Generic;

namespace Entidades
{
    public enum EEspecialidad
    {
        Cardiologo, Cirujano, Otorrino, Oftalmologo, Otro
    }
    public class Medico : Persona
    {
        public bool atendiendo;
        Queue<Paciente> listDeEspera;
        EEspecialidad especialidad;
        int cantAtendidos;

        public Medico(string nombre, string apellido, short edad, long dni) : base(nombre, apellido, edad, dni) 
        {
            this.cantAtendidos = 0;

        }
        public Medico(string nombre, string apellido, short edad, long dni, EEspecialidad especialidad) : this(nombre, apellido, edad, dni)
        {
            this.especialidad = especialidad;
            this.cantAtendidos = 0;

        }
        public Medico(string nombre, string apellido, short edad, long dni, bool atendiendo, Queue<Paciente> listaDeEspera, EEspecialidad especialidad) : this(nombre, apellido, edad, dni)
        {
            this.atendiendo = atendiendo;
            this.listDeEspera = listaDeEspera;
            this.especialidad = especialidad;
        }

        public EEspecialidad Especialidad { get => especialidad; set => especialidad = value; }
        public int CantAtendidos { get => cantAtendidos; set => cantAtendidos = value; }

        /// <summary>
        /// Genera un estado tipo string personalizado en base al atributo estado de tipo booleano.
        /// </summary>
        /// <returns>Devuelve "En curso" en caso de ser true, de lo contrario "Finalizada"</returns>
        public string Estado()
        {
            if (this.atendiendo)
            {
                return "Atendiendo";
            }
            return "Libre";
        }
        /// <summary>
        /// Genera la informacion del Medico.
        /// </summary>
        /// <returns>Devuelve la informacion del medico, Apellido, Nombre y Especialidad.</returns>
        public override string Informacion()
        {
            return $"Medico: {base.apellido} {base.nombre}.\nEspecialidad: {this.especialidad}";
        }
        public static bool operator +(Medico medico, Paciente paciente)
        {
            if (!medico.atendiendo)
            {
                medico.listDeEspera.Enqueue(paciente);
                return true;
            }
            else
            {
                throw new Exception("Hubo un error al intentar crear la consulta.");
            }
        }
        public static explicit operator bool(Medico medico)
        {
            return medico.atendiendo;
        }


    }
}
