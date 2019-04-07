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