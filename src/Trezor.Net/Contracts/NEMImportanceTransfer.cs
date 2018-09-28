using System.ComponentModel;
using ProtoBuf;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class NEMImportanceTransfer
    {
        [ProtoMember(1, Name = @"mode")]
        [DefaultValue(NEMImportanceTransferMode.ImportanceTransferActivate)]
        public NEMImportanceTransferMode Mode
        {
            get => __pbn__Mode ?? NEMImportanceTransferMode.ImportanceTransferActivate;
            set => __pbn__Mode = value;
        }
        public bool ShouldSerializeMode() => __pbn__Mode != null;
        public void ResetMode() => __pbn__Mode = null;
        private NEMImportanceTransferMode? __pbn__Mode;

        [ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey { get; set; }

        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;
    }
}