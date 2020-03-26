// Copyright @Internship2020

namespace netFundamentals.MatchingRules
{
    using Logging;
    using netFundamentals.Logging.Interfaces;
    using OldMatchingSystem.Entries;
    using OldMatchingSystem.Extension;

    internal class HumanMatchingRuleOld
    {
        private readonly ILogger _logger = new Logger();

        public bool Match(ImportEntry importEntry, ImportEntry matchEntry)
        {
            if (!importEntry.IsErrorStatusCode())
            {
                _logger.Log("Error status code.");

                return false;
            }

            if (!importEntry.IsMatching(matchEntry))
            {
                _logger.Log("Error not matching.");

                return false;
            }

            _logger.Log("Matching hobbies!");

            return true;
        }
    }
}
