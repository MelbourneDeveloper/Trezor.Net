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
        /// <summary>
        /// This looks nasty
        /// </summary>
        public byte[] GetRange(int targetIndex, int arraySize)
        {
            var retVal = new byte[arraySize];
            for (var i = 0; i < arraySize; i++)
            {
                var index = targetIndex + i;

                //TODO: this looks dodgy...
                if (index >= retVal.Length)
                {
                    return retVal;
                }

                retVal[index] = _Bytes[i];
            }
            return retVal;
        }

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
