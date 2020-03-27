// Copyright @Internship2020

namespace netFundamentals.MatchingLogic.MatchingRules.Interfaces
{
    using DataModels.Entries;

    public interface IValidationCase
    {
        int Order { get; }

        bool Validate(ImportEntry importEntry, ImportEntry matchingEntry);
    }
}