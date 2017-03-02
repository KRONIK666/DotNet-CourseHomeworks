using System;

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