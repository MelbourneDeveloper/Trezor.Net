using System.ComponentModel;
using ProtoBuf;

namespace Trezor
{
    public class NEMCosignatoryModification
    {
        [ProtoMember(1, Name = @"type")]
        [DefaultValue(NEMModificationType.CosignatoryModificationAdd)]
        public NEMModificationType Type
        {
            get => __pbn__Type ?? NEMModificationType.CosignatoryModificationAdd;
            set => __pbn__Type = value;
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private NEMModificationType? __pbn__Type;

        [ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey { get; set; }

        public bool ShouldSerializePublicKey() => PublicKey != null;
        public void ResetPublicKey() => PublicKey = null;
    }
}