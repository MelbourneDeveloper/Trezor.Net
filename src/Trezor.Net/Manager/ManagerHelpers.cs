namespace Trezor.Net
{
    public static class ManagerHelpers
    {
        #region Constants
        private const uint HardeningConstant = 0x80000000;
        #endregion

        #region Protected Static Methods
        public static uint[] GetAddressPath(bool isSegwit, uint account, bool isChange, uint index, uint coinnumber)
        {
            return new[] { ((isSegwit ? (uint)49 : 44) | HardeningConstant) >> 0, (coinnumber | HardeningConstant) >> 0, (account | HardeningConstant) >> 0, isChange ? 1 : (uint)0, index };
        }
        #endregion
    }
}
