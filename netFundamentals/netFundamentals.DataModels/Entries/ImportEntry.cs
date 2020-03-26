// Copyright @Internship2020

namespace netFundamentals.DataModels.Entries
{
    using System;

    public class ImportEntry
    {
        public ImportEntry()
        {
        }

        public ImportEntry(Guid id, int statusCode)
        {
            StatusCode = statusCode;

            if (id == Guid.Empty)
            {
                Id = new Guid();
            }
        }

        public ImportEntry(Guid id, int statusCode, string hobby)
        : this(id, statusCode)
        {
            if (StatusCode != 0 && string.IsNullOrEmpty(hobby))
            {
                ProcessStatus = Resources.Phase3;
            }
            else
            {
                Id = id;
                StatusCode = statusCode;
                Hobby = hobby;
            }
        }

        public Guid Id { get; set; }

        public int StatusCode { get; }

        public string ProcessStatus { get; }

        public string Hobby { get; set; }
    }
}
