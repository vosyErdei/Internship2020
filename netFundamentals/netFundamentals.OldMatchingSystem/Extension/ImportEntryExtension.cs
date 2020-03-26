// Copyright @Internship2020

namespace netFundamentals.OldMatchingSystem.Extension
{
    using Entries;

    public static class ImportEntryExtension
    {
        public static bool IsErrorStatusCode(this ImportEntry importEntry)
        {
            return importEntry.StatusCode != 0;
        }

        public static bool IsMatching(this ImportEntry importEntry, ImportEntry matchingEntry)
        {
            return !string.IsNullOrEmpty(matchingEntry.Hobby) && importEntry.Hobby == matchingEntry.Hobby;
        }
    }
}
