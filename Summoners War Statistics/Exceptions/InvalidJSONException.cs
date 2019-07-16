using System;

namespace Summoners_War_Statistics
{
    internal class InvalidJSONException : Exception
    {
        public InvalidJSONException() { }

        public InvalidJSONException(string message) : base(message) { }

        public InvalidJSONException(string message, Exception inner) : base(message, inner) { }
    }
}
