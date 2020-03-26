// Copyright @Internship2020

namespace netFundamentals.MatchingRules.Interfaces
{
    using DataModels.Entries;

    public interface IValidationCase
    {
        int Order { get; }

        bool Validate(ImportEntry importEntry, ImportEntry matchingEntry);
    }
}