using System;

namespace ExtensionMethod
{
    public class Email
    {
        public string Content => $"Send at {_submitDate}";
        private readonly DateTime _submitDate;

        public Email(DateTime submitDate)
        {
            _submitDate = submitDate;
            //_submitDate = TransferROCDateTime(submitDate);
        }

        private DateTime TransferROCDateTime(DateTime submitDate)
        {
            return submitDate.AddYears(-1911);
        }
    }
}