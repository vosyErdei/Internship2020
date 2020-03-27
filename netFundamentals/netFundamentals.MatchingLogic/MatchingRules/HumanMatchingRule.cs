// Copyright @Internship2020

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("netFundamentals")]

namespace netFundamentals.MatchingLogic.MatchingRules
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DataModels.Entries;
    using DataModels.Enum;
    using Logging;
    using netFundamentals.MatchingLogic.Logging.Interfaces;
    using Cases;
    using Interfaces;

    internal class HumanMatchingRule
    {
        private readonly ILogger _logger = new Logger();
        private readonly IValidationCreator _validationCreator;

        public HumanMatchingRule()
        {
            var list = new List<IValidationCase> { new ErrorStatusCodeValidationCase(), new MatchingValidationCase() };

            _validationCreator = new ValidationCreator(list);
        }

        public bool Match(ImportEntry importEntry, ImportEntry matchEntry)
        {
            return IsValid(importEntry, matchEntry);
        }

        private bool IsValid(ImportEntry importEntry, ImportEntry matchEntry)
        {
            foreach (var validationCase in _validationCreator.GetValidationCases().Where(validationCase => !validationCase.Validate(importEntry, matchEntry)))
            {
                _logger.Log(string.Format(Resource.ValidationLog, ValidationStatus.Failed, GetMatchState(validationCase), importEntry.Id, matchEntry.Id, Resource.FailureMessage));

                return false;
            }

            _logger.Log(string.Format(Resource.ValidationLog, (ValidationStatus)0, Resource.CompletedState, importEntry.Id, matchEntry.Id, Resource.SuccessMessage));

            return true;
        }

        private string GetMatchState(IValidationCase validationCase)
        {
            return Enum.IsDefined(typeof(MatchState), validationCase.Order) ? ((MatchState)validationCase.Order).ToString().ToUpperInvariant() : Resource.WrongMatchStatus;
        }
    }
}
