using System;

namespace Faf.Exceptions
{
    public class NotFoundConstructorException : Exception
    {
        internal NotFoundConstructorException(string message)
            : base(message) { }
    }
}