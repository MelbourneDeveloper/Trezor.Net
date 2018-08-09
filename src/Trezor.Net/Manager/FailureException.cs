using System;

namespace Trezor.Manager
{
    [Serializable]
    public class FailureException<T> : Exception
    {
        public T Failure { get; private set; }

        public FailureException(string message, T failure) : base($"{message}\r\n{(failure as dynamic).Message}")
        {
            Failure = failure;
        }
    }
}