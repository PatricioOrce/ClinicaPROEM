using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException(string message) : base(message)
        {
        }
    }
}
