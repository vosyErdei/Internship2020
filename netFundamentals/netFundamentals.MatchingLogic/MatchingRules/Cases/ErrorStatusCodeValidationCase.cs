// Copyright @Internship2020

namespace netFundamentals.MatchingLogic.MatchingRules.Cases
{
    using DataModels.Entries;
    using Interfaces;

    internal class ErrorStatusCodeValidationCase : IValidationCase
    {
        public int Order => 0;

        public bool Validate(ImportEntry importEntry, ImportEntry matchingEntry)
        {
            return importEntry.StatusCode != 0;
        }
    }
}
