namespace Trezor.Net
{
    public class ReadException : ManagerException
    {
        public byte[] ReadData;

        public ReadException(string message, byte[] readData) : base(message)
        {
            ReadData = readData;
        }
    }
}