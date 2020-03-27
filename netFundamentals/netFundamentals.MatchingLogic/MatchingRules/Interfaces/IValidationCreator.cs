// Copyright @Internship2020

namespace netFundamentals.MatchingLogic.MatchingRules.Interfaces
{
    using System.Collections.Generic;

    public interface IValidationCreator
    {
        List<IValidationCase> GetValidationCases();
    }
}