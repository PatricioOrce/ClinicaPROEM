using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AvailabilityException : Exception
    {
        public AvailabilityException(string message) : base(message)
        {
        }
    }
}
