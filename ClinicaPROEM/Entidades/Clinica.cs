using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Clinica
    {
        static List<Medico> medicos;
        static List<Paciente> pacientes;
        static Queue<Paciente> pacientesEnEspera;
        static List<Consulta> consultas;

        static Clinica()
        {
            medicos = new List<Medico>()
            {
                new Medico("Damian","Guzman",47,37884351,EEspecialidad.Otorrino),
                new Medico("Romina","Carrazco",41,39265437,EEspecialidad.Oftalmologo),
                new Medico("Dante","Aguero",36,39988786,EEspecialidad.Cirujano),
                new Medico("Melina","Fetuch",43,38946534,EEspecialidad.Cardiologo),
                new Medico("Andrea","Rios",43,31544331,EEspecialidad.Otro),
            };
            pacientes = new List<Paciente>()
            {
                new Paciente("Carolina","Aguirre",40,37884351,EObraSocial.CoberturaCompleta),
                new Paciente("Dario","Nunez",52,26352351,EObraSocial.CoberturaCompleta),
                new Paciente("Oscar","Oyeta",36,35472541,EObraSocial.CoberturaCompleta),
                new Paciente("Micaela","Garon",23,45367453,EObraSocial.CoberturaBasica),
                new Paciente("Justin","Rivaldi",34,36475869,EObraSocial.CoberturaBasica),
                new Paciente("Nicolas","Rodriguez",67,27485635,EObraSocial.CoberturaBasica),
                new Paciente("Florencia","Guzman",54,30573645,EObraSocial.NoTiene),
                new Paciente("Facundo","Richidoni",38,37485647,EObraSocial.NoTiene),
                new Paciente("Renata","Grizman",25,40384675,EObraSocial.NoTiene),
            };
            pacientesEnEspera = new Queue<Paciente>();
            foreach (Paciente item in pacientes)
            {
                pacientesEnEspera.Enqueue(item);
            }
            consultas = new List<Consulta>();
        }

        public static List<Medico> Medicos { get => medicos; set => medicos = value; }
        public static List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }
        public static Queue<Paciente> PacientesEnEspera { get => pacientesEnEspera; set => pacientesEnEspera = value; }
        public static List<Consulta> Consultas { get => consultas; set => consultas = value; }
        
        /// <summary>
        /// Busca un DNI en una lista de pacientes hasta encontrar al paciente que coincide con dicho dni.
        /// </summary>
        /// <param name="dniStr">DNI de tipo string</param>
        /// <returns>Devuelve el paciente encontrado. De no encontrar uno, lanza una excepcion.</returns>
        public static Paciente GetPacienteByDni(string dniStr)
        {
            if(long.TryParse(dniStr,out long dni))
            {
                foreach (Paciente item in Clinica.pacientes)
                {
                    if(item.Dni == dni)
                    {
                        return item;
                    }
                }
            }
             throw new AvailabilityException("El DNI ingresado no pertenece a ningun paciente registrado en nuestra base de datos.");
        }
        /// <summary>
        /// Busca un DNI en una lista de pacientes hasta encontrar al paciente que coincide con dicho dni.
        /// </summary>
        /// <param name="dni">DNI de tipo long</param>
        /// <returns>Devuelve el paciente encontrado. De no encontrar uno, lanza una excepcion.</returns>
        public static Paciente GetPacienteByDni(long dni)
        {
            foreach (Paciente item in Clinica.pacientes)
            {
                if (item.Dni == dni)
                {
                    return item;
                }
            }
            throw new AvailabilityException("El DNI ingresado no pertenece a ningun paciente registrado en nuestra base de datos.");
        }
    }
}
