using System;

namespace Summoners_War_Statistics
{
    /// <summary>
    /// Represents error that occurs when selected JSON is invalid (incomplete)
    /// </summary>
    internal class RankingNotCreatedException : Exception
    {
        public RankingNotCreatedException() { }

        public RankingNotCreatedException(string message) : base(message) { }

        public RankingNotCreatedException(string message, Exception inner) : base(message, inner) { }
    }
}
