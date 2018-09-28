namespace Trezor.Net
{
    public class ReadException : ManagerException
    {
        public byte[] ReadData;
        public object LastWrittenMessage;

        public ReadException(string message, byte[] readData, object lastWrittenMessage) : base(message)
        {
            ReadData = readData;
        }
    }
}