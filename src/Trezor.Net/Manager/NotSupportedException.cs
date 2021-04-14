using System;

#pragma warning disable CA1032

namespace Trezor.Net
{
    public class NotSupportedException : Exception
    {
        public NotSupportedException(string message) : base(message)
        {

        }

        public NotSupportedException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
