using System.Collections.Generic;
using System.Linq;

namespace Trezor.Net
{
    public class ByteBuffer
    {
        #region Fields
        private readonly List<byte> _Bytes;

        #endregion

        #region Public Properties
        public int Position { get; private set; }
        #endregion

        #region Constructor
        public ByteBuffer(int size)
        {
            _Bytes = new byte[size].ToList();
        }
        #endregion

        #region Public Methods


        public void Put(byte theByte)
        {
            _Bytes[Position] = theByte;
            Position++;
        }

        public void Put(byte[] bytes)
        {
            foreach (var thebyte in bytes)
            {
                Put(thebyte);
            }
        }

        public byte[] ToArray()
        {
            return _Bytes.ToArray();
        }

        public void Put(byte[] bytes, int startIndex, int Length)
        {
            for (var i = startIndex; i < Length; i++)
            {
                Put(bytes[i]);
            }
        }
        #endregion
    }
}
