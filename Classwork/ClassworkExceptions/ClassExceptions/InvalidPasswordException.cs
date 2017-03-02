using System;

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