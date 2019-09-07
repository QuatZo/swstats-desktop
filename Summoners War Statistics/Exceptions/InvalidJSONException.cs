using System;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Represents error that occurs when selected JSON is invalid (incomplete)
    /// </summary>
    internal class InvalidJSONException : Exception
    {
        public InvalidJSONException() { }

        public InvalidJSONException(string message) : base(message) { }

        public InvalidJSONException(string message, Exception inner) : base(message, inner) { }
    }
}
