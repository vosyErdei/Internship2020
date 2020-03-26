// Copyright @Internship2020

namespace netFundamentals.MatchingRules
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    internal class ValidationCreator : IValidationCreator
    {
        private readonly List<IValidationCase> _validationCases;

        public ValidationCreator(IEnumerable<IValidationCase> validationList)
        {
            _validationCases = new List<IValidationCase>(validationList);
        }

        public List<IValidationCase> GetValidationCases()
        {
            return _validationCases.OrderBy(x => x.Order).ToList();
        }
    }
}
