// Copyright @Internship2020

namespace netFundamentals.MatchingRules.Cases
{
    using Interfaces;
    using DataModels.Entries;

    internal class ErrorStatusCodeValidationCase : IValidationCase
    {
        public int Order => 0;

        public bool Validate(ImportEntry importEntry, ImportEntry matchingEntry)
        {
            return importEntry.StatusCode != 0;
        }
    }
}
