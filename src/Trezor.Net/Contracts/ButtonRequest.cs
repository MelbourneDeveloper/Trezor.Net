using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class ButtonRequest
    {
        [ProtoMember(1, Name = @"code")]
        [DefaultValue(ButtonRequestType.ButtonRequestOther)]
        public ButtonRequestType Code
        {
            get => __pbn__Code ?? ButtonRequestType.ButtonRequestOther;
            set => __pbn__Code = value;
        }
        public bool ShouldSerializeCode() => __pbn__Code != null;
        public void ResetCode() => __pbn__Code = null;
        private ButtonRequestType? __pbn__Code;

        [ProtoMember(2, Name = @"data")]
        [DefaultValue("")]
        public string Data
        {
            get => __pbn__Data ?? "";
            set => __pbn__Data = value;
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private string __pbn__Data;

    }
}