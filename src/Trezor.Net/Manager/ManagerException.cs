using System;

#pragma warning disable CA1032

namespace Trezor.Net
{
    public class ManagerException : Exception
    {
        public ManagerException(string message) : base(message)
        {

        }

        public ManagerException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
