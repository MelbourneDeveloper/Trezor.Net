#pragma warning disable CA1819 // Properties should not return arrays
#pragma warning disable CA1032

namespace Trezor.Net
{
    public class ReadException : ManagerException
    {
        public byte[] ReadData { get; }
        public object LastWrittenMessage { get; }

        public ReadException(string message, byte[] readData, object lastWrittenMessage) : base(message)
        {
            ReadData = readData;
            LastWrittenMessage = lastWrittenMessage;
        }
    }
}