using System;

namespace Trezor.Manager
{
    [Serializable]
    internal class FailureException : Exception
    {
        public Failure Failure { get; private set; }

        public FailureException(string message, Failure failure) : base($"{message}\r\n{failure.Message}")
        {
            Failure = failure;
        }

    }
}