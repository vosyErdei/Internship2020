// Copyright @Internship2020

namespace netFundamentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MatchingRules;
    using OldMatchingSystem.Entries;
    
    internal class DataBuilderOld
    {
        //deprecated
        public void ValidateListImportEntriesOld(ImportEntry subjectImport)
        {
            var matchingRule = new HumanMatchingRuleOld();

            var importEntryList = GetImportEntryListOld();

            foreach (var importEntry in importEntryList.Where(importEntry => matchingRule.Match(importEntry, subjectImport)))
            {
                Console.WriteLine(Resource.MatchIsDoneMessage, importEntry.Id);
            }
        }

        public ImportEntry GetImportEntryOld(string hobby, Guid id, bool isCtor = false, int statusCode = 0)
        {
            return isCtor ? new ImportEntry(id, statusCode, hobby) : new ImportEntry { Id = id, Hobby = hobby };
        }

        private IEnumerable<ImportEntry> GetImportEntryListOld()
        {
            var firstImport = GetImportEntryOld("swimming", Guid.NewGuid());
            var secondImport = GetImportEntryOld("", Guid.Empty);
            var thirdImport = GetImportEntryOld("swimming", Guid.NewGuid());
            var forthImport = GetImportEntryOld("swimming", Guid.NewGuid(), true, 2);
            var fifthImport = GetImportEntryOld("swimming", Guid.NewGuid(), true, 3);

            return new List<ImportEntry> { firstImport, secondImport, thirdImport, forthImport, fifthImport };
        }
    }
}
