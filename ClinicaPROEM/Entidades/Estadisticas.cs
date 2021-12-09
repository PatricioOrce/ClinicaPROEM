namespace Entidades
{
    public static class Estadisticas
    {
        /// <summary>
        /// Ordena una lista de medicos de forma descendente en base a su cantidad de atendidos.
        /// </summary>
        /// <returns>Devuelve una lista de medicos ordenada de forma descendente.</returns>
        public static Medico[] MedOrderedByAtendQty()
        {
            Medico[] pacientes = Clinica.Medicos.ToArray();
            for (int k = 0; k < Clinica.Medicos.Count; k++)
            {
                for (int f = 0; f < Clinica.Medicos.Count - 1 - k; f++)
                {
                    if (pacientes[f].CantAtendidos < pacientes[f + 1].CantAtendidos)
                    {
                        Medico aux;
                        aux = pacientes[f];
                        pacientes[f] = pacientes[f + 1];
                        pacientes[f + 1] = aux;
                    }
                }
            }
            return pacientes;
        }
        /// <summary>
        /// Busca al medico con mayor cantidad de pacientes atendidos.
        /// </summary>
        /// <returns>Devuelve al medico encontrado.</returns>
        public static Medico MedicoMasPacientes()
        {
            Medico max = Clinica.Medicos[0]; ;
            for (int i = 0; i < Clinica.Medicos.Count; i++)
            {
                if (Clinica.Medicos[i].CantAtendidos > max.CantAtendidos)
                {
                    max = Clinica.Medicos[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Busca al medico con menor cantidad de pacientes atendidos.
        /// </summary>
        /// <returns>Devuelve al medico encontrado.</returns>
        public static Medico MedicoMenosPacientes()
        {
            Medico min = Clinica.Medicos[0]; ;
            for (int i = 0; i < Clinica.Medicos.Count; i++)
            {
                if (Clinica.Medicos[i].CantAtendidos < min.CantAtendidos)
                {
                    min = Clinica.Medicos[i];
                }
            }
            return min;
        }
        /// <summary>
        /// Busca la especialidad con mayor cantidad de consultas.
        /// </summary>
        /// <returns>Devuelve la especialidad encontrada.</returns>
        public static string EspConMasConsultas()
        {
            int cantCardio = 0;
            int cantCiruja = 0;
            int cantOtorrino = 0;
            int cantOftal = 0;
            int cantOtro = 0;
            string especialidad = string.Empty;

            for (int i = 0; i < Clinica.Consultas.Count; i++)
            {

                switch (Clinica.Consultas[i].Medico.Especialidad)
                {
                    case EEspecialidad.Cardiologo:
                        cantCardio += 1;
                        break;
                    case EEspecialidad.Cirujano:
                        cantCiruja += 1;
                        break;
                    case EEspecialidad.Otorrino:
                        cantOtorrino += 1;
                        break;
                    case EEspecialidad.Oftalmologo:
                        cantOftal += 1;
                        break;
                    case EEspecialidad.Otro:
                        cantOtro += 1;
                        break;
                    default:
                        break;
                }
            }

            if (cantCardio > cantCiruja && cantCardio > cantOftal && cantCardio > cantOtorrino && cantCardio > cantOtro)
            {
                especialidad = "Cardiologia";
            }
            if (cantCiruja > cantCardio && cantCiruja > cantOftal && cantCiruja > cantOtorrino && cantCiruja > cantOtro)
            {
                especialidad = "Cirujano";
            }
            if (cantOftal > cantCardio && cantOftal > cantCiruja && cantOftal > cantOtorrino && cantOftal > cantOtro)
            {
                especialidad = "Oftalmologia";
            }
            if (cantOtorrino > cantCardio && cantOtorrino > cantCiruja && cantOtorrino > cantOftal && cantOtorrino > cantOtro)
            {
                especialidad = "Otorrinolaringologia";
            }
            if (cantOtro > cantCardio && cantOtro > cantCiruja && cantOtro > cantOftal && cantOtro > cantOtorrino)
            {
                especialidad = "Especialidad no contemplada.";
            }
            return especialidad;
        }
    }
}