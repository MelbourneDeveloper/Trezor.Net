namespace Trezor.Net
{
    public static class EntensionMethods
    {
        public static byte[] ToBytes(this uint value)
        {
            return new byte[]
            {
                //(byte)(value >> 24),
                //(byte)(value >> 16),
                (byte)(value >> 8),
                (byte)value,
            };
        }
    }
}
