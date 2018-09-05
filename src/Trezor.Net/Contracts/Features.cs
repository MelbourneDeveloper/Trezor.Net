using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace Trezor.Net.Contracts
{
    [ProtoContract]
    public class Features
    {
        [ProtoMember(1, Name = @"vendor")]
        [DefaultValue("")]
        public string Vendor
        {
            get => __pbn__Vendor ?? "";
            set => __pbn__Vendor = value;
        }
        public bool ShouldSerializeVendor() => __pbn__Vendor != null;
        public void ResetVendor() => __pbn__Vendor = null;
        private string __pbn__Vendor;

        [ProtoMember(2, Name = @"major_version")]
        public uint MajorVersion
        {
            get => __pbn__MajorVersion.GetValueOrDefault();
            set => __pbn__MajorVersion = value;
        }
        public bool ShouldSerializeMajorVersion() => __pbn__MajorVersion != null;
        public void ResetMajorVersion() => __pbn__MajorVersion = null;
        private uint? __pbn__MajorVersion;

        [ProtoMember(3, Name = @"minor_version")]
        public uint MinorVersion
        {
            get => __pbn__MinorVersion.GetValueOrDefault();
            set => __pbn__MinorVersion = value;
        }
        public bool ShouldSerializeMinorVersion() => __pbn__MinorVersion != null;
        public void ResetMinorVersion() => __pbn__MinorVersion = null;
        private uint? __pbn__MinorVersion;

        [ProtoMember(4, Name = @"patch_version")]
        public uint PatchVersion
        {
            get => __pbn__PatchVersion.GetValueOrDefault();
            set => __pbn__PatchVersion = value;
        }
        public bool ShouldSerializePatchVersion() => __pbn__PatchVersion != null;
        public void ResetPatchVersion() => __pbn__PatchVersion = null;
        private uint? __pbn__PatchVersion;

        [ProtoMember(5, Name = @"bootloader_mode")]
        public bool BootloaderMode
        {
            get => __pbn__BootloaderMode.GetValueOrDefault();
            set => __pbn__BootloaderMode = value;
        }
        public bool ShouldSerializeBootloaderMode() => __pbn__BootloaderMode != null;
        public void ResetBootloaderMode() => __pbn__BootloaderMode = null;
        private bool? __pbn__BootloaderMode;

        [ProtoMember(6, Name = @"device_id")]
        [DefaultValue("")]
        public string DeviceId
        {
            get => __pbn__DeviceId ?? "";
            set => __pbn__DeviceId = value;
        }
        public bool ShouldSerializeDeviceId() => __pbn__DeviceId != null;
        public void ResetDeviceId() => __pbn__DeviceId = null;
        private string __pbn__DeviceId;

        [ProtoMember(7, Name = @"pin_protection")]
        public bool PinProtection
        {
            get => __pbn__PinProtection.GetValueOrDefault();
            set => __pbn__PinProtection = value;
        }
        public bool ShouldSerializePinProtection() => __pbn__PinProtection != null;
        public void ResetPinProtection() => __pbn__PinProtection = null;
        private bool? __pbn__PinProtection;

        [ProtoMember(8, Name = @"passphrase_protection")]
        public bool PassphraseProtection
        {
            get => __pbn__PassphraseProtection.GetValueOrDefault();
            set => __pbn__PassphraseProtection = value;
        }
        public bool ShouldSerializePassphraseProtection() => __pbn__PassphraseProtection != null;
        public void ResetPassphraseProtection() => __pbn__PassphraseProtection = null;
        private bool? __pbn__PassphraseProtection;

        [ProtoMember(9, Name = @"language")]
        [DefaultValue("")]
        public string Language
        {
            get => __pbn__Language ?? "";
            set => __pbn__Language = value;
        }
        public bool ShouldSerializeLanguage() => __pbn__Language != null;
        public void ResetLanguage() => __pbn__Language = null;
        private string __pbn__Language;

        [ProtoMember(10, Name = @"label")]
        [DefaultValue("")]
        public string Label
        {
            get => __pbn__Label ?? "";
            set => __pbn__Label = value;
        }
        public bool ShouldSerializeLabel() => __pbn__Label != null;
        public void ResetLabel() => __pbn__Label = null;
        private string __pbn__Label;

        [ProtoMember(11, Name = @"coins")]
        public List<CoinType> Coins { get; } = new List<CoinType>();

        [ProtoMember(12, Name = @"initialized")]
        public bool Initialized
        {
            get => __pbn__Initialized.GetValueOrDefault();
            set => __pbn__Initialized = value;
        }
        public bool ShouldSerializeInitialized() => __pbn__Initialized != null;
        public void ResetInitialized() => __pbn__Initialized = null;
        private bool? __pbn__Initialized;

        [ProtoMember(13, Name = @"revision")]
        public byte[] Revision { get; set; }

        public bool ShouldSerializeRevision() => Revision != null;
        public void ResetRevision() => Revision = null;

        [ProtoMember(14, Name = @"bootloader_hash")]
        public byte[] BootloaderHash { get; set; }

        public bool ShouldSerializeBootloaderHash() => BootloaderHash != null;
        public void ResetBootloaderHash() => BootloaderHash = null;

        [ProtoMember(15, Name = @"imported")]
        public bool Imported
        {
            get => __pbn__Imported.GetValueOrDefault();
            set => __pbn__Imported = value;
        }
        public bool ShouldSerializeImported() => __pbn__Imported != null;
        public void ResetImported() => __pbn__Imported = null;
        private bool? __pbn__Imported;

        [ProtoMember(16, Name = @"pin_cached")]
        public bool PinCached
        {
            get => __pbn__PinCached.GetValueOrDefault();
            set => __pbn__PinCached = value;
        }
        public bool ShouldSerializePinCached() => __pbn__PinCached != null;
        public void ResetPinCached() => __pbn__PinCached = null;
        private bool? __pbn__PinCached;

        [ProtoMember(17, Name = @"passphrase_cached")]
        public bool PassphraseCached
        {
            get => __pbn__PassphraseCached.GetValueOrDefault();
            set => __pbn__PassphraseCached = value;
        }
        public bool ShouldSerializePassphraseCached() => __pbn__PassphraseCached != null;
        public void ResetPassphraseCached() => __pbn__PassphraseCached = null;
        private bool? __pbn__PassphraseCached;

        [ProtoMember(18, Name = @"firmware_present")]
        public bool FirmwarePresent
        {
            get => __pbn__FirmwarePresent.GetValueOrDefault();
            set => __pbn__FirmwarePresent = value;
        }
        public bool ShouldSerializeFirmwarePresent() => __pbn__FirmwarePresent != null;
        public void ResetFirmwarePresent() => __pbn__FirmwarePresent = null;
        private bool? __pbn__FirmwarePresent;

        [ProtoMember(19, Name = @"needs_backup")]
        public bool NeedsBackup
        {
            get => __pbn__NeedsBackup.GetValueOrDefault();
            set => __pbn__NeedsBackup = value;
        }
        public bool ShouldSerializeNeedsBackup() => __pbn__NeedsBackup != null;
        public void ResetNeedsBackup() => __pbn__NeedsBackup = null;
        private bool? __pbn__NeedsBackup;

        [ProtoMember(20, Name = @"flags")]
        public uint Flags
        {
            get => __pbn__Flags.GetValueOrDefault();
            set => __pbn__Flags = value;
        }
        public bool ShouldSerializeFlags() => __pbn__Flags != null;
        public void ResetFlags() => __pbn__Flags = null;
        private uint? __pbn__Flags;

        [ProtoMember(21, Name = @"model")]
        [DefaultValue("")]
        public string Model
        {
            get => __pbn__Model ?? "";
            set => __pbn__Model = value;
        }
        public bool ShouldSerializeModel() => __pbn__Model != null;
        public void ResetModel() => __pbn__Model = null;
        private string __pbn__Model;

    }
}