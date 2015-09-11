using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExceptions
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(String message)
            : base(message)
        {
        }
    }
}