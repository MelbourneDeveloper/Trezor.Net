using ProtoBuf;

namespace Trezor
{
    public static class Extensions
    {
        public static bool GetWireIn(this EnumValueOptions obj)
            => obj == null ? default(bool) : Extensible.GetValue<bool>(obj, 50002);

        public static bool GetWireOut(this EnumValueOptions obj)
            => obj == null ? default(bool) : Extensible.GetValue<bool>(obj, 50003);

        public static bool GetWireDebugIn(this EnumValueOptions obj)
            => obj == null ? default(bool) : Extensible.GetValue<bool>(obj, 50004);

        public static bool GetWireDebugOut(this EnumValueOptions obj)
            => obj == null ? default(bool) : Extensible.GetValue<bool>(obj, 50005);

        public static bool GetWireTiny(this EnumValueOptions obj)
            => obj == null ? default(bool) : Extensible.GetValue<bool>(obj, 50006);

        public static bool GetWireBootloader(this EnumValueOptions obj)
            => obj == null ? default(bool) : Extensible.GetValue<bool>(obj, 50007);

    }
}