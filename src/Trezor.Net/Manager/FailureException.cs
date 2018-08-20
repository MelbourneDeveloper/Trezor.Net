using System;

namespace Trezor.Net
{
    [Serializable]
    public class FailureException<T> : Exception
    {
        public T Failure { get; }

        public FailureException(string message, T failure) : base($"{message}\r\n{(failure as dynamic)?.Message}")
        {
            Failure = failure;
        }
    }
}