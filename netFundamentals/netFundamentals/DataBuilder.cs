// Copyright @Internship2020

namespace netFundamentals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using MatchingRules;
    using DataModels.Entries;
    
    internal class DataBuilder
    {
        public void ValidateListImportEntries(ImportEntry subjectImport)
        {
            var matchingRule = new HumanMatchingRule();

            var importEntryList = GetImportEntryList();

            foreach (var importEntry in importEntryList.Where(importEntry => matchingRule.Match(importEntry, subjectImport)))
            {
                Console.WriteLine(Resource.MatchIsDoneMessage, importEntry.Id);
            }
        }

        public ImportEntry GetImportEntry(string hobby, Guid id, bool isCtor = false, int statusCode = 0)
        {
            return isCtor ? new ImportEntry(id, statusCode, hobby) : new ImportEntry { Id = id, Hobby = hobby };
        }

        private IEnumerable<ImportEntry> GetImportEntryList()
        {
            var firstImport = GetImportEntry("swimming", Guid.NewGuid());
            var secondImport = GetImportEntry("", Guid.Empty);
            var thirdImport = GetImportEntry("swimming", Guid.NewGuid());
            var forthImport = GetImportEntry("swimming", Guid.NewGuid(), true, 2);
            var fifthImport = GetImportEntry("swimming", Guid.NewGuid(), true, 3);

            return new List<ImportEntry> { firstImport, secondImport, thirdImport, forthImport, fifthImport };
        }
    }
}
