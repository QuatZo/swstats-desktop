using System;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Represents error that occurs when selected JSON is invalid (incomplete)
    /// </summary>
    internal class RankingAlreadyExistsException : Exception
    {
        public RankingAlreadyExistsException() { }

        public RankingAlreadyExistsException(string message) : base(message) { }

        public RankingAlreadyExistsException(string message, Exception inner) : base(message, inner) { }
    }
}
