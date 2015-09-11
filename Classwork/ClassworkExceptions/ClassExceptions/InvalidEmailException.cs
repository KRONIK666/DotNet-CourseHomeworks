using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(String message)
            : base(message)
        {
        }
    }
}