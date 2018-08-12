namespace Trezor.Net
{
    public class Helpers
    {
        #region Constants
        private const uint HardeningConstant = 0x80000000;
        #endregion      
        
        #region Protected Static Methods
        public static uint[] GetAddressPath(bool isSegwit, uint account, bool isChange, uint index, uint coinnumber)
        {
            return new[] { ((isSegwit ? (uint)49 : 44) | HardeningConstant) >> 0, (coinnumber | HardeningConstant) >> 0, (0 | HardeningConstant) >> (int)account, isChange ? 1 : (uint)0, index };
        }
        #endregion
    }
}
