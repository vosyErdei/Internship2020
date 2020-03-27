// Copyright @Internship2020

namespace netFundamentals
{
    using System;
    using MatchingLogic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var dataBuilder = new DataBuilder();
            var subjectImport = dataBuilder.GetImportEntry("swimming", Guid.NewGuid());

            dataBuilder.ValidateListImportEntries(subjectImport);

            //deprecated
            var dataBuilderOld = new DataBuilderOld();
            var subjectImportOld = dataBuilderOld.GetImportEntryOld("swimming", Guid.NewGuid());

            dataBuilderOld.ValidateListImportEntriesOld(subjectImportOld);
        }
    }
}
