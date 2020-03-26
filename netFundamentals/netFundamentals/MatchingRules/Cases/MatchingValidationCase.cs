// Copyright @Internship2020

namespace netFundamentals.MatchingRules.Cases
{
    using Interfaces;
    using DataModels.Entries;

    internal class MatchingValidationCase : IValidationCase
    {
        public int Order => 1;

        public bool Validate(ImportEntry importEntry, ImportEntry matchingEntry)
        {
            return !string.IsNullOrEmpty(matchingEntry.Hobby) && importEntry.Hobby == matchingEntry.Hobby;
        }
    }
}
