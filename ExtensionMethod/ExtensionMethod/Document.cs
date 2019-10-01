using System;

namespace ExtensionMethod
{
    public class Document
    {
        public string Content => $"Update at {_updateDate}";
        private readonly DateTime _updateDate;

        public Document(DateTime updateDate)
        {
            _updateDate = updateDate;
            //_updateDate = TransferROCDateTime(updateDate);
        }

        private DateTime TransferROCDateTime(DateTime updateDate)
        {
            return updateDate.AddYears(-1911);
        }
    }
}