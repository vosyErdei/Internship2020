// Copyright @Internship2020

namespace netFundamentals.MatchingLogic.MatchingRules.Cases
{
    using DataModels.Entries;
    using Interfaces;

    internal class MatchingValidationCase : IValidationCase
    {
        public int Order => 1;

        public bool Validate(ImportEntry importEntry, ImportEntry matchingEntry)
        {
            return !string.IsNullOrEmpty(matchingEntry.Hobby) && importEntry.Hobby == matchingEntry.Hobby;
        }
    }
}
