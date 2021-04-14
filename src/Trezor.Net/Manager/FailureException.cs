using System;

#pragma warning disable CA2229
#pragma warning disable CA1032

namespace Trezor.Net
{
    [Serializable]
    public class FailureException<T> : Exception
    {
        public T Failure { get; }

        public FailureException(string message, T failure) : base($"{message}\r\n{GetFailureMessage(failure)}") => Failure = failure;

        private static string GetFailureMessage(object failure)
        {
            var messageProperty = failure.GetType().GetProperty("Message");
            return messageProperty != null ? messageProperty.GetValue(failure, null) as string : null;
        }
    }
}