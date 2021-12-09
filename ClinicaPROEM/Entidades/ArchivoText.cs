using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ArchivoText 
    {
        /// <summary>
        /// Escribe un archivo de texto en una ruta indicada con la informacion que le enviemos por parametro.
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        public static void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(dato);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al escribir el archivo.");
            }
        }
    }
}
