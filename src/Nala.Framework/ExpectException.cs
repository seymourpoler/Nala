using System;

namespace Nala.Framework
{
    public class ExpectException: Exception
    {
        public ExpectException(string message) : base(message) { }
    }
}