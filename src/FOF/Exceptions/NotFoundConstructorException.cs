using System;

namespace FOF.Exceptions
{
    public class NotFoundConstructorException : Exception
    {
        internal NotFoundConstructorException(string message)
            : base(message) { }
    }
}